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
            tabPageDelete = new TabPage();
            groupBoxDelete = new GroupBox();
            lbDeleteEvents = new ListBox();
            btnDelete = new Button();
            tabPageEdit = new TabPage();
            groupBoxEdit = new GroupBox();
            textBoxForEdit = new TextBox();
            label3 = new Label();
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
            tabPageAdd = new TabPage();
            groupBoxAdd = new GroupBox();
            pictureBoxForAdd = new PictureBox();
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
            tabPageMain = new TabPage();
            groupBoxView = new GroupBox();
            btn = new Button();
            button1 = new Button();
            label2 = new Label();
            dtpMainFilterDate = new DateTimePicker();
            cmbMainFilterCategory = new ComboBox();
            btnMainApplyFilter = new Button();
            lbMainEvents = new ListBox();
            splitContainer1 = new SplitContainer();
            groupBoxDetails = new GroupBox();
            picEventImage = new PictureBox();
            labelEventName = new Label();
            labelEventDescription = new Label();
            labelEventTime = new Label();
            labelEventUsers = new Label();
            labelEventCategory = new Label();
            tabControlMain = new TabControl();
            tabPageDelete.SuspendLayout();
            groupBoxDelete.SuspendLayout();
            tabPageEdit.SuspendLayout();
            groupBoxEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEditImage).BeginInit();
            tabPageAdd.SuspendLayout();
            groupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForAdd).BeginInit();
            tabPageMain.SuspendLayout();
            groupBoxView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEventImage).BeginInit();
            tabControlMain.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageDelete
            // 
            tabPageDelete.BackColor = Color.White;
            tabPageDelete.Controls.Add(groupBoxDelete);
            tabPageDelete.Location = new Point(4, 34);
            tabPageDelete.Name = "tabPageDelete";
            tabPageDelete.Size = new Size(867, 554);
            tabPageDelete.TabIndex = 3;
            tabPageDelete.Text = "Удалить";
            // 
            // groupBoxDelete
            // 
            groupBoxDelete.BackColor = Color.White;
            groupBoxDelete.Controls.Add(lbDeleteEvents);
            groupBoxDelete.Controls.Add(btnDelete);
            groupBoxDelete.Dock = DockStyle.Fill;
            groupBoxDelete.Location = new Point(0, 0);
            groupBoxDelete.Name = "groupBoxDelete";
            groupBoxDelete.Size = new Size(867, 554);
            groupBoxDelete.TabIndex = 0;
            groupBoxDelete.TabStop = false;
            groupBoxDelete.Text = "Удаление события";
            // 
            // lbDeleteEvents
            // 
            lbDeleteEvents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbDeleteEvents.FormattingEnabled = true;
            lbDeleteEvents.Location = new Point(20, 30);
            lbDeleteEvents.Name = "lbDeleteEvents";
            lbDeleteEvents.Size = new Size(300, 164);
            lbDeleteEvents.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(349, 33);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(200, 30);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Удалить выбранное событие";
            btnDelete.Click += btnDelete_Click;
            // 
            // tabPageEdit
            // 
            tabPageEdit.BackColor = Color.White;
            tabPageEdit.Controls.Add(groupBoxEdit);
            tabPageEdit.Location = new Point(4, 34);
            tabPageEdit.Name = "tabPageEdit";
            tabPageEdit.Size = new Size(867, 554);
            tabPageEdit.TabIndex = 2;
            tabPageEdit.Text = "Редактировать";
            // 
            // groupBoxEdit
            // 
            groupBoxEdit.BackColor = Color.White;
            groupBoxEdit.Controls.Add(textBoxForEdit);
            groupBoxEdit.Controls.Add(label3);
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
            groupBoxEdit.Dock = DockStyle.Fill;
            groupBoxEdit.Location = new Point(0, 0);
            groupBoxEdit.Name = "groupBoxEdit";
            groupBoxEdit.Size = new Size(867, 554);
            groupBoxEdit.TabIndex = 0;
            groupBoxEdit.TabStop = false;
            groupBoxEdit.Text = "Редактирование события";
            // 
            // textBoxForEdit
            // 
            textBoxForEdit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxForEdit.Location = new Point(111, 401);
            textBoxForEdit.Multiline = true;
            textBoxForEdit.Name = "textBoxForEdit";
            textBoxForEdit.Size = new Size(244, 54);
            textBoxForEdit.TabIndex = 13;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(19, 401);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 12;
            label3.Text = "Описание:";
            // 
            // pictureBoxEditImage
            // 
            pictureBoxEditImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxEditImage.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxEditImage.Location = new Point(380, 56);
            pictureBoxEditImage.Name = "pictureBoxEditImage";
            pictureBoxEditImage.Size = new Size(472, 334);
            pictureBoxEditImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEditImage.TabIndex = 11;
            pictureBoxEditImage.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F);
            label1.Location = new Point(19, 323);
            label1.Name = "label1";
            label1.Size = new Size(85, 18);
            label1.TabIndex = 10;
            label1.Text = "Участники:";
            // 
            // labelEditCategoryy
            // 
            labelEditCategoryy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelEditCategoryy.AutoSize = true;
            labelEditCategoryy.Font = new Font("Microsoft Sans Serif", 9F);
            labelEditCategoryy.Location = new Point(16, 287);
            labelEditCategoryy.Name = "labelEditCategoryy";
            labelEditCategoryy.Size = new Size(84, 18);
            labelEditCategoryy.TabIndex = 9;
            labelEditCategoryy.Text = "Категория:";
            // 
            // labelEditDatee
            // 
            labelEditDatee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelEditDatee.AutoSize = true;
            labelEditDatee.Font = new Font("Microsoft Sans Serif", 9F);
            labelEditDatee.Location = new Point(16, 253);
            labelEditDatee.Name = "labelEditDatee";
            labelEditDatee.Size = new Size(47, 18);
            labelEditDatee.TabIndex = 8;
            labelEditDatee.Text = "Дата:";
            // 
            // labelEditTitlee
            // 
            labelEditTitlee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelEditTitlee.AutoSize = true;
            labelEditTitlee.Font = new Font("Microsoft Sans Serif", 9F);
            labelEditTitlee.Location = new Point(16, 215);
            labelEditTitlee.Name = "labelEditTitlee";
            labelEditTitlee.Size = new Size(83, 18);
            labelEditTitlee.TabIndex = 7;
            labelEditTitlee.Text = "Название: ";
            // 
            // lbEditEvents
            // 
            lbEditEvents.FormattingEnabled = true;
            lbEditEvents.Location = new Point(19, 20);
            lbEditEvents.Name = "lbEditEvents";
            lbEditEvents.Size = new Size(336, 164);
            lbEditEvents.TabIndex = 0;
            // 
            // txtEditTitle
            // 
            txtEditTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtEditTitle.Location = new Point(111, 215);
            txtEditTitle.Name = "txtEditTitle";
            txtEditTitle.Size = new Size(244, 27);
            txtEditTitle.TabIndex = 1;
            // 
            // dtpEditDate
            // 
            dtpEditDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dtpEditDate.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpEditDate.Format = DateTimePickerFormat.Custom;
            dtpEditDate.Location = new Point(111, 253);
            dtpEditDate.Name = "dtpEditDate";
            dtpEditDate.Size = new Size(244, 27);
            dtpEditDate.TabIndex = 2;
            // 
            // cmbEditCategory
            // 
            cmbEditCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cmbEditCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEditCategory.FormattingEnabled = true;
            cmbEditCategory.Location = new Point(111, 286);
            cmbEditCategory.Name = "cmbEditCategory";
            cmbEditCategory.Size = new Size(244, 28);
            cmbEditCategory.TabIndex = 3;
            // 
            // clbEditParticipants
            // 
            clbEditParticipants.FormattingEnabled = true;
            clbEditParticipants.Location = new Point(111, 323);
            clbEditParticipants.Name = "clbEditParticipants";
            clbEditParticipants.Size = new Size(244, 70);
            clbEditParticipants.TabIndex = 4;
            // 
            // btnEditImage
            // 
            btnEditImage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEditImage.Location = new Point(403, 20);
            btnEditImage.Name = "btnEditImage";
            btnEditImage.Size = new Size(433, 30);
            btnEditImage.TabIndex = 5;
            btnEditImage.Text = "Редактировать изображение";
            btnEditImage.Click += btnEditImage_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSaveChanges.Location = new Point(19, 490);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(336, 30);
            btnSaveChanges.TabIndex = 6;
            btnSaveChanges.Text = "Сохранить изменения";
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // tabPageAdd
            // 
            tabPageAdd.BackColor = Color.White;
            tabPageAdd.Controls.Add(groupBoxAdd);
            tabPageAdd.Location = new Point(4, 34);
            tabPageAdd.Name = "tabPageAdd";
            tabPageAdd.Size = new Size(867, 554);
            tabPageAdd.TabIndex = 1;
            tabPageAdd.Text = "Добавить";
            // 
            // groupBoxAdd
            // 
            groupBoxAdd.BackColor = Color.White;
            groupBoxAdd.Controls.Add(pictureBoxForAdd);
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
            groupBoxAdd.Dock = DockStyle.Fill;
            groupBoxAdd.Location = new Point(0, 0);
            groupBoxAdd.Name = "groupBoxAdd";
            groupBoxAdd.Size = new Size(867, 554);
            groupBoxAdd.TabIndex = 0;
            groupBoxAdd.TabStop = false;
            groupBoxAdd.Text = "Добавление события";
            groupBoxAdd.Enter += groupBoxAdd_Enter;
            // 
            // pictureBoxForAdd
            // 
            pictureBoxForAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxForAdd.Location = new Point(348, 62);
            pictureBoxForAdd.Name = "pictureBoxForAdd";
            pictureBoxForAdd.Size = new Size(506, 484);
            pictureBoxForAdd.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxForAdd.TabIndex = 16;
            pictureBoxForAdd.TabStop = false;
            pictureBoxForAdd.Click += pictureBoxForAdd_Click;
            // 
            // txtAddTitle
            // 
            txtAddTitle.Location = new Point(95, 34);
            txtAddTitle.Name = "txtAddTitle";
            txtAddTitle.Size = new Size(247, 27);
            txtAddTitle.TabIndex = 0;
            // 
            // dtpAddDate
            // 
            dtpAddDate.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpAddDate.Format = DateTimePickerFormat.Custom;
            dtpAddDate.Location = new Point(95, 62);
            dtpAddDate.Name = "dtpAddDate";
            dtpAddDate.Size = new Size(247, 27);
            dtpAddDate.TabIndex = 1;
            // 
            // txtAddDescription
            // 
            txtAddDescription.Location = new Point(95, 96);
            txtAddDescription.Multiline = true;
            txtAddDescription.Name = "txtAddDescription";
            txtAddDescription.Size = new Size(247, 54);
            txtAddDescription.TabIndex = 2;
            // 
            // cmbAddCategory
            // 
            cmbAddCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAddCategory.FormattingEnabled = true;
            cmbAddCategory.Location = new Point(95, 162);
            cmbAddCategory.Name = "cmbAddCategory";
            cmbAddCategory.Size = new Size(247, 28);
            cmbAddCategory.TabIndex = 3;
            // 
            // clbAddParticipants
            // 
            clbAddParticipants.FormattingEnabled = true;
            clbAddParticipants.Location = new Point(95, 205);
            clbAddParticipants.Name = "clbAddParticipants";
            clbAddParticipants.Size = new Size(247, 92);
            clbAddParticipants.TabIndex = 4;
            // 
            // btnAddPicture
            // 
            btnAddPicture.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddPicture.Location = new Point(7, 323);
            btnAddPicture.Name = "btnAddPicture";
            btnAddPicture.Size = new Size(150, 63);
            btnAddPicture.TabIndex = 5;
            btnAddPicture.Text = "Добавить картинку";
            btnAddPicture.Click += btnAddPicture_Click;
            // 
            // btnAddEvent
            // 
            btnAddEvent.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddEvent.Location = new Point(187, 323);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(155, 63);
            btnAddEvent.TabIndex = 7;
            btnAddEvent.Text = "Добавить событие";
            btnAddEvent.Click += btnAddEvent_Click;
            // 
            // labelimageTitle
            // 
            labelimageTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            labelimageTitle.AutoSize = true;
            labelimageTitle.Font = new Font("Microsoft Sans Serif", 10.2F);
            labelimageTitle.Location = new Point(400, 19);
            labelimageTitle.Name = "labelimageTitle";
            labelimageTitle.Size = new Size(126, 20);
            labelimageTitle.TabIndex = 15;
            labelimageTitle.Text = "Изображение:";
            // 
            // labelAddTitlee
            // 
            labelAddTitlee.AutoSize = true;
            labelAddTitlee.Location = new Point(13, 34);
            labelAddTitlee.Name = "labelAddTitlee";
            labelAddTitlee.Size = new Size(80, 20);
            labelAddTitlee.TabIndex = 8;
            labelAddTitlee.Text = "Название:";
            // 
            // labelAddDatee
            // 
            labelAddDatee.AutoSize = true;
            labelAddDatee.Location = new Point(13, 67);
            labelAddDatee.Name = "labelAddDatee";
            labelAddDatee.Size = new Size(44, 20);
            labelAddDatee.TabIndex = 9;
            labelAddDatee.Text = "Дата:";
            // 
            // labelAddDescriptionn
            // 
            labelAddDescriptionn.AutoSize = true;
            labelAddDescriptionn.Location = new Point(13, 96);
            labelAddDescriptionn.Name = "labelAddDescriptionn";
            labelAddDescriptionn.Size = new Size(82, 20);
            labelAddDescriptionn.TabIndex = 10;
            labelAddDescriptionn.Text = "Описание:";
            // 
            // labelAddCategoryy
            // 
            labelAddCategoryy.AutoSize = true;
            labelAddCategoryy.Location = new Point(11, 162);
            labelAddCategoryy.Name = "labelAddCategoryy";
            labelAddCategoryy.Size = new Size(84, 20);
            labelAddCategoryy.TabIndex = 11;
            labelAddCategoryy.Text = "Категория:";
            // 
            // labelAddParticipantss
            // 
            labelAddParticipantss.AutoSize = true;
            labelAddParticipantss.Location = new Point(13, 205);
            labelAddParticipantss.Name = "labelAddParticipantss";
            labelAddParticipantss.Size = new Size(84, 20);
            labelAddParticipantss.TabIndex = 12;
            labelAddParticipantss.Text = "Участники:";
            // 
            // tabPageMain
            // 
            tabPageMain.BackColor = Color.White;
            tabPageMain.Controls.Add(groupBoxView);
            tabPageMain.Controls.Add(groupBoxDetails);
            tabPageMain.Location = new Point(4, 34);
            tabPageMain.Name = "tabPageMain";
            tabPageMain.Padding = new Padding(3);
            tabPageMain.Size = new Size(867, 554);
            tabPageMain.TabIndex = 0;
            tabPageMain.Text = "Главное меню";
            // 
            // groupBoxView
            // 
            groupBoxView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxView.BackColor = Color.White;
            groupBoxView.Controls.Add(btn);
            groupBoxView.Controls.Add(button1);
            groupBoxView.Controls.Add(label2);
            groupBoxView.Controls.Add(dtpMainFilterDate);
            groupBoxView.Controls.Add(cmbMainFilterCategory);
            groupBoxView.Controls.Add(btnMainApplyFilter);
            groupBoxView.Controls.Add(lbMainEvents);
            groupBoxView.Controls.Add(splitContainer1);
            groupBoxView.Location = new Point(10, 10);
            groupBoxView.Name = "groupBoxView";
            groupBoxView.Size = new Size(462, 536);
            groupBoxView.TabIndex = 0;
            groupBoxView.TabStop = false;
            groupBoxView.Text = "События и фильтрация";
            // 
            // btn
            // 
            btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn.Location = new Point(244, 56);
            btn.Name = "btn";
            btn.Size = new Size(200, 30);
            btn.TabIndex = 6;
            btn.Text = "Сброс фильтрации";
            btn.Click += btnResetFilter_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(21, 496);
            button1.Name = "button1";
            button1.Size = new Size(252, 30);
            button1.TabIndex = 5;
            button1.Text = "Сформировать Excel отчет";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.Location = new Point(18, 477);
            label2.Name = "label2";
            label2.Size = new Size(136, 18);
            label2.TabIndex = 4;
            label2.Text = "Генерация отчета:";
            // 
            // dtpMainFilterDate
            // 
            dtpMainFilterDate.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpMainFilterDate.Format = DateTimePickerFormat.Custom;
            dtpMainFilterDate.Location = new Point(16, 21);
            dtpMainFilterDate.Name = "dtpMainFilterDate";
            dtpMainFilterDate.Size = new Size(234, 27);
            dtpMainFilterDate.TabIndex = 0;
            // 
            // cmbMainFilterCategory
            // 
            cmbMainFilterCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMainFilterCategory.FormattingEnabled = true;
            cmbMainFilterCategory.Location = new Point(18, 58);
            cmbMainFilterCategory.Name = "cmbMainFilterCategory";
            cmbMainFilterCategory.Size = new Size(234, 28);
            cmbMainFilterCategory.TabIndex = 1;
            // 
            // btnMainApplyFilter
            // 
            btnMainApplyFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMainApplyFilter.Location = new Point(244, 20);
            btnMainApplyFilter.Name = "btnMainApplyFilter";
            btnMainApplyFilter.Size = new Size(200, 30);
            btnMainApplyFilter.TabIndex = 2;
            btnMainApplyFilter.Text = "Применить фильтр";
            btnMainApplyFilter.Click += btnMainApplyFilter_Click;
            // 
            // lbMainEvents
            // 
            lbMainEvents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbMainEvents.FormattingEnabled = true;
            lbMainEvents.Location = new Point(18, 98);
            lbMainEvents.Name = "lbMainEvents";
            lbMainEvents.Size = new Size(426, 324);
            lbMainEvents.TabIndex = 3;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(161, 214);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            splitContainer1.Size = new Size(150, 100);
            splitContainer1.SplitterDistance = 69;
            splitContainer1.TabIndex = 0;
            // 
            // groupBoxDetails
            // 
            groupBoxDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBoxDetails.BackColor = Color.White;
            groupBoxDetails.Controls.Add(picEventImage);
            groupBoxDetails.Controls.Add(labelEventName);
            groupBoxDetails.Controls.Add(labelEventDescription);
            groupBoxDetails.Controls.Add(labelEventTime);
            groupBoxDetails.Controls.Add(labelEventUsers);
            groupBoxDetails.Controls.Add(labelEventCategory);
            groupBoxDetails.Location = new Point(478, 10);
            groupBoxDetails.Name = "groupBoxDetails";
            groupBoxDetails.Size = new Size(349, 536);
            groupBoxDetails.TabIndex = 1;
            groupBoxDetails.TabStop = false;
            groupBoxDetails.Text = "Детали события";
            // 
            // picEventImage
            // 
            picEventImage.Anchor = AnchorStyles.Top;
            picEventImage.BorderStyle = BorderStyle.FixedSingle;
            picEventImage.Location = new Point(20, 28);
            picEventImage.Name = "picEventImage";
            picEventImage.Size = new Size(310, 160);
            picEventImage.SizeMode = PictureBoxSizeMode.Zoom;
            picEventImage.TabIndex = 0;
            picEventImage.TabStop = false;
            // 
            // labelEventName
            // 
            labelEventName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelEventName.Location = new Point(17, 212);
            labelEventName.MaximumSize = new Size(200, 1000);
            labelEventName.Name = "labelEventName";
            labelEventName.Size = new Size(143, 20);
            labelEventName.TabIndex = 1;
            labelEventName.Text = "Название события:";
            // 
            // labelEventDescription
            // 
            labelEventDescription.Anchor = AnchorStyles.Top;
            labelEventDescription.AutoSize = true;
            labelEventDescription.Location = new Point(17, 248);
            labelEventDescription.Name = "labelEventDescription";
            labelEventDescription.Size = new Size(82, 20);
            labelEventDescription.TabIndex = 2;
            labelEventDescription.Text = "Описание:";
            // 
            // labelEventTime
            // 
            labelEventTime.Anchor = AnchorStyles.Top;
            labelEventTime.AutoSize = true;
            labelEventTime.Location = new Point(17, 311);
            labelEventTime.Name = "labelEventTime";
            labelEventTime.Size = new Size(146, 20);
            labelEventTime.TabIndex = 3;
            labelEventTime.Text = "Время проведения:";
            // 
            // labelEventUsers
            // 
            labelEventUsers.Anchor = AnchorStyles.Top;
            labelEventUsers.AutoSize = true;
            labelEventUsers.Location = new Point(17, 349);
            labelEventUsers.Name = "labelEventUsers";
            labelEventUsers.Size = new Size(84, 20);
            labelEventUsers.TabIndex = 4;
            labelEventUsers.Text = "Участники:";
            // 
            // labelEventCategory
            // 
            labelEventCategory.Anchor = AnchorStyles.Top;
            labelEventCategory.AutoSize = true;
            labelEventCategory.Location = new Point(19, 444);
            labelEventCategory.Name = "labelEventCategory";
            labelEventCategory.Size = new Size(84, 20);
            labelEventCategory.TabIndex = 5;
            labelEventCategory.Text = "Категория:";
            // 
            // tabControlMain
            // 
            tabControlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlMain.Controls.Add(tabPageMain);
            tabControlMain.Controls.Add(tabPageAdd);
            tabControlMain.Controls.Add(tabPageEdit);
            tabControlMain.Controls.Add(tabPageDelete);
            tabControlMain.ItemSize = new Size(120, 30);
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.Padding = new Point(10, 5);
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(875, 592);
            tabControlMain.TabIndex = 0;
            tabControlMain.SelectedIndexChanged += tabControlMain_SelectedIndexChanged;
            // 
            // Form1
            // 
            BackColor = Color.White;
            ClientSize = new Size(875, 592);
            Controls.Add(tabControlMain);
            MinimumSize = new Size(893, 639);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Менеджер событий";
            tabPageDelete.ResumeLayout(false);
            groupBoxDelete.ResumeLayout(false);
            tabPageEdit.ResumeLayout(false);
            groupBoxEdit.ResumeLayout(false);
            groupBoxEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEditImage).EndInit();
            tabPageAdd.ResumeLayout(false);
            groupBoxAdd.ResumeLayout(false);
            groupBoxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForAdd).EndInit();
            tabPageMain.ResumeLayout(false);
            groupBoxView.ResumeLayout(false);
            groupBoxView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBoxDetails.ResumeLayout(false);
            groupBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEventImage).EndInit();
            tabControlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.PictureBox PicEventImageInAdd;
        private TabPage tabPageDelete;
        private GroupBox groupBoxDelete;
        private ListBox lbDeleteEvents;
        private Button btnDelete;
        private TabPage tabPageEdit;
        private GroupBox groupBoxEdit;
        private PictureBox pictureBoxEditImage;
        private Label label1;
        private Label labelEditCategoryy;
        private Label labelEditDatee;
        private Label labelEditTitlee;
        private ListBox lbEditEvents;
        private TextBox txtEditTitle;
        private DateTimePicker dtpEditDate;
        private ComboBox cmbEditCategory;
        private CheckedListBox clbEditParticipants;
        private Button btnEditImage;
        private Button btnSaveChanges;
        private TabPage tabPageAdd;
        private GroupBox groupBoxAdd;
        private PictureBox pictureBoxForAdd;
        private TextBox txtAddTitle;
        private DateTimePicker dtpAddDate;
        private TextBox txtAddDescription;
        private ComboBox cmbAddCategory;
        private CheckedListBox clbAddParticipants;
        private Button btnAddPicture;
        private Button btnAddEvent;
        private Label labelimageTitle;
        private Label labelAddTitlee;
        private Label labelAddDatee;
        private Label labelAddDescriptionn;
        private Label labelAddCategoryy;
        private Label labelAddParticipantss;
        private TabPage tabPageMain;
        private GroupBox groupBoxView;
        private Button button1;
        private Label label2;
        private DateTimePicker dtpMainFilterDate;
        private ComboBox cmbMainFilterCategory;
        private Button btnMainApplyFilter;
        private ListBox lbMainEvents;
        private GroupBox groupBoxDetails;
        private PictureBox picEventImage;
        private Label labelEventName;
        private Label labelEventDescription;
        private Label labelEventTime;
        private Label labelEventUsers;
        private Label labelEventCategory;
        private TabControl tabControlMain;
        private TextBox textBoxForEdit;
        private Label label3;
        private Button btnResetFilter;
        private Button btn;
        private SplitContainer splitContainer1;
    }
}