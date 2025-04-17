
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
namespace ArtFestival
{
    public partial class Form1 : Form
    {
        private ArtFestivalDbContext _db;
        public Form1()
        {
            _db = new ArtFestivalDbContext();
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.Font = new Font("Segoe UI", 9F);
            Initialize();
        }
        private void Initialize()
        {
            try
            {
                _db = new ArtFestivalDbContext();

                var categories = new List<string>
        {
            "Классическая живопись",
            "Современное искусство",
            "Театральное искусство",
            "Скульптура и инсталляции"
        };

                cmbAddCategory.DataSource = categories;
                cmbEditCategory.DataSource = categories;
                cmbMainFilterCategory.DataSource = new List<string>
                { "Все категории" }.Concat(categories).ToList();

                var users = _db.Users.ToList();
                clbAddParticipants.DataSource = users;
                clbAddParticipants.DisplayMember = "Name";
                clbEditParticipants.DataSource = users;
                clbEditParticipants.DisplayMember = "Name";

                LoadAllEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка инициализации: {ex.Message}");
            }
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAddTitle.Text))
                {
                    MessageBox.Show("Введите название события");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtAddDescription.Text))
                {
                    MessageBox.Show("Введите описание события");
                    return;
                }
                if (clbAddParticipants.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Выберите хотя бы одного участника");
                    return;
                }
                if (pictureBoxForAdd.Image == null || pictureBoxForAdd.Tag == null)
                {
                    MessageBox.Show("Сначала добавьте изображение");
                    return;
                }

                byte[] imageData = File.ReadAllBytes(pictureBoxForAdd.Tag.ToString());

                var newEvent = new Event
                {
                    EventDate = dtpAddDate.Value.ToUniversalTime(),
                    Title = txtAddTitle.Text,
                    Description = txtAddDescription.Text,
                    Category = cmbAddCategory.SelectedItem?.ToString(),
                    Users = new List<EventUser>(),
                    ImageData = imageData
                };

                foreach (var user in clbAddParticipants.CheckedItems.Cast<User>())
                {
                    newEvent.Users.Add(new EventUser { UserID = user.UserID });
                }

                if (_db.Events.Any(ev => ev.Title == newEvent.Title &&
                ev.EventDate.Date == newEvent.EventDate.Date))
                {
                    MessageBox.Show("Такое событие уже есть!");
                    return;
                }

                _db.Events.Add(newEvent);
                _db.SaveChanges();
                LoadAllEvents();

                MessageBox.Show("Событие успешно создано!");

                // Очистка
                txtAddTitle.Clear();
                txtAddDescription.Clear();
                pictureBoxForAdd.Image = null;
                pictureBoxForAdd.Tag = null;
                foreach (int i in clbAddParticipants.CheckedIndices)
                    clbAddParticipants.SetItemChecked(i, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}\n\nДетали:" +
                    $"\n{ex.InnerException?.Message}");
            }
        }


        private byte[]? UploadImage()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Изображения|*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    return File.ReadAllBytes(ofd.FileName);
                }
            }
            return null;
        }
        private void LoadAllEvents()
        {
            try
            {
                var events = _db.Events
                    .Include(e => e.Users)
                    .OrderByDescending(e => e.EventDate)
                    .ToList();

                lbMainEvents.DataSource = new BindingList<Event>(events);
                lbMainEvents.DisplayMember = "Title";

                lbEditEvents.DataSource = new BindingList<Event>(events);
                lbEditEvents.DisplayMember = "Title";

                lbDeleteEvents.DataSource = new BindingList<Event>(events);
                lbDeleteEvents.DisplayMember = "Title";

                // Главная вкладка
                lbMainEvents.SelectedIndexChanged += (s, e) =>
                {
                    if (lbMainEvents.SelectedItem is Event ev)
                        DisplayEventDetails(ev, picEventImage, labelEventName,
                       labelEventDescription, labelEventTime, labelEventCategory, labelEventUsers);
                };

                // Редактирование
                lbEditEvents.SelectedIndexChanged += (s, e) =>
                {
                    if (lbEditEvents.SelectedItem is Event ev)
                    {
                        txtEditTitle.Text = ev.Title;
                        textBoxForEdit.Text = ev.Description;
                        dtpEditDate.Value = ev.EventDate;
                        cmbEditCategory.SelectedItem = ev.Category;

                        for (int i = 0; i < clbEditParticipants.Items.Count; i++)
                        {
                            var user = clbEditParticipants.Items[i] as User;
                            clbEditParticipants.SetItemChecked(i, ev.Users
                                .Any(u => u.UserID == user.UserID));
                        }

                        if (ev.ImageData != null)
                        {
                            using var ms = new MemoryStream(ev.ImageData);
                            pictureBoxEditImage.Image = Image.FromStream(ms);
                        }
                        else
                        {
                            pictureBoxEditImage.Image = null;
                        }
                    }
                };

                // Удаление
                lbDeleteEvents.SelectedIndexChanged += (s, e) =>
                {

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}");
            }
        }

        private void DisplayEventDetails(Event ev, PictureBox pictureBox,
            Label name, Label desc, Label date, Label category, Label users)
        {
            name.Text = $"Название события: {ev.Title}";
            desc.Text = $"Описание: {ev.Description}";
            date.Text = $"Дата: {ev.EventDate:dd.MM.yyyy HH:mm}";
            category.Text = $"Категория: {ev.Category}";

            var userIds = ev.Users.Select(u => u.UserID).ToList();
            var userNames = _db.Users
                .Where(u => userIds.Contains(u.UserID))
                .Select(u => u.Name)
                .ToList();

            users.Text = $"Участники: {string.Join(", ", userNames)}";

            if (ev.ImageData != null)
            {
                using var ms = new MemoryStream(ev.ImageData);
                pictureBox.Image = Image.FromStream(ms);
            }
            else
            {
                pictureBox.Image = null;
            }
        }

        private void lbMainEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMainEvents.SelectedItem is Event selectedEvent)
            {
                labelEventName.Text = selectedEvent.Title;
                labelEventDescription.Text = selectedEvent.Description;
                labelEventTime.Text = selectedEvent.EventDate.ToString("dd.MM.yyyy");
                labelEventCategory.Text = selectedEvent.Category;
                var userIds = selectedEvent.Users.Select(u => u.UserID).ToList();
                var userNames = _db.Users.Where(u => userIds
                .Contains(u.UserID)).Select(u => u.Name).ToList();
                labelEventUsers.Text = string.Join(", ", userNames);

                if (selectedEvent.ImageData != null)
                {
                    using (var ms = new MemoryStream(selectedEvent.ImageData))
                    {
                        picEventImage.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    picEventImage.Image = null;
                }
            }
        }


        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Изображения|*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxForAdd.Image = Image.FromFile(ofd.FileName);
                    pictureBoxForAdd.Tag = ofd.FileName; // сохраняем путь к файлу во временное хранилище
                }
            }
        }
        private void btnEditImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Изображения|*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxEditImage.Image = Image.FromFile(ofd.FileName);
                    pictureBoxEditImage.Tag = ofd.FileName; // Сохраняем путь к новому изображению
                }
            }
        }
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (lbEditEvents.SelectedItem is not Event selectedEvent)
            {
                MessageBox.Show("Выберите событие для редактирования.");
                return;
            }

            try
            {
                selectedEvent.Title = txtEditTitle.Text;
                selectedEvent.Description = textBoxForEdit.Text;
                selectedEvent.EventDate = dtpEditDate.Value.ToUniversalTime();
                selectedEvent.Category = cmbEditCategory.SelectedItem?.ToString();

                // Обновление участников
                selectedEvent.Users.Clear();
                foreach (var user in clbEditParticipants.CheckedItems.Cast<User>())
                {
                    selectedEvent.Users.Add(new EventUser { UserID = user.UserID });
                }

                // Обновление изображения (если было выбрано новое)
                if (pictureBoxEditImage.Tag is string imagePath && File.Exists(imagePath))
                {
                    selectedEvent.ImageData = File.ReadAllBytes(imagePath);
                }

                _db.SaveChanges();
                LoadAllEvents();

                MessageBox.Show("Событие успешно обновлено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbDeleteEvents.SelectedItem is not Event selectedEvent)
            {
                MessageBox.Show("Сначала выберите событие для удаления.");
                return;
            }
            var confirmResult = MessageBox.Show(
                $"Вы уверены, что хотите удалить событие \"{selectedEvent.Title}\"?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                _db.Events.Remove(selectedEvent);
                _db.SaveChanges();
                LoadAllEvents();

                MessageBox.Show("Событие удалено успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}");
            }
        }
        private void btnMainApplyFilter_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedCategory = cmbMainFilterCategory.SelectedItem as string;
                bool isDateFilterEnabled = dtpMainFilterDate.Checked;

                // Получаем события как IQueryable, чтобы фильтрация выполнялась в базе
                var query = _db.Events.AsQueryable();

                // Фильтрация по категории, если выбрана
                if (!string.IsNullOrEmpty(selectedCategory))
                {
                    query = query.Where(ev => ev.Category == selectedCategory);
                }

                // Фильтрация по дате, если галочка активна
                if (isDateFilterEnabled)
                {
                    // Явно указываем Kind = Utc, чтобы избежать ошибки PostgreSQL
                    DateTime selectedDate = DateTime.SpecifyKind(dtpMainFilterDate.Value.Date, DateTimeKind.Utc);

                    query = query.Where(ev => ev.EventDate.Date == selectedDate);
                }

                // Применяем фильтрацию и загружаем результат
                lbMainEvents.DataSource = query.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка фильтрации: " + ex.Message);
            }
        }
        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            try
            {
                cmbMainFilterCategory.SelectedIndex = 0;
                dtpMainFilterDate.Checked = false;
                var events = _db.Events
                    .Include(e => e.Users)
                    .OrderByDescending(e => e.EventDate)
                    .ToList();

                lbMainEvents.DataSource = new BindingList<Event>(events);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сбросе фильтров: {ex.Message}");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Получаем ВСЕ события без фильтров
                var allEvents = _db.Events
                    .Include(ev => ev.Users)
                    .OrderBy(ev => ev.EventDate)
                    .ToList();

                // 2. Создаем Excel-документ
                using var workbook = new ClosedXML.Excel.XLWorkbook();
                var worksheet = workbook.Worksheets.Add("Все события");

                // 3. Формируем заголовки
                int row = 1;
                worksheet.Cell(row, 1).Value = "Название";
                worksheet.Cell(row, 2).Value = "Дата";
                worksheet.Cell(row, 3).Value = "Описание";
                worksheet.Cell(row, 4).Value = "Категория";
                worksheet.Cell(row, 5).Value = "Участники";

                // Стиль для заголовков
                var headerRange = worksheet.Range(1, 1, 1, 5);
                headerRange.Style.Font.Bold = true;
                headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;

                row++;

                // 4. Заполняем данными
                foreach (var ev in allEvents)
                {
                    worksheet.Cell(row, 1).Value = ev.Title;
                    worksheet.Cell(row, 2).Value = ev.EventDate.ToString("dd.MM.yyyy HH:mm");
                    worksheet.Cell(row, 3).Value = ev.Description;
                    worksheet.Cell(row, 4).Value = ev.Category;

                    // Получаем имена участников
                    var userNames = ev.Users
                        .Select(u => u.User?.Name ?? "Неизвестный участник")
                        .ToList();

                    worksheet.Cell(row, 5).Value = string.Join(", ", userNames);
                    row++;
                }

                // 5. Настраиваем внешний вид
                worksheet.Columns().AdjustToContents(); // Автоподбор ширины

                // 6. Сохраняем файл
                using SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel файлы|*.xlsx";
                sfd.FileName = "Все_события_ArtFestival.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfd.FileName);
                    MessageBox.Show("Отчёт со всеми событиями успешно сохранён!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании отчёта: " + ex.Message,
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBoxAdd_Enter(object sender, EventArgs e)
        {

        }
    }

}
