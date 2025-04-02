using ArtFestival.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;


namespace ArtFestival
{
    
    
    public partial class Form1 : Form
    {
        private ArtFestivalDbContext _db;
        private List<string> _categories = new()
        {
        "������������ ��������",
        "����������� ���������",
        "����������� ���������"
        };
        public Form1()
        {
            _db = new ArtFestivalDbContext();
            InitializeComponent();
            InitializeAsync();
        }
        private async void InitializeAsync()
        {
            await InitializeDatabase();
            await ConfigureControlsAsync();
            await LoadDataAsync();
            ConfigureCategories();
        }
        private async Task InitializeDatabase()
        {
            await _db.Database.EnsureCreatedAsync();

            if (!_db.Users.Any())
            {

                _db.Users.AddRange(
                    new User { Name = "���� ������" },
                    new User { Name = "����� ��������" }
                );
                await _db.SaveChangesAsync();
            }

            var userCount = await _db.Users.CountAsync();
            MessageBox.Show($"������������� � ��: {userCount}");
        }

        private async Task ConfigureControlsAsync()
        {
            try
            {
                ConfigureCategories();
                await ConfigureParticipantsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��������� ���������: {ex.Message}");
            }
        }

        private void ConfigureCategories()
        {

            var categories = new List<string>
    {
        "������������ ��������",
        "����������� ���������",
        "����������� ���������",
        "���������� � �����������"
    };

            cmbAddCategory.BeginUpdate();
            cmbAddCategory.DataSource = categories;
            cmbAddCategory.EndUpdate();

            cmbMainFilterCategory.BeginUpdate();
            cmbMainFilterCategory.DataSource = new List<string> { "��� ���������" }.Concat(categories).ToList();
            cmbMainFilterCategory.EndUpdate();
        }

        private async Task ConfigureParticipantsAsync()
        {
            await _db.Users.LoadAsync();
            this.Invoke((MethodInvoker)delegate
            {
                clbAddParticipants.BeginUpdate();
                clbAddParticipants.DataSource = _db.Users.Local.ToBindingList();
                clbAddParticipants.DisplayMember = "Name";
                clbAddParticipants.ValueMember = "UserID";
                clbAddParticipants.EndUpdate();
            });
        }
        private async void btnAddEvent_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAddTitle.Text))
                {
                    MessageBox.Show("������� �������� �������");
                    return;
                }
                var newEvent = new Event
                {
                    EventDate = dtpAddDate.Value.ToUniversalTime(),
                    Title = txtAddTitle.Text,
                    Description = txtAddDescription.Text,
                    Category = cmbAddCategory.SelectedItem?.ToString(),
                    ImagePath = await UploadImageAsync(),
                    Users = new List<EventUser>()
                };
                foreach (var user in clbAddParticipants.CheckedItems.Cast<User>())
                {
                    newEvent.Users.Add(new EventUser { UserID = user.UserID });
                }
                _db.Events.Add(newEvent);
                await _db.SaveChangesAsync();
                await LoadEventsAsync();
                MessageBox.Show("������� ������� �������!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������: {ex.Message}\n\n������:\n{ex.InnerException?.Message}");
            }
        }
        private async Task<string?> UploadImageAsync()
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "�����������|*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string uploadsDir = Path.Combine(Application.StartupPath, "Uploads");
                        Directory.CreateDirectory(uploadsDir);

                        string fileName = $"{Guid.NewGuid()}{Path.GetExtension(ofd.FileName)}";
                        string destPath = Path.Combine(uploadsDir, fileName);

                        File.Copy(ofd.FileName, destPath);
                        return destPath;
                    }
                    catch
                    {
                        return null;
                    }
                }
            }
            return null;
        }
        private async Task LoadEventsAsync()
        {
            try
            {
                var events = await _db.Events
                    .Include(e => e.Users)
                    .ThenInclude(p => p.User)
                    .ToListAsync();

                lbMainEvents.DataSource = events;
                lbMainEvents.DisplayMember = "Title";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��������: {ex.Message}");
            }
        }

        private async Task SaveEventAsync(Event newEvent)
        {
            try
            {
                await _db.Events.AddAsync(newEvent);
                await _db.SaveChangesAsync();
                ClearAddForm();
                await LoadDataAsync();
                MessageBox.Show("������� ���������!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������: {ex.Message}");
            }
        }
        private async Task LoadDataAsync()
        {
            var events = await _db.Events
                .Include(e => e.Users)
                .ThenInclude(p => p.User)
                .ToListAsync();

            lbMainEvents.DataSource = events;
            lbEditEvents.DataSource = events.ToList();
            lbDeleteEvents.DataSource = events.ToList();
        }

        private bool ValidateAddForm()
        {
            if (string.IsNullOrWhiteSpace(txtAddTitle.Text))
            {
                MessageBox.Show("������� �������� �������");
                return false;
            }
            return true;
        }

        private void ClearAddForm()
        {
            txtAddTitle.Clear();
            dtpAddDate.Value = DateTime.Now;
            txtAddDescription.Clear();
            cmbAddCategory.SelectedIndex = 0;
            picEventImage.Image = null;
            for (int i = 0; i < clbAddParticipants.Items.Count; i++)
                clbAddParticipants.SetItemChecked(i, false);
        }




    }
}
