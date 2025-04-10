<<<<<<< HEAD
﻿namespace ArtFestival
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlMain = new TabControl();
            tabPageMain = new TabPage();
            groupBoxDetails = new GroupBox();
            picEventImage = new PictureBox();
            labelEventName = new Label();
            labelEventDescription = new Label();
            labelEventTime = new Label();
            labelEventParticipants = new Label();
            labelEventCategory = new Label();
            groupBoxView = new GroupBox();
            btnMainApplyFilter = new Button();
            cmbMainFilterCategory = new ComboBox();
            dtpMainFilterDate = new DateTimePicker();
            labelMainFilterCategory = new Label();
            labelMainFilterDate = new Label();
            lbMainEvents = new ListBox();
            tabPageEdit = new TabPage();
            groupBoxAdd = new GroupBox();
            labelAddTitle = new Label();
            txtAddTitle = new TextBox();
            labelAddDate = new Label();
            dtpAddDate = new DateTimePicker();
            labelAddDescription = new Label();
            txtAddDescription = new TextBox();
            labelAddCategory = new Label();
            cmbAddCategory = new ComboBox();
            labelAddParticipants = new Label();
            clbAddParticipants = new CheckedListBox();
            btnAddEvent = new Button();
            groupBoxEdit = new GroupBox();
            lbEditEvents = new ListBox();
            labelEditTitle = new Label();
            txtEditTitle = new TextBox();
            labelEditDate = new Label();
            dtpEditDate = new DateTimePicker();
            labelEditCategory = new Label();
            cmbEditCategory = new ComboBox();
            labelEditParticipants = new Label();
            clbEditParticipants = new CheckedListBox();
            btnEditSelected = new Button();
            btnSaveChanges = new Button();
            groupBoxDelete = new GroupBox();
            lbDeleteEvents = new ListBox();
            btnDelete = new Button();
            tabControlMain.SuspendLayout();
            tabPageMain.SuspendLayout();
            groupBoxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEventImage).BeginInit();
            groupBoxView.SuspendLayout();
            tabPageEdit.SuspendLayout();
            groupBoxAdd.SuspendLayout();
            groupBoxEdit.SuspendLayout();
            groupBoxDelete.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageMain);
            tabControlMain.Controls.Add(tabPageEdit);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(800, 600);
            tabControlMain.TabIndex = 0;
            // 
            // tabPageMain
            // 
            tabPageMain.Controls.Add(groupBoxDetails);
            tabPageMain.Controls.Add(groupBoxView);
            tabPageMain.Location = new Point(4, 29);
            tabPageMain.Name = "tabPageMain";
            tabPageMain.Padding = new Padding(3);
            tabPageMain.Size = new Size(792, 567);
            tabPageMain.TabIndex = 0;
            tabPageMain.Text = "Главное меню";
            tabPageMain.UseVisualStyleBackColor = true;
            // 
            // groupBoxDetails
            // 
            groupBoxDetails.Controls.Add(picEventImage);
            groupBoxDetails.Controls.Add(labelEventName);
            groupBoxDetails.Controls.Add(labelEventDescription);
            groupBoxDetails.Controls.Add(labelEventTime);
            groupBoxDetails.Controls.Add(labelEventParticipants);
            groupBoxDetails.Controls.Add(labelEventCategory);
            groupBoxDetails.Location = new Point(392, 6);
            groupBoxDetails.Name = "groupBoxDetails";
            groupBoxDetails.Size = new Size(390, 562);
            groupBoxDetails.TabIndex = 1;
            groupBoxDetails.TabStop = false;
            groupBoxDetails.Text = "Детали события";
            // 
            // picEventImage
            // 
            picEventImage.BorderStyle = BorderStyle.FixedSingle;
            picEventImage.Location = new Point(10, 25);
            picEventImage.Name = "picEventImage";
            picEventImage.Size = new Size(146, 150);
            picEventImage.TabIndex = 0;
            picEventImage.TabStop = false;
            // 
            // labelEventName
            // 
            labelEventName.AutoSize = true;
            labelEventName.Location = new Point(10, 190);
            labelEventName.Name = "labelEventName";
            labelEventName.Size = new Size(143, 20);
            labelEventName.TabIndex = 1;
            labelEventName.Text = "Название события:";
            // 
            // labelEventDescription
            // 
            labelEventDescription.AutoSize = true;
            labelEventDescription.Location = new Point(10, 220);
            labelEventDescription.Name = "labelEventDescription";
            labelEventDescription.Size = new Size(82, 20);
            labelEventDescription.TabIndex = 2;
            labelEventDescription.Text = "Описание:";
            // 
            // labelEventTime
            // 
            labelEventTime.AutoSize = true;
            labelEventTime.Location = new Point(10, 250);
            labelEventTime.Name = "labelEventTime";
            labelEventTime.Size = new Size(146, 20);
            labelEventTime.TabIndex = 3;
            labelEventTime.Text = "Время проведения:";
            // 
            // labelEventParticipants
            // 
            labelEventParticipants.AutoSize = true;
            labelEventParticipants.Location = new Point(10, 280);
            labelEventParticipants.Name = "labelEventParticipants";
            labelEventParticipants.Size = new Size(84, 20);
            labelEventParticipants.TabIndex = 4;
            labelEventParticipants.Text = "Участники:";
            // 
            // labelEventCategory
            // 
            labelEventCategory.AutoSize = true;
            labelEventCategory.Location = new Point(10, 310);
            labelEventCategory.Name = "labelEventCategory";
            labelEventCategory.Size = new Size(84, 20);
            labelEventCategory.TabIndex = 5;
            labelEventCategory.Text = "Категория:";
            // 
            // groupBoxView
            // 
            groupBoxView.Controls.Add(btnMainApplyFilter);
            groupBoxView.Controls.Add(cmbMainFilterCategory);
            groupBoxView.Controls.Add(dtpMainFilterDate);
            groupBoxView.Controls.Add(labelMainFilterCategory);
            groupBoxView.Controls.Add(labelMainFilterDate);
            groupBoxView.Controls.Add(lbMainEvents);
            groupBoxView.Location = new Point(6, 6);
            groupBoxView.Name = "groupBoxView";
            groupBoxView.Size = new Size(380, 562);
            groupBoxView.TabIndex = 0;
            groupBoxView.TabStop = false;
            groupBoxView.Text = "События и фильтрация";
            // 
            // btnMainApplyFilter
            // 
            btnMainApplyFilter.Location = new Point(254, 17);
            btnMainApplyFilter.Name = "btnMainApplyFilter";
            btnMainApplyFilter.Size = new Size(120, 30);
            btnMainApplyFilter.TabIndex = 4;
            btnMainApplyFilter.Text = "Применить фильтр";
            btnMainApplyFilter.UseVisualStyleBackColor = true;
            // 
            // cmbMainFilterCategory
            // 
            cmbMainFilterCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMainFilterCategory.FormattingEnabled = true;
            cmbMainFilterCategory.Location = new Point(100, 50);
            cmbMainFilterCategory.Name = "cmbMainFilterCategory";
            cmbMainFilterCategory.Size = new Size(150, 28);
            cmbMainFilterCategory.TabIndex = 3;
            // 
            // dtpMainFilterDate
            // 
            dtpMainFilterDate.CustomFormat = "dd.MM.yyyy";
            dtpMainFilterDate.Format = DateTimePickerFormat.Custom;
            dtpMainFilterDate.Location = new Point(70, 20);
            dtpMainFilterDate.Name = "dtpMainFilterDate";
            dtpMainFilterDate.Size = new Size(120, 27);
            dtpMainFilterDate.TabIndex = 1;
            // 
            // labelMainFilterCategory
            // 
            labelMainFilterCategory.AutoSize = true;
            labelMainFilterCategory.Location = new Point(10, 53);
            labelMainFilterCategory.Name = "labelMainFilterCategory";
            labelMainFilterCategory.Size = new Size(84, 20);
            labelMainFilterCategory.TabIndex = 2;
            labelMainFilterCategory.Text = "Категория:";
            labelMainFilterCategory.Click += labelMainFilterCategory_Click;
            // 
            // labelMainFilterDate
            // 
            labelMainFilterDate.AutoSize = true;
            labelMainFilterDate.Location = new Point(10, 25);
            labelMainFilterDate.Name = "labelMainFilterDate";
            labelMainFilterDate.Size = new Size(44, 20);
            labelMainFilterDate.TabIndex = 0;
            labelMainFilterDate.Text = "Дата:";
            // 
            // lbMainEvents
            // 
            lbMainEvents.FormattingEnabled = true;
            lbMainEvents.Location = new Point(10, 80);
            lbMainEvents.Name = "lbMainEvents";
            lbMainEvents.Size = new Size(350, 464);
            lbMainEvents.TabIndex = 5;
            lbMainEvents.SelectedIndexChanged += lbMainEvents_SelectedIndexChanged;
            // 
            // tabPageEdit
            // 
            tabPageEdit.Controls.Add(groupBoxAdd);
            tabPageEdit.Controls.Add(groupBoxEdit);
            tabPageEdit.Controls.Add(groupBoxDelete);
            tabPageEdit.Location = new Point(4, 29);
            tabPageEdit.Name = "tabPageEdit";
            tabPageEdit.Padding = new Padding(3);
            tabPageEdit.Size = new Size(792, 567);
            tabPageEdit.TabIndex = 1;
            tabPageEdit.Text = "Редактирование";
            tabPageEdit.UseVisualStyleBackColor = true;
            // 
            // groupBoxAdd
            // 
            groupBoxAdd.Controls.Add(labelAddTitle);
            groupBoxAdd.Controls.Add(txtAddTitle);
            groupBoxAdd.Controls.Add(labelAddDate);
            groupBoxAdd.Controls.Add(dtpAddDate);
            groupBoxAdd.Controls.Add(labelAddDescription);
            groupBoxAdd.Controls.Add(txtAddDescription);
            groupBoxAdd.Controls.Add(labelAddCategory);
            groupBoxAdd.Controls.Add(cmbAddCategory);
            groupBoxAdd.Controls.Add(labelAddParticipants);
            groupBoxAdd.Controls.Add(clbAddParticipants);
            groupBoxAdd.Controls.Add(btnAddEvent);
            groupBoxAdd.Location = new Point(6, 6);
            groupBoxAdd.Name = "groupBoxAdd";
            groupBoxAdd.Size = new Size(300, 350);
            groupBoxAdd.TabIndex = 0;
            groupBoxAdd.TabStop = false;
            groupBoxAdd.Text = "Добавление события";
            // 
            // labelAddTitle
            // 
            labelAddTitle.AutoSize = true;
            labelAddTitle.Location = new Point(10, 25);
            labelAddTitle.Name = "labelAddTitle";
            labelAddTitle.Size = new Size(80, 20);
            labelAddTitle.TabIndex = 0;
            labelAddTitle.Text = "Название:";
            // 
            // txtAddTitle
            // 
            txtAddTitle.Location = new Point(100, 22);
            txtAddTitle.Name = "txtAddTitle";
            txtAddTitle.Size = new Size(180, 27);
            txtAddTitle.TabIndex = 1;
            // 
            // labelAddDate
            // 
            labelAddDate.AutoSize = true;
            labelAddDate.Location = new Point(10, 55);
            labelAddDate.Name = "labelAddDate";
            labelAddDate.Size = new Size(44, 20);
            labelAddDate.TabIndex = 2;
            labelAddDate.Text = "Дата:";
            // 
            // dtpAddDate
            // 
            dtpAddDate.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpAddDate.Format = DateTimePickerFormat.Custom;
            dtpAddDate.Location = new Point(100, 50);
            dtpAddDate.Name = "dtpAddDate";
            dtpAddDate.Size = new Size(180, 27);
            dtpAddDate.TabIndex = 3;
            // 
            // labelAddDescription
            // 
            labelAddDescription.AutoSize = true;
            labelAddDescription.Location = new Point(10, 85);
            labelAddDescription.Name = "labelAddDescription";
            labelAddDescription.Size = new Size(82, 20);
            labelAddDescription.TabIndex = 4;
            labelAddDescription.Text = "Описание:";
            // 
            // txtAddDescription
            // 
            txtAddDescription.Location = new Point(100, 80);
            txtAddDescription.Multiline = true;
            txtAddDescription.Name = "txtAddDescription";
            txtAddDescription.Size = new Size(180, 60);
            txtAddDescription.TabIndex = 5;
            // 
            // labelAddCategory
            // 
            labelAddCategory.AutoSize = true;
            labelAddCategory.Location = new Point(10, 155);
            labelAddCategory.Name = "labelAddCategory";
            labelAddCategory.Size = new Size(84, 20);
            labelAddCategory.TabIndex = 6;
            labelAddCategory.Text = "Категория:";
            // 
            // cmbAddCategory
            // 
            cmbAddCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAddCategory.FormattingEnabled = true;
            cmbAddCategory.Location = new Point(100, 150);
            cmbAddCategory.Name = "cmbAddCategory";
            cmbAddCategory.Size = new Size(180, 28);
            cmbAddCategory.TabIndex = 7;
            // 
            // labelAddParticipants
            // 
            labelAddParticipants.AutoSize = true;
            labelAddParticipants.Location = new Point(10, 185);
            labelAddParticipants.Name = "labelAddParticipants";
            labelAddParticipants.Size = new Size(84, 20);
            labelAddParticipants.TabIndex = 8;
            labelAddParticipants.Text = "Участники:";
            // 
            // clbAddParticipants
            // 
            clbAddParticipants.FormattingEnabled = true;
            clbAddParticipants.Location = new Point(100, 185);
            clbAddParticipants.Name = "clbAddParticipants";
            clbAddParticipants.Size = new Size(180, 92);
            clbAddParticipants.TabIndex = 9;
            // 
            // btnAddEvent
            // 
            btnAddEvent.Location = new Point(100, 290);
            btnAddEvent.Name = "btnAddEvent";
            btnAddEvent.Size = new Size(180, 30);
            btnAddEvent.TabIndex = 10;
            btnAddEvent.Text = "Добавить";
            btnAddEvent.UseVisualStyleBackColor = true;
            // 
            // groupBoxEdit
            // 
            groupBoxEdit.Controls.Add(lbEditEvents);
            groupBoxEdit.Controls.Add(labelEditTitle);
            groupBoxEdit.Controls.Add(txtEditTitle);
            groupBoxEdit.Controls.Add(labelEditDate);
            groupBoxEdit.Controls.Add(dtpEditDate);
            groupBoxEdit.Controls.Add(labelEditCategory);
            groupBoxEdit.Controls.Add(cmbEditCategory);
            groupBoxEdit.Controls.Add(labelEditParticipants);
            groupBoxEdit.Controls.Add(clbEditParticipants);
            groupBoxEdit.Controls.Add(btnEditSelected);
            groupBoxEdit.Controls.Add(btnSaveChanges);
            groupBoxEdit.Location = new Point(312, 6);
            groupBoxEdit.Name = "groupBoxEdit";
            groupBoxEdit.Size = new Size(472, 350);
            groupBoxEdit.TabIndex = 1;
            groupBoxEdit.TabStop = false;
            groupBoxEdit.Text = "Редактирование события";
            // 
            // lbEditEvents
            // 
            lbEditEvents.FormattingEnabled = true;
            lbEditEvents.Location = new Point(10, 20);
            lbEditEvents.Name = "lbEditEvents";
            lbEditEvents.Size = new Size(456, 64);
            lbEditEvents.TabIndex = 0;
            // 
            // labelEditTitle
            // 
            labelEditTitle.AutoSize = true;
            labelEditTitle.Location = new Point(10, 115);
            labelEditTitle.Name = "labelEditTitle";
            labelEditTitle.Size = new Size(80, 20);
            labelEditTitle.TabIndex = 1;
            labelEditTitle.Text = "Название:";
            // 
            // txtEditTitle
            // 
            txtEditTitle.Location = new Point(100, 112);
            txtEditTitle.Name = "txtEditTitle";
            txtEditTitle.Size = new Size(366, 27);
            txtEditTitle.TabIndex = 2;
            // 
            // labelEditDate
            // 
            labelEditDate.AutoSize = true;
            labelEditDate.Location = new Point(10, 145);
            labelEditDate.Name = "labelEditDate";
            labelEditDate.Size = new Size(44, 20);
            labelEditDate.TabIndex = 3;
            labelEditDate.Text = "Дата:";
            // 
            // dtpEditDate
            // 
            dtpEditDate.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpEditDate.Format = DateTimePickerFormat.Custom;
            dtpEditDate.Location = new Point(100, 140);
            dtpEditDate.Name = "dtpEditDate";
            dtpEditDate.Size = new Size(366, 27);
            dtpEditDate.TabIndex = 4;
            // 
            // labelEditCategory
            // 
            labelEditCategory.AutoSize = true;
            labelEditCategory.Location = new Point(10, 175);
            labelEditCategory.Name = "labelEditCategory";
            labelEditCategory.Size = new Size(84, 20);
            labelEditCategory.TabIndex = 5;
            labelEditCategory.Text = "Категория:";
            // 
            // cmbEditCategory
            // 
            cmbEditCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEditCategory.FormattingEnabled = true;
            cmbEditCategory.Location = new Point(100, 170);
            cmbEditCategory.Name = "cmbEditCategory";
            cmbEditCategory.Size = new Size(366, 28);
            cmbEditCategory.TabIndex = 6;
            // 
            // labelEditParticipants
            // 
            labelEditParticipants.AutoSize = true;
            labelEditParticipants.Location = new Point(10, 205);
            labelEditParticipants.Name = "labelEditParticipants";
            labelEditParticipants.Size = new Size(84, 20);
            labelEditParticipants.TabIndex = 7;
            labelEditParticipants.Text = "Участники:";
            // 
            // clbEditParticipants
            // 
            clbEditParticipants.FormattingEnabled = true;
            clbEditParticipants.Location = new Point(100, 205);
            clbEditParticipants.Name = "clbEditParticipants";
            clbEditParticipants.Size = new Size(366, 48);
            clbEditParticipants.TabIndex = 8;
            // 
            // btnEditSelected
            // 
            btnEditSelected.Location = new Point(10, 280);
            btnEditSelected.Name = "btnEditSelected";
            btnEditSelected.Size = new Size(130, 30);
            btnEditSelected.TabIndex = 9;
            btnEditSelected.Text = "Редактировать выбранное событие";
            btnEditSelected.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(160, 280);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(130, 30);
            btnSaveChanges.TabIndex = 10;
            btnSaveChanges.Text = "Сохранить изменения";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // groupBoxDelete
            // 
            groupBoxDelete.Controls.Add(lbDeleteEvents);
            groupBoxDelete.Controls.Add(btnDelete);
            groupBoxDelete.Location = new Point(6, 362);
            groupBoxDelete.Name = "groupBoxDelete";
            groupBoxDelete.Size = new Size(772, 200);
            groupBoxDelete.TabIndex = 2;
            groupBoxDelete.TabStop = false;
            groupBoxDelete.Text = "Удаление события";
            // 
            // lbDeleteEvents
            // 
            lbDeleteEvents.FormattingEnabled = true;
            lbDeleteEvents.Location = new Point(10, 20);
            lbDeleteEvents.Name = "lbDeleteEvents";
            lbDeleteEvents.Size = new Size(730, 124);
            lbDeleteEvents.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(466, 164);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(280, 30);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(800, 600);
            Controls.Add(tabControlMain);
            Name = "Form1";
            Text = "Менеджер событий";
            tabControlMain.ResumeLayout(false);
            tabPageMain.ResumeLayout(false);
            groupBoxDetails.ResumeLayout(false);
            groupBoxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEventImage).EndInit();
            groupBoxView.ResumeLayout(false);
            groupBoxView.PerformLayout();
            tabPageEdit.ResumeLayout(false);
            groupBoxAdd.ResumeLayout(false);
            groupBoxAdd.PerformLayout();
            groupBoxEdit.ResumeLayout(false);
            groupBoxEdit.PerformLayout();
            groupBoxDelete.ResumeLayout(false);
            ResumeLayout(false);
