
using ClosedXML.Excel;
using ClosedXML.Excel.Drawings;
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
                if (txtAddTitle.Text.Length > 50)
                {
                    MessageBox.Show("Название события не должно превышать 50 символов.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtAddDescription.Text))
                {
                    MessageBox.Show("Введите описание события");
                    return;
                }
                if (txtAddDescription.Text.Length > 100)
                {
                    MessageBox.Show("Описание события не должно превышать 100 символов.");
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
                    EventDate = dtpAddDate.Value.ToUniversalTime().AddHours(3),
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
                lbMainEvents.SelectedIndexChanged += (s, e) =>
                {
                    if (lbMainEvents.SelectedItem is Event ev)
                        DisplayEventDetails(ev, picEventImage, labelEventName,
                       labelEventDescription, labelEventTime, labelEventCategory, labelEventUsers);
                };
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
                    pictureBoxForAdd.Tag = ofd.FileName;
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
                    pictureBoxEditImage.Tag = ofd.FileName;
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
                if (string.IsNullOrWhiteSpace(txtEditTitle.Text))
                {
                    MessageBox.Show("Введите название события.");
                    return;
                }
                if (txtEditTitle.Text.Length > 50)
                {
                    MessageBox.Show("Название события не должно превышать 50 символов.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxForEdit.Text))
                {
                    MessageBox.Show("Введите описание события.");
                    return;
                }
                if (textBoxForEdit.Text.Length > 100)
                {
                    MessageBox.Show("Описание события не должно превышать 100 символов.");
                    return;
                }

                if (dtpEditDate.Value == null)
                {
                    MessageBox.Show("Укажите дату события.");
                    return;
                }

                if (cmbEditCategory.SelectedItem == null || string.IsNullOrWhiteSpace
                    (cmbEditCategory.SelectedItem.ToString()))
                {
                    MessageBox.Show("Выберите категорию события.");
                    return;
                }

                if (clbEditParticipants.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Выберите хотя бы одного участника.");
                    return;
                }
                bool isChanged = false;
                if (selectedEvent.Title != txtEditTitle.Text)
                {
                    selectedEvent.Title = txtEditTitle.Text;
                    isChanged = true;
                }
                if (selectedEvent.Description != textBoxForEdit.Text)
                {
                    selectedEvent.Description = textBoxForEdit.Text;
                    isChanged = true;
                }
                if (selectedEvent.EventDate != dtpEditDate.Value)
                {
                    selectedEvent.EventDate = dtpEditDate.Value.ToUniversalTime();
                    isChanged = true;
                }
                if (!isChanged)
                {
                    MessageBox.Show("Вы не внесли изменений.");
                    return;
                }
                selectedEvent.Title = txtEditTitle.Text;
                selectedEvent.Description = textBoxForEdit.Text;
                selectedEvent.EventDate = dtpEditDate.Value.ToUniversalTime().AddHours(3);
                selectedEvent.Category = cmbEditCategory.SelectedItem.ToString();

                selectedEvent.Users.Clear();
                foreach (var user in clbEditParticipants.CheckedItems.Cast<User>())
                {
                    selectedEvent.Users.Add(new EventUser { UserID = user.UserID });
                }

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
                string selectedCategory = cmbMainFilterCategory.SelectedItem?.ToString();
                bool filterByCategory = !string.IsNullOrEmpty(selectedCategory) && selectedCategory != "Все категории";
                bool filterByDate = dtpMainFilterDate.Checked;
                var query = _db.Events.AsQueryable();
                if (filterByCategory && filterByDate)
                {
                    DateTime filterDate = DateTime.SpecifyKind(dtpMainFilterDate.Value.Date, DateTimeKind.Utc);
                    query = query.Where(ev => ev.Category == selectedCategory &&
                                            ev.EventDate.Date == filterDate);
                }
                else if (filterByCategory)
                {
                    query = query.Where(ev => ev.Category == selectedCategory);
                }
                else if (filterByDate)
                {
                    DateTime filterDate = DateTime.SpecifyKind(dtpMainFilterDate.Value.Date, DateTimeKind.Utc);
                    query = query.Where(ev => ev.EventDate.Date == filterDate);
                }

                var filteredEvents = query
                    .Include(e => e.Users)
                    .OrderByDescending(e => e.EventDate)
                    .ToList();

                lbMainEvents.DataSource = new BindingList<Event>(filteredEvents);
                ClearEventDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка фильтрации: " + ex.Message);
            }
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            dtpMainFilterDate.Checked = false;
            cmbMainFilterCategory.SelectedIndex = 0;
            var events = _db.Events
               .Include(e => e.Users)
               .OrderByDescending(e => e.EventDate)
               .ToList();
            lbMainEvents.DataSource = new BindingList<Event>(events);
            ClearEventDetails();
        }
        private void ClearEventDetails()
        {
            labelEventName.Text = "Название события:";
            labelEventDescription.Text = "Описание:";
            labelEventTime.Text = "Дата:";
            labelEventCategory.Text = "Категория:";
            labelEventUsers.Text = "Участники:";
            picEventImage.Image = null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string categoryFilter = cmbMainFilterCategory.SelectedItem?.ToString() ?? "Все категории";
                string dateFilter = dtpMainFilterDate.Checked
                    ? dtpMainFilterDate.Value.ToString("dd.MM.yyyy")
                    : "Не задана";

                var events = ((BindingList<Event>)lbMainEvents.DataSource).ToList();

                using var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("События ArtFestival");

                var headerStyle = workbook.Style;
                headerStyle.Font.Bold = true;
                headerStyle.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                headerStyle.Fill.BackgroundColor = XLColor.LightGray;

                var titleStyle = workbook.Style;
                titleStyle.Font.Bold = true;
                titleStyle.Font.FontSize = 16;
                titleStyle.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                int row = 1;
                worksheet.Cell(row, 1).Value = "Отчет о событиях ArtFestival";
                worksheet.Cell(row, 1).Style = titleStyle;
                worksheet.Range(row, 1, row, 5).Merge();
                row++;

                worksheet.Cell(row, 1).Value = "Примененные фильтры:";
                worksheet.Cell(row, 1).Style.Font.Bold = true;
                row++;

                worksheet.Cell(row, 1).Value = "Категория:";
                worksheet.Cell(row, 2).Value = categoryFilter;
                row++;

                worksheet.Cell(row, 1).Value = "Дата:";
                worksheet.Cell(row, 2).Value = dateFilter;
                row += 2;

                string[] headers = { "Название", "Дата", "Описание", "Категория", "Участники" };
                for (int i = 0; i < headers.Length; i++)
                {
                    worksheet.Cell(row, i + 1).Value = headers[i];
                    worksheet.Cell(row, i + 1).Style = headerStyle;
                }

                row++;

                foreach (var ev in events)
                {
                    worksheet.Cell(row, 1).Value = ev.Title;
                    worksheet.Cell(row, 2).Value = ev.EventDate.ToString("dd.MM.yyyy HH:mm");
                    worksheet.Cell(row, 3).Value = ev.Description;
                    worksheet.Cell(row, 4).Value = ev.Category;

                    var userNames = ev.Users?
                        .Select(u => u.User?.Name ?? "Неизвестный участник")
                        .ToList() ?? new List<string>();

                    worksheet.Cell(row, 5).Value = string.Join(", ", userNames);

                    row++;
                }

                worksheet.Columns().AdjustToContents();

                using SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "Excel файлы|*.xlsx",
                    FileName = $"События_ArtFestival_{DateTime.Now:yyyyMMdd_HHmm}.xlsx"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfd.FileName);
                    MessageBox.Show($"Отчёт успешно сохранён!\nФайл: {Path.GetFileName(sfd.FileName)}",
                                    "Отчёт создан",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании отчёта: {ex.Message}",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }



    }
}
