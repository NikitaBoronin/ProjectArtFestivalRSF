namespace ReleaseMaket
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
            this.labelMainFilterDate = new System.Windows.Forms.Label();
            this.labelMainFilterCategory = new System.Windows.Forms.Label();
            this.labelAddTitle = new System.Windows.Forms.Label();
            this.labelAddDate = new System.Windows.Forms.Label();
            this.labelAddDescription = new System.Windows.Forms.Label();
            this.labelAddCategory = new System.Windows.Forms.Label();
            this.labelAddParticipants = new System.Windows.Forms.Label();
            this.labelListElementType = new System.Windows.Forms.Label();
            this.labelEditTitle = new System.Windows.Forms.Label();
            this.labelEditDate = new System.Windows.Forms.Label();
            this.labelEditCategory = new System.Windows.Forms.Label();
            this.labelEditParticipants = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.groupBoxView = new System.Windows.Forms.GroupBox();
            this.dtpMainFilterDate = new System.Windows.Forms.DateTimePicker();
            this.cmbMainFilterCategory = new System.Windows.Forms.ComboBox();
            this.btnMainApplyFilter = new System.Windows.Forms.Button();
            this.lbMainEvents = new System.Windows.Forms.ListBox();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.picEventImage = new System.Windows.Forms.PictureBox();
            this.labelEventName = new System.Windows.Forms.Label();
            this.labelEventDescription = new System.Windows.Forms.Label();
            this.labelEventTime = new System.Windows.Forms.Label();
            this.labelEventUsers = new System.Windows.Forms.Label();
            this.labelEventCategory = new System.Windows.Forms.Label();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.labelListElementTypee = new System.Windows.Forms.Label();
            this.labelAddParticipantss = new System.Windows.Forms.Label();
            this.labelAddCategoryy = new System.Windows.Forms.Label();
            this.labelAddDescriptionn = new System.Windows.Forms.Label();
            this.labelAddDatee = new System.Windows.Forms.Label();
            this.labelAddTitlee = new System.Windows.Forms.Label();
            this.txtAddTitle = new System.Windows.Forms.TextBox();
            this.dtpAddDate = new System.Windows.Forms.DateTimePicker();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.cmbAddCategory = new System.Windows.Forms.ComboBox();
            this.clbAddParticipants = new System.Windows.Forms.CheckedListBox();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.cmbListElementType = new System.Windows.Forms.ComboBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.lbEditEvents = new System.Windows.Forms.ListBox();
            this.txtEditTitle = new System.Windows.Forms.TextBox();
            this.dtpEditDate = new System.Windows.Forms.DateTimePicker();
            this.cmbEditCategory = new System.Windows.Forms.ComboBox();
            this.clbEditParticipants = new System.Windows.Forms.CheckedListBox();
            this.btnEditSelected = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.groupBoxDelete = new System.Windows.Forms.GroupBox();
            this.lbDeleteEvents = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.groupBoxReport = new System.Windows.Forms.GroupBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.groupBoxView.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEventImage)).BeginInit();
            this.tabPageAdd.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            this.tabPageEdit.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.tabPageDelete.SuspendLayout();
            this.groupBoxDelete.SuspendLayout();
            this.tabPageReport.SuspendLayout();
            this.groupBoxReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMainFilterDate
            // 
            this.labelMainFilterDate.AutoSize = true;
            this.labelMainFilterDate.Location = new System.Drawing.Point(20, 30);
            this.labelMainFilterDate.Name = "labelMainFilterDate";
            this.labelMainFilterDate.Size = new System.Drawing.Size(44, 16);
            this.labelMainFilterDate.TabIndex = 8;
            this.labelMainFilterDate.Text = "Дата:";
            this.labelMainFilterDate.Visible = false;
            // 
            // labelMainFilterCategory
            // 
            this.labelMainFilterCategory.AutoSize = true;
            this.labelMainFilterCategory.Location = new System.Drawing.Point(20, 60);
            this.labelMainFilterCategory.Name = "labelMainFilterCategory";
            this.labelMainFilterCategory.Size = new System.Drawing.Size(78, 16);
            this.labelMainFilterCategory.TabIndex = 9;
            this.labelMainFilterCategory.Text = "Категория:";
            this.labelMainFilterCategory.Visible = false;
            // 
            // labelAddTitle
            // 
            this.labelAddTitle.AutoSize = true;
            this.labelAddTitle.Location = new System.Drawing.Point(10, 25);
            this.labelAddTitle.Name = "labelAddTitle";
            this.labelAddTitle.Size = new System.Drawing.Size(80, 16);
            this.labelAddTitle.TabIndex = 0;
            this.labelAddTitle.Text = "Название:";
            this.labelAddTitle.Visible = false;
            // 
            // labelAddDate
            // 
            this.labelAddDate.AutoSize = true;
            this.labelAddDate.Location = new System.Drawing.Point(10, 55);
            this.labelAddDate.Name = "labelAddDate";
            this.labelAddDate.Size = new System.Drawing.Size(44, 16);
            this.labelAddDate.TabIndex = 2;
            this.labelAddDate.Text = "Дата:";
            this.labelAddDate.Visible = false;
            // 
            // labelAddDescription
            // 
            this.labelAddDescription.AutoSize = true;
            this.labelAddDescription.Location = new System.Drawing.Point(10, 85);
            this.labelAddDescription.Name = "labelAddDescription";
            this.labelAddDescription.Size = new System.Drawing.Size(82, 16);
            this.labelAddDescription.TabIndex = 4;
            this.labelAddDescription.Text = "Описание:";
            this.labelAddDescription.Visible = false;
            // 
            // labelAddCategory
            // 
            this.labelAddCategory.AutoSize = true;
            this.labelAddCategory.Location = new System.Drawing.Point(10, 155);
            this.labelAddCategory.Name = "labelAddCategory";
            this.labelAddCategory.Size = new System.Drawing.Size(84, 16);
            this.labelAddCategory.TabIndex = 6;
            this.labelAddCategory.Text = "Категория:";
            this.labelAddCategory.Visible = false;
            // 
            // labelAddParticipants
            // 
            this.labelAddParticipants.AutoSize = true;
            this.labelAddParticipants.Location = new System.Drawing.Point(10, 185);
            this.labelAddParticipants.Name = "labelAddParticipants";
            this.labelAddParticipants.Size = new System.Drawing.Size(84, 16);
            this.labelAddParticipants.TabIndex = 8;
            this.labelAddParticipants.Text = "Участники:";
            this.labelAddParticipants.Visible = false;
            // 
            // labelListElementType
            // 
            this.labelListElementType.AutoSize = true;
            this.labelListElementType.Location = new System.Drawing.Point(10, 290);
            this.labelListElementType.Name = "labelListElementType";
            this.labelListElementType.Size = new System.Drawing.Size(150, 16);
            this.labelListElementType.TabIndex = 10;
            this.labelListElementType.Text = "Тип элемента списка:";
            this.labelListElementType.Visible = false;
            // 
            // labelEditTitle
            // 
            this.labelEditTitle.AutoSize = true;
            this.labelEditTitle.Location = new System.Drawing.Point(20, 30);
            this.labelEditTitle.Name = "labelEditTitle";
            this.labelEditTitle.Size = new System.Drawing.Size(80, 16);
            this.labelEditTitle.TabIndex = 0;
            this.labelEditTitle.Text = "Название:";
            this.labelEditTitle.Visible = false;
            // 
            // labelEditDate
            // 
            this.labelEditDate.AutoSize = true;
            this.labelEditDate.Location = new System.Drawing.Point(20, 60);
            this.labelEditDate.Name = "labelEditDate";
            this.labelEditDate.Size = new System.Drawing.Size(44, 16);
            this.labelEditDate.TabIndex = 2;
            this.labelEditDate.Text = "Дата:";
            this.labelEditDate.Visible = false;
            // 
            // labelEditCategory
            // 
            this.labelEditCategory.AutoSize = true;
            this.labelEditCategory.Location = new System.Drawing.Point(20, 90);
            this.labelEditCategory.Name = "labelEditCategory";
            this.labelEditCategory.Size = new System.Drawing.Size(84, 16);
            this.labelEditCategory.TabIndex = 6;
            this.labelEditCategory.Text = "Категория:";
            this.labelEditCategory.Visible = false;
            // 
            // labelEditParticipants
            // 
            this.labelEditParticipants.AutoSize = true;
            this.labelEditParticipants.Location = new System.Drawing.Point(20, 120);
            this.labelEditParticipants.Name = "labelEditParticipants";
            this.labelEditParticipants.Size = new System.Drawing.Size(84, 16);
            this.labelEditParticipants.TabIndex = 8;
            this.labelEditParticipants.Text = "Участники:";
            this.labelEditParticipants.Visible = false;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageMain);
            this.tabControlMain.Controls.Add(this.tabPageAdd);
            this.tabControlMain.Controls.Add(this.tabPageEdit);
            this.tabControlMain.Controls.Add(this.tabPageDelete);
            this.tabControlMain.Controls.Add(this.tabPageReport);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(875, 633);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackColor = System.Drawing.Color.White;
            this.tabPageMain.Controls.Add(this.groupBoxView);
            this.tabPageMain.Controls.Add(this.groupBoxDetails);
            this.tabPageMain.Location = new System.Drawing.Point(4, 25);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(867, 604);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Главное меню";
            // 
            // groupBoxView
            // 
            this.groupBoxView.BackColor = System.Drawing.Color.White;
            this.groupBoxView.Controls.Add(this.dtpMainFilterDate);
            this.groupBoxView.Controls.Add(this.cmbMainFilterCategory);
            this.groupBoxView.Controls.Add(this.btnMainApplyFilter);
            this.groupBoxView.Controls.Add(this.lbMainEvents);
            this.groupBoxView.Location = new System.Drawing.Point(10, 10);
            this.groupBoxView.Name = "groupBoxView";
            this.groupBoxView.Size = new System.Drawing.Size(480, 553);
            this.groupBoxView.TabIndex = 0;
            this.groupBoxView.TabStop = false;
            this.groupBoxView.Text = "События и фильтрация";
            // 
            // dtpMainFilterDate
            // 
            this.dtpMainFilterDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpMainFilterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMainFilterDate.Location = new System.Drawing.Point(20, 30);
            this.dtpMainFilterDate.Name = "dtpMainFilterDate";
            this.dtpMainFilterDate.Size = new System.Drawing.Size(200, 22);
            this.dtpMainFilterDate.TabIndex = 0;
            // 
            // cmbMainFilterCategory
            // 
            this.cmbMainFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMainFilterCategory.FormattingEnabled = true;
            this.cmbMainFilterCategory.Location = new System.Drawing.Point(20, 60);
            this.cmbMainFilterCategory.Name = "cmbMainFilterCategory";
            this.cmbMainFilterCategory.Size = new System.Drawing.Size(200, 24);
            this.cmbMainFilterCategory.TabIndex = 1;
            // 
            // btnMainApplyFilter
            // 
            this.btnMainApplyFilter.Location = new System.Drawing.Point(240, 30);
            this.btnMainApplyFilter.Name = "btnMainApplyFilter";
            this.btnMainApplyFilter.Size = new System.Drawing.Size(200, 30);
            this.btnMainApplyFilter.TabIndex = 2;
            this.btnMainApplyFilter.Text = "Применить фильтр";
            // 
            // lbMainEvents
            // 
            this.lbMainEvents.FormattingEnabled = true;
            this.lbMainEvents.ItemHeight = 16;
            this.lbMainEvents.Location = new System.Drawing.Point(20, 100);
            this.lbMainEvents.Name = "lbMainEvents";
            this.lbMainEvents.Size = new System.Drawing.Size(420, 420);
            this.lbMainEvents.TabIndex = 3;
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.BackColor = System.Drawing.Color.White;
            this.groupBoxDetails.Controls.Add(this.picEventImage);
            this.groupBoxDetails.Controls.Add(this.labelEventName);
            this.groupBoxDetails.Controls.Add(this.labelEventDescription);
            this.groupBoxDetails.Controls.Add(this.labelEventTime);
            this.groupBoxDetails.Controls.Add(this.labelEventUsers);
            this.groupBoxDetails.Controls.Add(this.labelEventCategory);
            this.groupBoxDetails.Location = new System.Drawing.Point(500, 10);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(480, 553);
            this.groupBoxDetails.TabIndex = 1;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Детали события";
            // 
            // picEventImage
            // 
            this.picEventImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEventImage.Location = new System.Drawing.Point(20, 30);
            this.picEventImage.Name = "picEventImage";
            this.picEventImage.Size = new System.Drawing.Size(150, 160);
            this.picEventImage.TabIndex = 0;
            this.picEventImage.TabStop = false;
            // 
            // labelEventName
            // 
            this.labelEventName.AutoSize = true;
            this.labelEventName.Location = new System.Drawing.Point(190, 30);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(133, 16);
            this.labelEventName.TabIndex = 1;
            this.labelEventName.Text = "Название события:";
            // 
            // labelEventDescription
            // 
            this.labelEventDescription.AutoSize = true;
            this.labelEventDescription.Location = new System.Drawing.Point(190, 60);
            this.labelEventDescription.Name = "labelEventDescription";
            this.labelEventDescription.Size = new System.Drawing.Size(75, 16);
            this.labelEventDescription.TabIndex = 2;
            this.labelEventDescription.Text = "Описание:";
            // 
            // labelEventTime
            // 
            this.labelEventTime.AutoSize = true;
            this.labelEventTime.Location = new System.Drawing.Point(190, 110);
            this.labelEventTime.Name = "labelEventTime";
            this.labelEventTime.Size = new System.Drawing.Size(87, 16);
            this.labelEventTime.TabIndex = 3;
            this.labelEventTime.Text = "Дата/Время:";
            // 
            // labelEventUsers
            // 
            this.labelEventUsers.AutoSize = true;
            this.labelEventUsers.Location = new System.Drawing.Point(190, 140);
            this.labelEventUsers.Name = "labelEventUsers";
            this.labelEventUsers.Size = new System.Drawing.Size(80, 16);
            this.labelEventUsers.TabIndex = 4;
            this.labelEventUsers.Text = "Участники:";
            // 
            // labelEventCategory
            // 
            this.labelEventCategory.AutoSize = true;
            this.labelEventCategory.Location = new System.Drawing.Point(190, 170);
            this.labelEventCategory.Name = "labelEventCategory";
            this.labelEventCategory.Size = new System.Drawing.Size(78, 16);
            this.labelEventCategory.TabIndex = 5;
            this.labelEventCategory.Text = "Категория:";
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.BackColor = System.Drawing.Color.White;
            this.tabPageAdd.Controls.Add(this.groupBoxAdd);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 25);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Size = new System.Drawing.Size(867, 604);
            this.tabPageAdd.TabIndex = 1;
            this.tabPageAdd.Text = "Добавить";
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.BackColor = System.Drawing.Color.White;
            this.groupBoxAdd.Controls.Add(this.labelListElementTypee);
            this.groupBoxAdd.Controls.Add(this.labelAddParticipantss);
            this.groupBoxAdd.Controls.Add(this.labelAddCategoryy);
            this.groupBoxAdd.Controls.Add(this.labelAddDescriptionn);
            this.groupBoxAdd.Controls.Add(this.labelAddDatee);
            this.groupBoxAdd.Controls.Add(this.labelAddTitlee);
            this.groupBoxAdd.Controls.Add(this.txtAddTitle);
            this.groupBoxAdd.Controls.Add(this.dtpAddDate);
            this.groupBoxAdd.Controls.Add(this.txtAddDescription);
            this.groupBoxAdd.Controls.Add(this.cmbAddCategory);
            this.groupBoxAdd.Controls.Add(this.clbAddParticipants);
            this.groupBoxAdd.Controls.Add(this.btnAddPicture);
            this.groupBoxAdd.Controls.Add(this.cmbListElementType);
            this.groupBoxAdd.Controls.Add(this.btnAddEvent);
            this.groupBoxAdd.Location = new System.Drawing.Point(10, 10);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(970, 540);
            this.groupBoxAdd.TabIndex = 0;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Добавление события";
            // 
            // labelListElementTypee
            // 
            this.labelListElementTypee.AutoSize = true;
            this.labelListElementTypee.Location = new System.Drawing.Point(6, 274);
            this.labelListElementTypee.Name = "labelListElementTypee";
            this.labelListElementTypee.Size = new System.Drawing.Size(128, 16);
            this.labelListElementTypee.TabIndex = 13;
            this.labelListElementTypee.Text = "Элемент в группе:";
            // 
            // labelAddParticipantss
            // 
            this.labelAddParticipantss.AutoSize = true;
            this.labelAddParticipantss.Location = new System.Drawing.Point(6, 204);
            this.labelAddParticipantss.Name = "labelAddParticipantss";
            this.labelAddParticipantss.Size = new System.Drawing.Size(80, 16);
            this.labelAddParticipantss.TabIndex = 12;
            this.labelAddParticipantss.Text = "Участники:";
            // 
            // labelAddCategoryy
            // 
            this.labelAddCategoryy.AutoSize = true;
            this.labelAddCategoryy.Location = new System.Drawing.Point(4, 161);
            this.labelAddCategoryy.Name = "labelAddCategoryy";
            this.labelAddCategoryy.Size = new System.Drawing.Size(78, 16);
            this.labelAddCategoryy.TabIndex = 11;
            this.labelAddCategoryy.Text = "Категория:";
            // 
            // labelAddDescriptionn
            // 
            this.labelAddDescriptionn.AutoSize = true;
            this.labelAddDescriptionn.Location = new System.Drawing.Point(6, 95);
            this.labelAddDescriptionn.Name = "labelAddDescriptionn";
            this.labelAddDescriptionn.Size = new System.Drawing.Size(78, 16);
            this.labelAddDescriptionn.TabIndex = 10;
            this.labelAddDescriptionn.Text = "Описание: ";
            // 
            // labelAddDatee
            // 
            this.labelAddDatee.AutoSize = true;
            this.labelAddDatee.Location = new System.Drawing.Point(6, 66);
            this.labelAddDatee.Name = "labelAddDatee";
            this.labelAddDatee.Size = new System.Drawing.Size(42, 16);
            this.labelAddDatee.TabIndex = 9;
            this.labelAddDatee.Text = "Дата:";
            // 
            // labelAddTitlee
            // 
            this.labelAddTitlee.AutoSize = true;
            this.labelAddTitlee.Location = new System.Drawing.Point(6, 33);
            this.labelAddTitlee.Name = "labelAddTitlee";
            this.labelAddTitlee.Size = new System.Drawing.Size(76, 16);
            this.labelAddTitlee.TabIndex = 8;
            this.labelAddTitlee.Text = "Название:";
            // 
            // txtAddTitle
            // 
            this.txtAddTitle.Location = new System.Drawing.Point(88, 33);
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.Size = new System.Drawing.Size(211, 22);
            this.txtAddTitle.TabIndex = 0;
            // 
            // dtpAddDate
            // 
            this.dtpAddDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpAddDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAddDate.Location = new System.Drawing.Point(88, 61);
            this.dtpAddDate.Name = "dtpAddDate";
            this.dtpAddDate.Size = new System.Drawing.Size(211, 22);
            this.dtpAddDate.TabIndex = 1;
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(88, 95);
            this.txtAddDescription.Multiline = true;
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(208, 54);
            this.txtAddDescription.TabIndex = 2;
            // 
            // cmbAddCategory
            // 
            this.cmbAddCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddCategory.FormattingEnabled = true;
            this.cmbAddCategory.Location = new System.Drawing.Point(88, 161);
            this.cmbAddCategory.Name = "cmbAddCategory";
            this.cmbAddCategory.Size = new System.Drawing.Size(208, 24);
            this.cmbAddCategory.TabIndex = 3;
            // 
            // clbAddParticipants
            // 
            this.clbAddParticipants.FormattingEnabled = true;
            this.clbAddParticipants.Location = new System.Drawing.Point(88, 204);
            this.clbAddParticipants.Name = "clbAddParticipants";
            this.clbAddParticipants.Size = new System.Drawing.Size(208, 38);
            this.clbAddParticipants.TabIndex = 4;
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(0, 318);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(150, 63);
            this.btnAddPicture.TabIndex = 5;
            this.btnAddPicture.Text = "Добавить картинку";
            // 
            // cmbListElementType
            // 
            this.cmbListElementType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListElementType.FormattingEnabled = true;
            this.cmbListElementType.Location = new System.Drawing.Point(146, 271);
            this.cmbListElementType.Name = "cmbListElementType";
            this.cmbListElementType.Size = new System.Drawing.Size(150, 24);
            this.cmbListElementType.TabIndex = 6;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(176, 318);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(120, 63);
            this.btnAddEvent.TabIndex = 7;
            this.btnAddEvent.Text = "Добавить событие";
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.BackColor = System.Drawing.Color.White;
            this.tabPageEdit.Controls.Add(this.groupBoxEdit);
            this.tabPageEdit.Location = new System.Drawing.Point(4, 25);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Size = new System.Drawing.Size(867, 604);
            this.tabPageEdit.TabIndex = 2;
            this.tabPageEdit.Text = "Редактировать";
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.BackColor = System.Drawing.Color.White;
            this.groupBoxEdit.Controls.Add(this.lbEditEvents);
            this.groupBoxEdit.Controls.Add(this.txtEditTitle);
            this.groupBoxEdit.Controls.Add(this.dtpEditDate);
            this.groupBoxEdit.Controls.Add(this.cmbEditCategory);
            this.groupBoxEdit.Controls.Add(this.clbEditParticipants);
            this.groupBoxEdit.Controls.Add(this.btnEditSelected);
            this.groupBoxEdit.Controls.Add(this.btnSaveChanges);
            this.groupBoxEdit.Location = new System.Drawing.Point(10, 10);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(970, 540);
            this.groupBoxEdit.TabIndex = 0;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Редактирование события";
            // 
            // lbEditEvents
            // 
            this.lbEditEvents.FormattingEnabled = true;
            this.lbEditEvents.ItemHeight = 16;
            this.lbEditEvents.Location = new System.Drawing.Point(20, 30);
            this.lbEditEvents.Name = "lbEditEvents";
            this.lbEditEvents.Size = new System.Drawing.Size(300, 180);
            this.lbEditEvents.TabIndex = 0;
            // 
            // txtEditTitle
            // 
            this.txtEditTitle.Location = new System.Drawing.Point(340, 30);
            this.txtEditTitle.Name = "txtEditTitle";
            this.txtEditTitle.Size = new System.Drawing.Size(300, 22);
            this.txtEditTitle.TabIndex = 1;
            // 
            // dtpEditDate
            // 
            this.dtpEditDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpEditDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEditDate.Location = new System.Drawing.Point(340, 60);
            this.dtpEditDate.Name = "dtpEditDate";
            this.dtpEditDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEditDate.TabIndex = 2;
            // 
            // cmbEditCategory
            // 
            this.cmbEditCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditCategory.FormattingEnabled = true;
            this.cmbEditCategory.Location = new System.Drawing.Point(340, 90);
            this.cmbEditCategory.Name = "cmbEditCategory";
            this.cmbEditCategory.Size = new System.Drawing.Size(200, 24);
            this.cmbEditCategory.TabIndex = 3;
            // 
            // clbEditParticipants
            // 
            this.clbEditParticipants.FormattingEnabled = true;
            this.clbEditParticipants.Location = new System.Drawing.Point(340, 120);
            this.clbEditParticipants.Name = "clbEditParticipants";
            this.clbEditParticipants.Size = new System.Drawing.Size(200, 72);
            this.clbEditParticipants.TabIndex = 4;
            // 
            // btnEditSelected
            // 
            this.btnEditSelected.Location = new System.Drawing.Point(340, 240);
            this.btnEditSelected.Name = "btnEditSelected";
            this.btnEditSelected.Size = new System.Drawing.Size(200, 30);
            this.btnEditSelected.TabIndex = 5;
            this.btnEditSelected.Text = "Редактировать выбранное событие";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(560, 240);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(200, 30);
            this.btnSaveChanges.TabIndex = 6;
            this.btnSaveChanges.Text = "Сохранить изменения";
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.BackColor = System.Drawing.Color.White;
            this.tabPageDelete.Controls.Add(this.groupBoxDelete);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 25);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Size = new System.Drawing.Size(867, 604);
            this.tabPageDelete.TabIndex = 3;
            this.tabPageDelete.Text = "Удалить";
            // 
            // groupBoxDelete
            // 
            this.groupBoxDelete.BackColor = System.Drawing.Color.White;
            this.groupBoxDelete.Controls.Add(this.lbDeleteEvents);
            this.groupBoxDelete.Controls.Add(this.btnDelete);
            this.groupBoxDelete.Location = new System.Drawing.Point(10, 10);
            this.groupBoxDelete.Name = "groupBoxDelete";
            this.groupBoxDelete.Size = new System.Drawing.Size(970, 540);
            this.groupBoxDelete.TabIndex = 0;
            this.groupBoxDelete.TabStop = false;
            this.groupBoxDelete.Text = "Удаление события";
            // 
            // lbDeleteEvents
            // 
            this.lbDeleteEvents.FormattingEnabled = true;
            this.lbDeleteEvents.ItemHeight = 16;
            this.lbDeleteEvents.Location = new System.Drawing.Point(20, 30);
            this.lbDeleteEvents.Name = "lbDeleteEvents";
            this.lbDeleteEvents.Size = new System.Drawing.Size(300, 180);
            this.lbDeleteEvents.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(340, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Удалить выбранное событие";
            // 
            // tabPageReport
            // 
            this.tabPageReport.BackColor = System.Drawing.Color.White;
            this.tabPageReport.Controls.Add(this.groupBoxReport);
            this.tabPageReport.Location = new System.Drawing.Point(4, 25);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Size = new System.Drawing.Size(574, 393);
            this.tabPageReport.TabIndex = 4;
            this.tabPageReport.Text = "Отчет";
            // 
            // groupBoxReport
            // 
            this.groupBoxReport.BackColor = System.Drawing.Color.White;
            this.groupBoxReport.Controls.Add(this.btnGenerateReport);
            this.groupBoxReport.Location = new System.Drawing.Point(10, 10);
            this.groupBoxReport.Name = "groupBoxReport";
            this.groupBoxReport.Size = new System.Drawing.Size(970, 540);
            this.groupBoxReport.TabIndex = 0;
            this.groupBoxReport.TabStop = false;
            this.groupBoxReport.Text = "Генерация отчёта";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(0, 508);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(327, 39);
            this.btnGenerateReport.TabIndex = 6;
            this.btnGenerateReport.Text = "Сформировать Excel отчёт";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 633);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "Менеджер событий";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.groupBoxView.ResumeLayout(false);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEventImage)).EndInit();
            this.tabPageAdd.ResumeLayout(false);
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.tabPageEdit.ResumeLayout(false);
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.tabPageDelete.ResumeLayout(false);
            this.groupBoxDelete.ResumeLayout(false);
            this.tabPageReport.ResumeLayout(false);
            this.groupBoxReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // Объявления ВСЕХ компонентов из старого кода
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.GroupBox groupBoxView;
        private System.Windows.Forms.Label labelMainFilterDate;
        private System.Windows.Forms.DateTimePicker dtpMainFilterDate;
        private System.Windows.Forms.Label labelMainFilterCategory;
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
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Label labelAddTitle;
        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.Label labelAddDate;
        private System.Windows.Forms.DateTimePicker dtpAddDate;
        private System.Windows.Forms.Label labelAddDescription;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.Label labelAddCategory;
        private System.Windows.Forms.ComboBox cmbAddCategory;
        private System.Windows.Forms.Label labelAddParticipants;
        private System.Windows.Forms.CheckedListBox clbAddParticipants;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.Label labelListElementType;
        private System.Windows.Forms.ComboBox cmbListElementType;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.ListBox lbEditEvents;
        private System.Windows.Forms.Label labelEditTitle;
        private System.Windows.Forms.TextBox txtEditTitle;
        private System.Windows.Forms.Label labelEditDate;
        private System.Windows.Forms.DateTimePicker dtpEditDate;
        private System.Windows.Forms.Label labelEditCategory;
        private System.Windows.Forms.ComboBox cmbEditCategory;
        private System.Windows.Forms.Label labelEditParticipants;
        private System.Windows.Forms.CheckedListBox clbEditParticipants;
        private System.Windows.Forms.Button btnEditSelected;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.ListBox lbDeleteEvents;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabPage tabPageReport;
        private System.Windows.Forms.GroupBox groupBoxReport;
        private System.Windows.Forms.Label labelAddDatee;
        private System.Windows.Forms.Label labelAddTitlee;
        private System.Windows.Forms.Label labelAddParticipantss;
        private System.Windows.Forms.Label labelAddCategoryy;
        private System.Windows.Forms.Label labelAddDescriptionn;
        private System.Windows.Forms.Label labelListElementTypee;
    }
}