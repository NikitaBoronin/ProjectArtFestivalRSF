using ArtFestival.Model;
using Microsoft.EntityFrameworkCore;
namespace ArtFestival
{
    public partial class Form1 : Form
    {
        private ArtFestivalDbContext _db;
        public Form1()
        {
            _db = new ArtFestivalDbContext();
            InitializeComponent();
            InitializeAsync();
        }
        private async void InitializeAsync()
        {
            try
            {
                var categories = new List<string>
        {
            "Классическая живопись",
            "Современное искусство",
            "Театральное искусство",
            "Скульптура и инсталляции"
        };
                cmbAddCategory.DataSource = categories;
                cmbMainFilterCategory.DataSource = new List<string> { "Все категории" }
                    .Concat(categories).ToList();
                var users = _db.Users.ToList();
                clbAddParticipants.DataSource = users;
                clbAddParticipants.DisplayMember = "Name";

                await LoadAllEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
        private async void btnAddEvent_Click(object sender, EventArgs e)
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
                if (string.IsNullOrWhiteSpace(txtAddTitle.Text))
                {
                    MessageBox.Show("Введите название события");
                    return;
                }
                if (clbAddParticipants.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Выберите хотя бы одного участника");
                    return;
                }
                var newEvent = new Event
                {
                    EventDate = dtpAddDate.Value.ToUniversalTime(),
                    Title = txtAddTitle.Text,
                    Description = txtAddDescription.Text,
                    Category = cmbAddCategory.SelectedItem?.ToString(),
                    Users = new List<EventUser>(),
                    ImagePath = await UploadImageAsync()
                };

                foreach (var user in clbAddParticipants.CheckedItems.Cast<User>())
                {
                    newEvent.Users.Add(new EventUser { UserID = user.UserID });
                }
                var allEvents = _db.Events.ToList();
                foreach (var ev in allEvents)
                {
                    if (ev.Title == txtAddTitle.Text && ev.EventDate.Date == dtpAddDate.Value.Date)
                    {
                        MessageBox.Show("Такое событие уже есть!");
                        return;
                    }
                }
                _db.Events.Add(newEvent);
                await _db.SaveChangesAsync();
                await LoadAllEvents();
                MessageBox.Show("Событие успешно создано!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}\n\nДетали:\n{ex.InnerException?.Message}");
            }
        }
        private async Task<string?> UploadImageAsync()
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Изображения|*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    return ofd.FileName;
                }
            }
            return null;
        }
        private async Task LoadAllEvents()
        {
            try
            {
                var events = await _db.Events
                    .Include(e => e.Users)
                    .ThenInclude(p => p.User)
                    .OrderByDescending(e => e.EventDate)
                    .ToListAsync();
                lbMainEvents.DataSource = events;
                lbMainEvents.DisplayMember = "Title";
                lbEditEvents.DataSource = events.ToList();
                lbEditEvents.DisplayMember = "Title";
                lbDeleteEvents.DataSource = events.ToList();
                lbDeleteEvents.DisplayMember = "Title";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}");
            }
        }

        private void tabControlMain_BindingContextChanged(object sender, EventArgs e)
        {

        }
    }
}