=======
﻿namespace TestForChanges
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.dtpMainFilterDate = new System.Windows.Forms.DateTimePicker();
            this.cmbMainFilterCategory = new System.Windows.Forms.ComboBox();
            this.btnMainApplyFilter = new System.Windows.Forms.Button();
            this.lbMainEvents = new System.Windows.Forms.ListBox();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.picEventImage = new System.Windows.Forms.PictureBox();
            this.labelEventName = new System.Windows.Forms.Label();
            this.labelEventDescription = new System.Windows.Forms.Label();
            this.labelEventTime = new System.Windows.Forms.Label();
            this.labelEventParticipants = new System.Windows.Forms.Label();
            this.labelEventCategory = new System.Windows.Forms.Label();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
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
            this.tabControlMain.Size = new System.Drawing.Size(1000, 600);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackColor = System.Drawing.Color.White;
            this.tabPageMain.Controls.Add(this.groupBoxFilter);
            this.tabPageMain.Controls.Add(this.groupBoxDetails);
            this.tabPageMain.Location = new System.Drawing.Point(4, 25);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(992, 571);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Главное меню";
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.BackColor = System.Drawing.Color.White;
            this.groupBoxFilter.Controls.Add(this.dtpMainFilterDate);
            this.groupBoxFilter.Controls.Add(this.cmbMainFilterCategory);
            this.groupBoxFilter.Controls.Add(this.btnMainApplyFilter);
            this.groupBoxFilter.Controls.Add(this.lbMainEvents);
            this.groupBoxFilter.Location = new System.Drawing.Point(10, 10);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(480, 553);
            this.groupBoxFilter.TabIndex = 0;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "События и фильтрация";
            // 
            // dtpMainFilterDate
            // 
            this.dtpMainFilterDate.Location = new System.Drawing.Point(20, 30);
            this.dtpMainFilterDate.Name = "dtpMainFilterDate";
            this.dtpMainFilterDate.Size = new System.Drawing.Size(200, 22);
            this.dtpMainFilterDate.TabIndex = 0;
            // 
            // cmbMainFilterCategory
            // 
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
            this.btnMainApplyFilter.UseVisualStyleBackColor = true;
            // 
            // lbMainEvents
            // 
            this.lbMainEvents.FormattingEnabled = true;
            this.lbMainEvents.ItemHeight = 16;
            this.lbMainEvents.Location = new System.Drawing.Point(20, 100);
            this.lbMainEvents.Name = "lbMainEvents";
            this.lbMainEvents.Size = new System.Drawing.Size(420, 436);
            this.lbMainEvents.TabIndex = 3;
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.BackColor = System.Drawing.Color.White;
            this.groupBoxDetails.Controls.Add(this.label1);
            this.groupBoxDetails.Controls.Add(this.button1);
            this.groupBoxDetails.Controls.Add(this.picEventImage);
            this.groupBoxDetails.Controls.Add(this.labelEventName);
            this.groupBoxDetails.Controls.Add(this.labelEventDescription);
            this.groupBoxDetails.Controls.Add(this.labelEventTime);
            this.groupBoxDetails.Controls.Add(this.labelEventParticipants);
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
            this.picEventImage.Size = new System.Drawing.Size(150, 150);
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
            this.labelEventDescription.Location = new System.Drawing.Point(190, 60);
            this.labelEventDescription.Name = "labelEventDescription";
            this.labelEventDescription.Size = new System.Drawing.Size(270, 40);
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
            // labelEventParticipants
            // 
            this.labelEventParticipants.AutoSize = true;
            this.labelEventParticipants.Location = new System.Drawing.Point(190, 140);
            this.labelEventParticipants.Name = "labelEventParticipants";
            this.labelEventParticipants.Size = new System.Drawing.Size(80, 16);
            this.labelEventParticipants.TabIndex = 4;
            this.labelEventParticipants.Text = "Участники:";
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
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(992, 571);
            this.tabPageAdd.TabIndex = 1;
            this.tabPageAdd.Text = "Добавить";
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.BackColor = System.Drawing.Color.White;
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
            // txtAddTitle
            // 
            this.txtAddTitle.Location = new System.Drawing.Point(20, 30);
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.Size = new System.Drawing.Size(300, 22);
            this.txtAddTitle.TabIndex = 0;
            // 
            // dtpAddDate
            // 
            this.dtpAddDate.Location = new System.Drawing.Point(340, 30);
            this.dtpAddDate.Name = "dtpAddDate";
            this.dtpAddDate.Size = new System.Drawing.Size(200, 22);
            this.dtpAddDate.TabIndex = 1;
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(20, 60);
            this.txtAddDescription.Multiline = true;
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(520, 80);
            this.txtAddDescription.TabIndex = 2;
            // 
            // cmbAddCategory
            // 
            this.cmbAddCategory.FormattingEnabled = true;
            this.cmbAddCategory.Location = new System.Drawing.Point(560, 30);
            this.cmbAddCategory.Name = "cmbAddCategory";
            this.cmbAddCategory.Size = new System.Drawing.Size(200, 24);
            this.cmbAddCategory.TabIndex = 3;
            // 
            // clbAddParticipants
            // 
            this.clbAddParticipants.FormattingEnabled = true;
            this.clbAddParticipants.Location = new System.Drawing.Point(560, 60);
            this.clbAddParticipants.Name = "clbAddParticipants";
            this.clbAddParticipants.Size = new System.Drawing.Size(200, 106);
            this.clbAddParticipants.TabIndex = 4;
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(20, 160);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(150, 30);
            this.btnAddPicture.TabIndex = 5;
            this.btnAddPicture.Text = "Добавить картинку";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            // 
            // cmbListElementType
            // 
            this.cmbListElementType.FormattingEnabled = true;
            this.cmbListElementType.Location = new System.Drawing.Point(180, 160);
            this.cmbListElementType.Name = "cmbListElementType";
            this.cmbListElementType.Size = new System.Drawing.Size(150, 24);
            this.cmbListElementType.TabIndex = 6;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(340, 160);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(150, 30);
            this.btnAddEvent.TabIndex = 7;
            this.btnAddEvent.Text = "Добавить событие";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.BackColor = System.Drawing.Color.White;
            this.tabPageEdit.Controls.Add(this.groupBoxEdit);
            this.tabPageEdit.Location = new System.Drawing.Point(4, 25);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEdit.Size = new System.Drawing.Size(992, 571);
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
            this.lbEditEvents.Size = new System.Drawing.Size(300, 500);
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
            this.dtpEditDate.Location = new System.Drawing.Point(340, 60);
            this.dtpEditDate.Name = "dtpEditDate";
            this.dtpEditDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEditDate.TabIndex = 2;
            // 
            // cmbEditCategory
            // 
            this.cmbEditCategory.FormattingEnabled = true;
            this.cmbEditCategory.Location = new System.Drawing.Point(340, 90);
            this.cmbEditCategory.Name = "cmbEditCategory";
            this.cmbEditCategory.Size = new System.Drawing.Size(568, 24);
            this.cmbEditCategory.TabIndex = 3;
            // 
            // clbEditParticipants
            // 
            this.clbEditParticipants.FormattingEnabled = true;
            this.clbEditParticipants.Location = new System.Drawing.Point(340, 120);
            this.clbEditParticipants.Name = "clbEditParticipants";
            this.clbEditParticipants.Size = new System.Drawing.Size(568, 106);
            this.clbEditParticipants.TabIndex = 4;
            // 
            // btnEditSelected
            // 
            this.btnEditSelected.Location = new System.Drawing.Point(340, 240);
            this.btnEditSelected.Name = "btnEditSelected";
            this.btnEditSelected.Size = new System.Drawing.Size(200, 30);
            this.btnEditSelected.TabIndex = 5;
            this.btnEditSelected.Text = "Редактировать выбранное событие";
            this.btnEditSelected.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(708, 240);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(200, 30);
            this.btnSaveChanges.TabIndex = 6;
            this.btnSaveChanges.Text = "Сохранить изменения";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.BackColor = System.Drawing.Color.White;
            this.tabPageDelete.Controls.Add(this.groupBoxDelete);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 25);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDelete.Size = new System.Drawing.Size(992, 571);
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
            this.lbDeleteEvents.Size = new System.Drawing.Size(300, 500);
            this.lbDeleteEvents.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(340, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 30);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Удалить выбранное событие";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // tabPageReport
            // 
            this.tabPageReport.BackColor = System.Drawing.Color.White;
            this.tabPageReport.Controls.Add(this.groupBoxReport);
            this.tabPageReport.Location = new System.Drawing.Point(4, 25);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReport.Size = new System.Drawing.Size(992, 571);
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
            this.groupBoxReport.Enter += new System.EventHandler(this.groupBoxReport_Enter);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(20, 30);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(250, 30);
            this.btnGenerateReport.TabIndex = 0;
            this.btnGenerateReport.Text = "Сформировать Excel отчёт";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сформировать Excel отчёт";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Генерация отчета:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.Text = "Менеджер событий";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.groupBoxFilter.ResumeLayout(false);
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

