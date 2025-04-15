using ArtFestival.Model;
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
            "������������ ��������",
            "����������� ���������",
            "����������� ���������",
            "���������� � �����������"
        };

                cmbAddCategory.DataSource = categories;
                cmbEditCategory.DataSource = categories;
                cmbMainFilterCategory.DataSource = new List<string> { "��� ���������" }.Concat(categories).ToList();

                var users = _db.Users.ToList();
                clbAddParticipants.DataSource = users;
                clbAddParticipants.DisplayMember = "Name";
                clbEditParticipants.DataSource = users;
                clbEditParticipants.DisplayMember = "Name";

                LoadAllEvents();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ �������������: {ex.Message}");
            }
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAddTitle.Text))
                {
                    MessageBox.Show("������� �������� �������");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtAddDescription.Text))
                {
                    MessageBox.Show("������� �������� �������");
                    return;
                }
                if (clbAddParticipants.CheckedItems.Count == 0)
                {
                    MessageBox.Show("�������� ���� �� ������ ���������");
                    return;
                }
                if (pictureBoxForAdd.Image == null || pictureBoxForAdd.Tag == null)
                {
                    MessageBox.Show("������� �������� �����������");
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

                if (_db.Events.Any(ev => ev.Title == newEvent.Title && ev.EventDate.Date == newEvent.EventDate.Date))
                {
                    MessageBox.Show("����� ������� ��� ����!");
                    return;
                }

                _db.Events.Add(newEvent);
                _db.SaveChanges();
                LoadAllEvents();

                MessageBox.Show("������� ������� �������!");

                // �������
                txtAddTitle.Clear();
                txtAddDescription.Clear();
                pictureBoxForAdd.Image = null;
                pictureBoxForAdd.Tag = null;
                foreach (int i in clbAddParticipants.CheckedIndices)
                    clbAddParticipants.SetItemChecked(i, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������: {ex.Message}\n\n������:\n{ex.InnerException?.Message}");
            }
        }


        private byte[]? UploadImage()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "�����������|*.jpg;*.png";
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

                // ������� �������
                lbMainEvents.SelectedIndexChanged += (s, e) =>
                {
                    if (lbMainEvents.SelectedItem is Event ev)
                        DisplayEventDetails(ev, picEventImage, labelEventName, labelEventDescription, labelEventTime, labelEventCategory, labelEventUsers);
                };

                // ��������������
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
                            clbEditParticipants.SetItemChecked(i, ev.Users.Any(u => u.UserID == user.UserID));
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

                // ��������
                lbDeleteEvents.SelectedIndexChanged += (s, e) =>
                {

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��������: {ex.Message}");
            }
        }

        private void DisplayEventDetails(Event ev, PictureBox pictureBox, Label name, Label desc, Label date, Label category, Label users)
        {
            name.Text = $"�������� �������: {ev.Title}";
            desc.Text = $"��������: {ev.Description}";
            date.Text = $"����: {ev.EventDate:dd.MM.yyyy HH:mm}";
            category.Text = $"���������: {ev.Category}";

            var userIds = ev.Users.Select(u => u.UserID).ToList();
            var userNames = _db.Users
                .Where(u => userIds.Contains(u.UserID))
                .Select(u => u.Name)
                .ToList();

            users.Text = $"���������: {string.Join(", ", userNames)}";

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
                var userNames = _db.Users.Where(u => userIds.Contains(u.UserID)).Select(u => u.Name).ToList();
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
                ofd.Filter = "�����������|*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxForAdd.Image = Image.FromFile(ofd.FileName);
                    pictureBoxForAdd.Tag = ofd.FileName; // ��������� ���� � ����� �� ��������� ���������
                }
            }
        }
    }

}
