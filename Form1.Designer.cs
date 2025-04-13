namespace ArtFestival
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControlMain = new TabControl();
            tabPageMain = new TabPage();
            groupBoxView = new GroupBox();
            button1 = new Button();
            label2 = new Label();
            dtpMainFilterDate = new DateTimePicker();
            cmbMainFilterCategory = new ComboBox();
            btnMainApplyFilter = new Button();
            lbMainEvents = new ListBox();
            groupBoxDetails = new GroupBox();
            picEventImage = new PictureBox();
            labelEventName = new Label();
            labelEventDescription = new Label();
            labelEventTime = new Label();
            labelEventUsers = new Label();
            labelEventCategory = new Label();
            tabPageAdd = new TabPage();
            groupBoxAdd = new GroupBox();
            pictureBoxForAddPage = new PictureBox();
            txtAddTitle = new TextBox();
            dtpAddDate = new DateTimePicker();
            txtAddDescription = new TextBox();
            cmbAddCategory = new ComboBox();
            clbAddParticipants = new CheckedListBox();
            btnAddPicture = new Button();
            btnAddEvent = new Button();
            labelimageTitle = new Label();
            labelAddTitlee = new Label();
            labelAddDatee = new Label();
            labelAddDescriptionn = new Label();
            labelAddCategoryy = new Label();
            labelAddParticipantss = new Label();
            tabPageEdit = new TabPage();
            groupBoxEdit = new GroupBox();
            pictureBoxEditImage = new PictureBox();
            label1 = new Label();
            labelEditCategoryy = new Label();
            labelEditDatee = new Label();
            labelEditTitlee = new Label();
            lbEditEvents = new ListBox();
            txtEditTitle = new TextBox();
            dtpEditDate = new DateTimePicker();
            cmbEditCategory = new ComboBox();
            clbEditParticipants = new CheckedListBox();
            btnEditImage = new Button();
            btnSaveChanges = new Button();
            tabPageDelete = new TabPage();
            groupBoxDelete = new GroupBox();
            lbDeleteEvents = new ListBox();
            btnDelete = new Button();
            tabPageReport = new TabPage();
            tabControlMain.SuspendLayout();
            tabPageMain.SuspendLayout();
            groupBoxView.SuspendLayout();
            groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEventImage).BeginInit();
            tabPageAdd.SuspendLayout();
            groupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForAddPage).BeginInit();
            tabPageEdit.SuspendLayout();
            groupBoxEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEditImage).BeginInit();
            tabPageDelete.SuspendLayout();
            groupBoxDelete.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageMain);
            tabControlMain.Controls.Add(tabPageAdd);
            tabControlMain.Controls.Add(tabPageEdit);
            tabControlMain.Controls.Add(tabPageDelete);
            tabControlMain.Controls.Add(tabPageReport);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(875, 600);
            tabControlMain.TabIndex = 0;
            // 
            // tabPageMain
            // 
            tabPageMain.BackColor = Color.White;
            tabPageMain.Controls.Add(groupBoxView);
            tabPageMain.Controls.Add(groupBoxDetails);
            tabPageMain.Location = new Point(4, 29);
            tabPageMain.Name = "tabPageMain";
            tabPageMain.Padding = new Padding(3);
            tabPageMain.Size = new Size(867, 567);
            tabPageMain.TabIndex = 0;
            tabPageMain.Text = "Главное меню";
            // 
            // groupBoxView
            // 
            groupBoxView.BackColor = Color.White;
            groupBoxView.Controls.Add(button1);
            groupBoxView.Controls.Add(label2);
            groupBoxView.Controls.Add(dtpMainFilterDate);
            groupBoxView.Controls.Add(cmbMainFilterCategory);
            groupBoxView.Controls.Add(btnMainApplyFilter);
            groupBoxView.Controls.Add(lbMainEvents);
            groupBoxView.Location = new Point(10, 10);
            groupBoxView.Name = "groupBoxView";
            groupBoxView.Size = new Size(480, 553);
            groupBoxView.TabIndex = 0;
            groupBoxView.TabStop = false;
            groupBoxView.Text = "События и фильтрация";
            // 
            // button1
            // 
            button1.Location = new Point(23, 478);
            button1.Name = "button1";
            button1.Size = new Size(252, 30);
            button1.TabIndex = 5;
            button1.Text = "Сформировать Excel отчет";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(20, 444);
            label2.Name = "label2";
            label2.Size = new Size(136, 18);
            label2.TabIndex = 4;
            label2.Text = "Генерация отчета:";
            // 
            // dtpMainFilterDate
            // 
            dtpMainFilterDate.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpMainFilterDate.Format = DateTimePickerFormat.Custom;
            dtpMainFilterDate.Location = new Point(20, 30);
            dtpMainFilterDate.Name = "dtpMainFilterDate";
            dtpMainFilterDate.Size = new Size(200, 27);
            dtpMainFilterDate.TabIndex = 0;
            // 
            // cmbMainFilterCategory
            // 
            cmbMainFilterCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMainFilterCategory.FormattingEnabled = true;
            cmbMainFilterCategory.Location = new Point(20, 60);
            cmbMainFilterCategory.Name = "cmbMainFilterCategory";
            cmbMainFilterCategory.Size = new Size(200, 28);
            cmbMainFilterCategory.TabIndex = 1;
            // 
            // btnMainApplyFilter
            // 
            btnMainApplyFilter.Location = new Point(240, 30);
            btnMainApplyFilter.Name = "btnMainApplyFilter";
            btnMainApplyFilter.Size = new Size(200, 30);
            btnMainApplyFilter.TabIndex = 2;
            btnMainApplyFilter.Text = "Применить фильтр";
            // 
            // lbMainEvents
            // 
            lbMainEvents.FormattingEnabled = true;
            lbMainEvents.Location = new Point(20, 100);
            lbMainEvents.Name = "lbMainEvents";
            lbMainEvents.Size = new Size(420, 324);
            lbMainEvents.TabIndex = 3;
            // 
            // groupBoxDetails
            // 
            groupBoxDetails.BackColor = Color.White;
            groupBoxDetails.Controls.Add(picEventImage);
            groupBoxDetails.Controls.Add(labelEventName);
            groupBoxDetails.Controls.Add(labelEventDescription);
            groupBoxDetails.Controls.Add(labelEventTime);
            groupBoxDetails.Controls.Add(labelEventUsers);
            groupBoxDetails.Controls.Add(labelEventCategory);
            groupBoxDetails.Location = new Point(515, 10);
            groupBoxDetails.Name = "groupBoxDetails";
            groupBoxDetails.Size = new Size(349, 553);
            groupBoxDetails.TabIndex = 1;
            groupBoxDetails.TabStop = false;
            groupBoxDetails.Text = "Детали события";
            // 
            // picEventImage
            // 
            picEventImage.BorderStyle = BorderStyle.FixedSingle;
            picEventImage.Location = new Point(20, 30);
            picEventImage.Name = "picEventImage";
            picEventImage.Size = new Size(310, 160);
            picEventImage.TabIndex = 0;
            picEventImage.TabStop = false;
            // 
            // labelEventName
            // 
            labelEventName.AutoSize = true;
            labelEventName.Location = new Point(17, 214);
            labelEventName.Name = "labelEventName";
            labelEventName.Size = new Size(143, 20);
            labelEventName.TabIndex = 1;
            labelEventName.Text = "Название события:";
            // 
            // labelEventDescription
            // 
            labelEventDescription.AutoSize = true;
            labelEventDescription.Location = new Point(17, 250);
            labelEventDescription.Name = "labelEventDescription";
            labelEventDescription.Size = new Size(82, 20);
            labelEventDescription.TabIndex = 2;
            labelEventDescription.Text = "Описание:";
            // 
            // labelEventTime
            // 
            labelEventTime.AutoSize = true;
            labelEventTime.Location = new Point(17, 313);
            labelEventTime.Name = "labelEventTime";
            labelEventTime.Size = new Size(146, 20);
            labelEventTime.TabIndex = 3;
            labelEventTime.Text = "Время проведения:";
            // 
            // labelEventUsers
            // 
            labelEventUsers.AutoSize = true;
            labelEventUsers.Location = new Point(17, 351);
            labelEventUsers.Name = "labelEventUsers";
            labelEventUsers.Size = new Size(84, 20);
            labelEventUsers.TabIndex = 4;
            labelEventUsers.Text = "Участники:";
            // 
            // labelEventCategory
            // 
            labelEventCategory.AutoSize = true;
            labelEventCategory.Location = new Point(19, 446);
            labelEventCategory.Name = "labelEventCategory";
            labelEventCategory.Size = new Size(84, 20);
            labelEventCategory.TabIndex = 5;
            labelEventCategory.Text = "Категория:";
            // 
            // tabPageAdd
            // 
            tabPageAdd.BackColor = Color.White;
            tabPageAdd.Controls.Add(groupBoxAdd);
            tabPageAdd.Location = new Point(4, 29);
            tabPageAdd.Name = "tabPageAdd";
            tabPageAdd.Size = new Size(867, 567);
            tabPageAdd.TabIndex = 1;
            tabPageAdd.Text = "Добавить";
            // 
            // groupBoxAdd
            // 
            groupBoxAdd.BackColor = Color.White;
            groupBoxAdd.Controls.Add(pictureBoxForAddPage);
            groupBoxAdd.Controls.Add(txtAddTitle);
            groupBoxAdd.Controls.Add(dtpAddDate);
            groupBoxAdd.Controls.Add(txtAddDescription);
            groupBoxAdd.Controls.Add(cmbAddCategory);
            groupBoxAdd.Controls.Add(clbAddParticipants);
            groupBoxAdd.Controls.Add(btnAddPicture);
            groupBoxAdd.Controls.Add(btnAddEvent);
            groupBoxAdd.Controls.Add(labelimageTitle);
            groupBoxAdd.Controls.Add(labelAddTitlee);
            groupBoxAdd.Controls.Add(labelAddDatee);
            groupBoxAdd.Controls.Add(labelAddDescriptionn);
            groupBoxAdd.Controls.Add(labelAddCategoryy);
            groupBoxAdd.Controls.Add(labelAddParticipantss);
            groupBoxAdd.Location = new Point(10, 10);
            groupBoxAdd.Name = "groupBoxAdd";
            groupBoxAdd.Size = new Size(849, 549);
            groupBoxAdd.TabIndex = 0;
            groupBoxAdd.TabStop = false;
            groupBoxAdd.Text = "Добавление события";
            // 
            // pictureBoxForAddPage
            // 
            pictureBoxForAddPage.Location = new Point(369, 66);
            pictureBoxForAddPage.Name = "pictureBoxForAddPage";
            pictureBoxForAddPage.Size = new Size(413, 315);
            pictureBoxForAddPage.TabIndex = 16;
            pictureBoxForAddPage.TabStop = false;
            // 
            // txtAddTitle
            // 
            txtAddTitle.Location = new Point(88, 33);
            txtAddTitle.Name = "txtAddTitle";
            txtAddTitle.Size = new Size(211, 27);
            txtAddTitle.TabIndex = 0;
            // 
            // dtpAddDate
            // 
            dtpAddDate.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpAddDate.Format = DateTimePickerFormat.Custom;
            dtpAddDate.Location = new Point(88, 61);
            dtpAddDate.Name = "dtpAddDate";
            dtpAddDate.Size = new Size(211, 27);
            dtpAddDate.TabIndex = 1;
            // 
            // txtAddDescription
            // 
            txtAddDescription.Location = new Point(88, 95);
            txtAddDescription.Multiline = true;
            txtAddDescription.Name = "txtAddDescription";
            txtAddDescription.Size = new Size(208, 54);
            txtAddDescription.TabIndex = 2;
            // 
            // cmbAddCategory
            // 
            cmbAddCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAddCategory.FormattingEnabled = true;
            cmbAddCategory.Location = new Point(88, 161);
            cmbAddCategory.Name = "cmbAddCategory";
            cmbAddCategory.Size = new Size(208, 28);
            cmbAddCategory.TabIndex = 3;
            // 
            // clbAddParticipants
            // 
            clbAddParticipants.FormattingEnabled = true;
            clbAddParticipants.Location = new Point(88, 204);
            clbAddParticipants.Name = "clbAddParticipants";
            clbAddParticipants.Size = new Size(208, 26);
            clbAddParticipants.TabIndex = 4;
            // 
            // btnAddPicture
            // 
            btnAddPicture.Location = new Point(0, 318);
            btnAddPicture.Name = "btnAddPicture";
            btnAddPicture.Size = new Size(150, 63);
            btnAddPicture.TabIndex = 5;
            btnAddPicture.Text = "Добавить картинку";
            // 
            // btnAddEvent
            // 
            btnAddEvent.Location = new Point(176, 318);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(120, 63);
            btnAddEvent.TabIndex = 7;
            btnAddEvent.Text = "Добавить событие";
            btnAddEvent.Click += btnAddEvent_Click;
            // 
            // labelimageTitle
            // 
            labelimageTitle.AutoSize = true;
            labelimageTitle.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelimageTitle.Location = new Point(389, 18);
            labelimageTitle.Name = "labelimageTitle";
            labelimageTitle.Size = new Size(126, 20);
            labelimageTitle.TabIndex = 15;
            labelimageTitle.Text = "Изображение:";
            // 
            // labelAddTitlee
            // 
            labelAddTitlee.AutoSize = true;
            labelAddTitlee.Location = new Point(6, 33);
            labelAddTitlee.Name = "labelAddTitlee";
            labelAddTitlee.Size = new Size(80, 20);
            labelAddTitlee.TabIndex = 8;
            labelAddTitlee.Text = "Название:";
            // 
            // labelAddDatee
            // 
            labelAddDatee.AutoSize = true;
            labelAddDatee.Location = new Point(6, 66);
            labelAddDatee.Name = "labelAddDatee";
            labelAddDatee.Size = new Size(44, 20);
            labelAddDatee.TabIndex = 9;
            labelAddDatee.Text = "Дата:";
            // 
            // labelAddDescriptionn
            // 
            labelAddDescriptionn.AutoSize = true;
            labelAddDescriptionn.Location = new Point(6, 95);
            labelAddDescriptionn.Name = "labelAddDescriptionn";
            labelAddDescriptionn.Size = new Size(82, 20);
            labelAddDescriptionn.TabIndex = 10;
            labelAddDescriptionn.Text = "Описание:";
            // 
            // labelAddCategoryy
            // 
            labelAddCategoryy.AutoSize = true;
            labelAddCategoryy.Location = new Point(4, 161);
            labelAddCategoryy.Name = "labelAddCategoryy";
            labelAddCategoryy.Size = new Size(84, 20);
            labelAddCategoryy.TabIndex = 11;
            labelAddCategoryy.Text = "Категория:";
            // 
            // labelAddParticipantss
            // 
            labelAddParticipantss.AutoSize = true;
            labelAddParticipantss.Location = new Point(6, 204);
            labelAddParticipantss.Name = "labelAddParticipantss";
            labelAddParticipantss.Size = new Size(84, 20);
            labelAddParticipantss.TabIndex = 12;
            labelAddParticipantss.Text = "Участники:";
            // 
            // tabPageEdit
            // 
            tabPageEdit.BackColor = Color.White;
            tabPageEdit.Controls.Add(groupBoxEdit);
            tabPageEdit.Location = new Point(4, 29);
            tabPageEdit.Name = "tabPageEdit";
            tabPageEdit.Size = new Size(867, 567);
            tabPageEdit.TabIndex = 2;
            tabPageEdit.Text = "Редактировать";
            // 
            // groupBoxEdit
            // 
            groupBoxEdit.BackColor = Color.White;
            groupBoxEdit.Controls.Add(pictureBoxEditImage);
            groupBoxEdit.Controls.Add(label1);
            groupBoxEdit.Controls.Add(labelEditCategoryy);
            groupBoxEdit.Controls.Add(labelEditDatee);
            groupBoxEdit.Controls.Add(labelEditTitlee);
            groupBoxEdit.Controls.Add(lbEditEvents);
            groupBoxEdit.Controls.Add(txtEditTitle);
            groupBoxEdit.Controls.Add(dtpEditDate);
            groupBoxEdit.Controls.Add(cmbEditCategory);
            groupBoxEdit.Controls.Add(clbEditParticipants);
            groupBoxEdit.Controls.Add(btnEditImage);
            groupBoxEdit.Controls.Add(btnSaveChanges);
            groupBoxEdit.Location = new Point(10, 10);
            groupBoxEdit.Name = "groupBoxEdit";
            groupBoxEdit.Size = new Size(849, 557);
            groupBoxEdit.TabIndex = 0;
            groupBoxEdit.TabStop = false;
            groupBoxEdit.Text = "Редактирование события";
            // 
            // pictureBoxEditImage
            // 
            pictureBoxEditImage.Location = new Point(394, 98);
            pictureBoxEditImage.Name = "pictureBoxEditImage";
            pictureBoxEditImage.Size = new Size(433, 295);
            pictureBoxEditImage.TabIndex = 11;
            pictureBoxEditImage.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(7, 321);
            label1.Name = "label1";
            label1.Size = new Size(85, 18);
            label1.TabIndex = 10;
            label1.Text = "Участники:";
            // 
            // labelEditCategoryy
            // 
            labelEditCategoryy.AutoSize = true;
            labelEditCategoryy.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelEditCategoryy.Location = new Point(7, 288);
            labelEditCategoryy.Name = "labelEditCategoryy";
            labelEditCategoryy.Size = new Size(84, 18);
            labelEditCategoryy.TabIndex = 9;
            labelEditCategoryy.Text = "Категория:";
            // 
            // labelEditDatee
            // 
            labelEditDatee.AutoSize = true;
            labelEditDatee.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelEditDatee.Location = new Point(7, 254);
            labelEditDatee.Name = "labelEditDatee";
            labelEditDatee.Size = new Size(47, 18);
            labelEditDatee.TabIndex = 8;
            labelEditDatee.Text = "Дата:";
            // 
            // labelEditTitlee
            // 
            labelEditTitlee.AutoSize = true;
            labelEditTitlee.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelEditTitlee.Location = new Point(7, 216);
            labelEditTitlee.Name = "labelEditTitlee";
            labelEditTitlee.Size = new Size(83, 18);
            labelEditTitlee.TabIndex = 7;
            labelEditTitlee.Text = "Название: ";
            // 
            // lbEditEvents
            // 
            lbEditEvents.FormattingEnabled = true;
            lbEditEvents.Location = new Point(10, 21);
            lbEditEvents.Name = "lbEditEvents";
            lbEditEvents.Size = new Size(300, 164);
            lbEditEvents.TabIndex = 0;
            // 
            // txtEditTitle
            // 
            txtEditTitle.Location = new Point(102, 216);
            txtEditTitle.Name = "txtEditTitle";
            txtEditTitle.Size = new Size(208, 27);
            txtEditTitle.TabIndex = 1;
            // 
            // dtpEditDate
            // 
            dtpEditDate.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpEditDate.Format = DateTimePickerFormat.Custom;
            dtpEditDate.Location = new Point(102, 254);
            dtpEditDate.Name = "dtpEditDate";
            dtpEditDate.Size = new Size(208, 27);
            dtpEditDate.TabIndex = 2;
            // 
            // cmbEditCategory
            // 
            cmbEditCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEditCategory.FormattingEnabled = true;
            cmbEditCategory.Location = new Point(102, 287);
            cmbEditCategory.Name = "cmbEditCategory";
            cmbEditCategory.Size = new Size(208, 28);
            cmbEditCategory.TabIndex = 3;
            // 
            // clbEditParticipants
            // 
            clbEditParticipants.FormattingEnabled = true;
            clbEditParticipants.Location = new Point(102, 321);
            clbEditParticipants.Name = "clbEditParticipants";
            clbEditParticipants.Size = new Size(208, 70);
            clbEditParticipants.TabIndex = 4;
            // 
            // btnEditImage
            // 
            btnEditImage.Location = new Point(394, 21);
            btnEditImage.Name = "btnEditImage";
            btnEditImage.Size = new Size(433, 30);
            btnEditImage.TabIndex = 5;
            btnEditImage.Text = "Редактировать изображение";
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(10, 421);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(300, 30);
            btnSaveChanges.TabIndex = 6;
            btnSaveChanges.Text = "Сохранить изменения";
            // 
            // tabPageDelete
            // 
            tabPageDelete.BackColor = Color.White;
            tabPageDelete.Controls.Add(groupBoxDelete);
            tabPageDelete.Location = new Point(4, 29);
            tabPageDelete.Name = "tabPageDelete";
            tabPageDelete.Size = new Size(867, 567);
            tabPageDelete.TabIndex = 3;
            tabPageDelete.Text = "Удалить";
            // 
            // groupBoxDelete
            // 
            groupBoxDelete.BackColor = Color.White;
            groupBoxDelete.Controls.Add(lbDeleteEvents);
            groupBoxDelete.Controls.Add(btnDelete);
            groupBoxDelete.Location = new Point(10, 10);
            groupBoxDelete.Name = "groupBoxDelete";
            groupBoxDelete.Size = new Size(849, 549);
            groupBoxDelete.TabIndex = 0;
            groupBoxDelete.TabStop = false;
            groupBoxDelete.Text = "Удаление события";
            // 
            // lbDeleteEvents
            // 
            lbDeleteEvents.FormattingEnabled = true;
            lbDeleteEvents.Location = new Point(20, 30);
            lbDeleteEvents.Name = "lbDeleteEvents";
            lbDeleteEvents.Size = new Size(300, 164);
            lbDeleteEvents.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(340, 30);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(200, 30);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Удалить выбранное событие";
            // 
            // tabPageReport
            // 
            tabPageReport.Location = new Point(4, 29);
            tabPageReport.Name = "tabPageReport";
            tabPageReport.Size = new Size(867, 567);
            tabPageReport.TabIndex = 4;
            // 
            // Form1
            // 
            BackColor = Color.White;
            ClientSize = new Size(875, 600);
            Controls.Add(tabControlMain);
            Name = "Form1";
            Text = "Менеджер событий";
            tabControlMain.ResumeLayout(false);
            tabPageMain.ResumeLayout(false);
            groupBoxView.ResumeLayout(false);
            groupBoxView.PerformLayout();
            groupBoxDetails.ResumeLayout(false);
            groupBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEventImage).EndInit();
            tabPageAdd.ResumeLayout(false);
            groupBoxAdd.ResumeLayout(false);
            groupBoxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForAddPage).EndInit();
            tabPageEdit.ResumeLayout(false);
            groupBoxEdit.ResumeLayout(false);
            groupBoxEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEditImage).EndInit();
            tabPageDelete.ResumeLayout(false);
            groupBoxDelete.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.GroupBox groupBoxView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpMainFilterDate;
        private System.Windows.Forms.ComboBox cmbMainFilterCategory;
        private System.Windows.Forms.Button btnMainApplyFilter;
        private System.Windows.Forms.ListBox lbMainEvents;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.PictureBox picEventImage;
        private System.Windows.Forms.Label labelEventName;
        private System.Windows.Forms.Label labelEventDescription;
        private System.Windows.Forms.Label labelEventTime;
        private System.Windows.Forms.Label labelEventUsers;
        private System.Windows.Forms.Label labelEventCategory;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.DateTimePicker dtpAddDate;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.ComboBox cmbAddCategory;
        private System.Windows.Forms.CheckedListBox clbAddParticipants;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Label labelimageTitle;
        private System.Windows.Forms.PictureBox PicEventImageInAdd;
        private System.Windows.Forms.Label labelAddTitlee;
        private System.Windows.Forms.Label labelAddDatee;
        private System.Windows.Forms.Label labelAddDescriptionn;
        private System.Windows.Forms.Label labelAddCategoryy;
        private System.Windows.Forms.Label labelAddParticipantss;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.PictureBox pictureBoxEditImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEditCategoryy;
        private System.Windows.Forms.Label labelEditDatee;
        private System.Windows.Forms.Label labelEditTitlee;
        private System.Windows.Forms.ListBox lbEditEvents;
        private System.Windows.Forms.TextBox txtEditTitle;
        private System.Windows.Forms.DateTimePicker dtpEditDate;
        private System.Windows.Forms.ComboBox cmbEditCategory;
        private System.Windows.Forms.CheckedListBox clbEditParticipants;
        private System.Windows.Forms.Button btnEditImage;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.ListBox lbDeleteEvents;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabPage tabPageReport;
        private PictureBox pictureBoxForAddPage;
    }
}