>>>>>>> cebaecd (Обновленный макет)
        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMain;
<<<<<<< HEAD
        private System.Windows.Forms.TabPage tabPageEdit;
        // Вкладка "Главное меню"
        private System.Windows.Forms.GroupBox groupBoxView;
        private System.Windows.Forms.Label labelMainFilterDate;
        private System.Windows.Forms.DateTimePicker dtpMainFilterDate;
        private System.Windows.Forms.Label labelMainFilterCategory;
=======
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.DateTimePicker dtpMainFilterDate;
>>>>>>> cebaecd (Обновленный макет)
        private System.Windows.Forms.ComboBox cmbMainFilterCategory;
        private System.Windows.Forms.Button btnMainApplyFilter;
        private System.Windows.Forms.ListBox lbMainEvents;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.PictureBox picEventImage;
        private System.Windows.Forms.Label labelEventName;
        private System.Windows.Forms.Label labelEventDescription;
        private System.Windows.Forms.Label labelEventTime;
        private System.Windows.Forms.Label labelEventParticipants;
        private System.Windows.Forms.Label labelEventCategory;
<<<<<<< HEAD
        // Вкладка "Редактирование" – группы как в предыдущем примере
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
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.ListBox lbDeleteEvents;
        private System.Windows.Forms.Button btnDelete;
    }
}
=======
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.DateTimePicker dtpAddDate;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.ComboBox cmbAddCategory;
        private System.Windows.Forms.CheckedListBox clbAddParticipants;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.ComboBox cmbListElementType;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.ListBox lbEditEvents;
        private System.Windows.Forms.TextBox txtEditTitle;
        private System.Windows.Forms.DateTimePicker dtpEditDate;
        private System.Windows.Forms.ComboBox cmbEditCategory;
        private System.Windows.Forms.CheckedListBox clbEditParticipants;
        private System.Windows.Forms.Button btnEditSelected;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.ListBox lbDeleteEvents;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabPage tabPageReport;
        private System.Windows.Forms.GroupBox groupBoxReport;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
>>>>>>> cebaecd (Обновленный макет)
