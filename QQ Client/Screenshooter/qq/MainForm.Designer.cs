namespace qq
{
    partial class Qq
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Qq));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.m_Comments = new System.Windows.Forms.ToolStripMenuItem();
            this.m_Grapheditor = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранятьНаСервисеImgurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_Saveto_Imgur = new System.Windows.Forms.ToolStripMenuItem();
            this.m_SavetoQQ = new System.Windows.Forms.ToolStripMenuItem();
            this.m_SavetoFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.скриншотВсегоЭкранаPrintScrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.снимокВсехЭкрановToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скриншотАктивногоОкнаAltPrntScrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скриншотВыделеннойОбластиCtrlPrntScrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьПапкуСоСкриншотамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flgAutostart = new System.Windows.Forms.CheckBox();
            this.TargetFolder = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnFolderBrowser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filenameTemplate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Templates = new System.Windows.Forms.ComboBox();
            this.btnAddTemplate = new System.Windows.Forms.Button();
            this.btnClearFilenameTemplate = new System.Windows.Forms.Button();
            this.btnDefaulSettings = new System.Windows.Forms.Button();
            this.cbFileformat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FileDescription = new System.Windows.Forms.CheckBox();
            this.GraphEditor = new System.Windows.Forms.CheckBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Кукушка - Мой скриншот";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_Comments,
            this.m_Grapheditor,
            this.сохранятьНаСервисеImgurToolStripMenuItem,
            this.toolStripSeparator1,
            this.скриншотВсегоЭкранаPrintScrintToolStripMenuItem,
            this.снимокВсехЭкрановToolStripMenuItem,
            this.скриншотАктивногоОкнаAltPrntScrToolStripMenuItem,
            this.скриншотВыделеннойОбластиCtrlPrntScrToolStripMenuItem,
            this.открытьПапкуСоСкриншотамиToolStripMenuItem,
            this.toolStripSeparator2,
            this.настройкиToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.contextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(380, 258);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // m_Comments
            // 
            this.m_Comments.Checked = true;
            this.m_Comments.CheckOnClick = true;
            this.m_Comments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_Comments.DoubleClickEnabled = true;
            this.m_Comments.Name = "m_Comments";
            this.m_Comments.Size = new System.Drawing.Size(379, 22);
            this.m_Comments.Text = "При сохранении запрашивать текстовый комментарий";
            this.m_Comments.Click += new System.EventHandler(this.m_Comments_Click);
            // 
            // m_Grapheditor
            // 
            this.m_Grapheditor.Checked = true;
            this.m_Grapheditor.CheckOnClick = true;
            this.m_Grapheditor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_Grapheditor.DoubleClickEnabled = true;
            this.m_Grapheditor.Name = "m_Grapheditor";
            this.m_Grapheditor.Size = new System.Drawing.Size(379, 22);
            this.m_Grapheditor.Text = "Редактировать изображение перед сохранением";
            this.m_Grapheditor.Click += new System.EventHandler(this.m_Grapheditor_Click);
            // 
            // сохранятьНаСервисеImgurToolStripMenuItem
            // 
            this.сохранятьНаСервисеImgurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_Saveto_Imgur,
            this.m_SavetoQQ,
            this.m_SavetoFolder});
            this.сохранятьНаСервисеImgurToolStripMenuItem.Name = "сохранятьНаСервисеImgurToolStripMenuItem";
            this.сохранятьНаСервисеImgurToolStripMenuItem.Size = new System.Drawing.Size(379, 22);
            this.сохранятьНаСервисеImgurToolStripMenuItem.Text = "Сохранять на..";
            // 
            // m_Saveto_Imgur
            // 
            this.m_Saveto_Imgur.Checked = true;
            this.m_Saveto_Imgur.CheckOnClick = true;
            this.m_Saveto_Imgur.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_Saveto_Imgur.Name = "m_Saveto_Imgur";
            this.m_Saveto_Imgur.Size = new System.Drawing.Size(169, 22);
            this.m_Saveto_Imgur.Text = "на сервисе Imgur";
            this.m_Saveto_Imgur.Click += new System.EventHandler(this.m_Saveto_Imgur_Click);
            // 
            // m_SavetoQQ
            // 
            this.m_SavetoQQ.Checked = true;
            this.m_SavetoQQ.CheckOnClick = true;
            this.m_SavetoQQ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_SavetoQQ.Name = "m_SavetoQQ";
            this.m_SavetoQQ.Size = new System.Drawing.Size(169, 22);
            this.m_SavetoQQ.Text = "на сервисе QQ";
            this.m_SavetoQQ.Click += new System.EventHandler(this.m_SavetoQQ_Click);
            // 
            // m_SavetoFolder
            // 
            this.m_SavetoFolder.Checked = true;
            this.m_SavetoFolder.CheckOnClick = true;
            this.m_SavetoFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_SavetoFolder.Name = "m_SavetoFolder";
            this.m_SavetoFolder.Size = new System.Drawing.Size(169, 22);
            this.m_SavetoFolder.Text = "в папке";
            this.m_SavetoFolder.Click += new System.EventHandler(this.m_SavetoFolder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(376, 6);
            // 
            // скриншотВсегоЭкранаPrintScrintToolStripMenuItem
            // 
            this.скриншотВсегоЭкранаPrintScrintToolStripMenuItem.Name = "скриншотВсегоЭкранаPrintScrintToolStripMenuItem";
            this.скриншотВсегоЭкранаPrintScrintToolStripMenuItem.Size = new System.Drawing.Size(379, 22);
            this.скриншотВсегоЭкранаPrintScrintToolStripMenuItem.Text = "Снимок основного экрана (Shift+PrintScrint)";
            this.скриншотВсегоЭкранаPrintScrintToolStripMenuItem.Click += new System.EventHandler(this.скриншотВсегоЭкранаPrintScrintToolStripMenuItem_Click);
            // 
            // снимокВсехЭкрановToolStripMenuItem
            // 
            this.снимокВсехЭкрановToolStripMenuItem.Name = "снимокВсехЭкрановToolStripMenuItem";
            this.снимокВсехЭкрановToolStripMenuItem.Size = new System.Drawing.Size(379, 22);
            this.снимокВсехЭкрановToolStripMenuItem.Text = "Снимок всех экранов";
            this.снимокВсехЭкрановToolStripMenuItem.Click += new System.EventHandler(this.снимокВсехЭкрановToolStripMenuItem_Click);
            // 
            // скриншотАктивногоОкнаAltPrntScrToolStripMenuItem
            // 
            this.скриншотАктивногоОкнаAltPrntScrToolStripMenuItem.Name = "скриншотАктивногоОкнаAltPrntScrToolStripMenuItem";
            this.скриншотАктивногоОкнаAltPrntScrToolStripMenuItem.Size = new System.Drawing.Size(379, 22);
            this.скриншотАктивногоОкнаAltPrntScrToolStripMenuItem.Text = "Снимок активного окна (Alt+PrintScreen)";
            this.скриншотАктивногоОкнаAltPrntScrToolStripMenuItem.Click += new System.EventHandler(this.скриншотАктивногоОкнаAltPrntScrToolStripMenuItem_Click);
            // 
            // скриншотВыделеннойОбластиCtrlPrntScrToolStripMenuItem
            // 
            this.скриншотВыделеннойОбластиCtrlPrntScrToolStripMenuItem.Name = "скриншотВыделеннойОбластиCtrlPrntScrToolStripMenuItem";
            this.скриншотВыделеннойОбластиCtrlPrntScrToolStripMenuItem.Size = new System.Drawing.Size(379, 22);
            this.скриншотВыделеннойОбластиCtrlPrntScrToolStripMenuItem.Text = "Снимок выделенной области (Ctrl+PrintScreen)";
            this.скриншотВыделеннойОбластиCtrlPrntScrToolStripMenuItem.Click += new System.EventHandler(this.скриншотВыделеннойОбластиCtrlPrntScrToolStripMenuItem_Click);
            // 
            // открытьПапкуСоСкриншотамиToolStripMenuItem
            // 
            this.открытьПапкуСоСкриншотамиToolStripMenuItem.Name = "открытьПапкуСоСкриншотамиToolStripMenuItem";
            this.открытьПапкуСоСкриншотамиToolStripMenuItem.Size = new System.Drawing.Size(379, 22);
            this.открытьПапкуСоСкриншотамиToolStripMenuItem.Text = "Открыть папку со скриншотами";
            this.открытьПапкуСоСкриншотамиToolStripMenuItem.Click += new System.EventHandler(this.открытьПапкуСоСкриншотамиToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(379, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(379, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // flgAutostart
            // 
            this.flgAutostart.AutoSize = true;
            this.flgAutostart.Location = new System.Drawing.Point(25, 28);
            this.flgAutostart.Name = "flgAutostart";
            this.flgAutostart.Size = new System.Drawing.Size(96, 17);
            this.flgAutostart.TabIndex = 5;
            this.flgAutostart.Text = "Автозагрузка";
            this.flgAutostart.UseVisualStyleBackColor = true;
            // 
            // TargetFolder
            // 
            this.TargetFolder.Location = new System.Drawing.Point(97, 163);
            this.TargetFolder.Name = "TargetFolder";
            this.TargetFolder.Size = new System.Drawing.Size(592, 20);
            this.TargetFolder.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Рабочий стол",
            "Мои изображения",
            "Мои документы"});
            this.comboBox1.Location = new System.Drawing.Point(195, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Скриншоты размещать";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(600, 401);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(696, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Закрыть";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(25, 92);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(113, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.Text = "На сервисе Imgur";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(25, 137);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(164, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "В предопределенной папке";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(25, 161);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(65, 17);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "В папке";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnFolderBrowser
            // 
            this.btnFolderBrowser.Image = global::qq.Properties.Resources.folder_yellow_explorer_icon;
            this.btnFolderBrowser.Location = new System.Drawing.Point(696, 152);
            this.btnFolderBrowser.Name = "btnFolderBrowser";
            this.btnFolderBrowser.Size = new System.Drawing.Size(45, 41);
            this.btnFolderBrowser.TabIndex = 9;
            this.btnFolderBrowser.UseVisualStyleBackColor = true;
            this.btnFolderBrowser.Click += new System.EventHandler(this.btnFolderBrowser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(212, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // filenameTemplate
            // 
            this.filenameTemplate.Location = new System.Drawing.Point(25, 218);
            this.filenameTemplate.Name = "filenameTemplate";
            this.filenameTemplate.Size = new System.Drawing.Size(664, 20);
            this.filenameTemplate.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Шаблон имени файла";
            // 
            // Templates
            // 
            this.Templates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Templates.FormattingEnabled = true;
            this.Templates.Items.AddRange(new object[] {
            "Папка Screenshots",
            "Папка Имя пользователя",
            "Папка Доменное имя пользователя",
            "Папка Имя компьютера",
            "Папка Дата",
            "Папка Название приложения",
            "Имя пользователя",
            "Доменное имя пользователя",
            "Имя компьютера",
            "Дата (формат: ГГГГ-ММ-ДД)",
            "Дата (формат: ГГГГММДД)",
            "Дата (формат: ДД-ММ-ГГГГ)",
            "Время (формат: ЧЧ-ММ)",
            "Время (формат: ММ-ЧЧ)",
            "Время (формат: ЧЧММ)",
            "Название приложения",
            "Нумератор",
            "Комментарий"});
            this.Templates.Location = new System.Drawing.Point(25, 244);
            this.Templates.Name = "Templates";
            this.Templates.Size = new System.Drawing.Size(264, 21);
            this.Templates.TabIndex = 17;
            this.Templates.SelectedIndexChanged += new System.EventHandler(this.Templates_SelectedIndexChanged);
            // 
            // btnAddTemplate
            // 
            this.btnAddTemplate.Location = new System.Drawing.Point(295, 244);
            this.btnAddTemplate.Name = "btnAddTemplate";
            this.btnAddTemplate.Size = new System.Drawing.Size(75, 23);
            this.btnAddTemplate.TabIndex = 18;
            this.btnAddTemplate.Text = "Добавить";
            this.btnAddTemplate.UseVisualStyleBackColor = true;
            this.btnAddTemplate.Click += new System.EventHandler(this.btnAddTemplate_Click);
            // 
            // btnClearFilenameTemplate
            // 
            this.btnClearFilenameTemplate.Location = new System.Drawing.Point(695, 215);
            this.btnClearFilenameTemplate.Name = "btnClearFilenameTemplate";
            this.btnClearFilenameTemplate.Size = new System.Drawing.Size(75, 23);
            this.btnClearFilenameTemplate.TabIndex = 19;
            this.btnClearFilenameTemplate.Text = "Очистить";
            this.btnClearFilenameTemplate.UseVisualStyleBackColor = true;
            this.btnClearFilenameTemplate.Click += new System.EventHandler(this.btnClearFilenameTemplate_Click);
            // 
            // btnDefaulSettings
            // 
            this.btnDefaulSettings.Location = new System.Drawing.Point(414, 401);
            this.btnDefaulSettings.Name = "btnDefaulSettings";
            this.btnDefaulSettings.Size = new System.Drawing.Size(161, 23);
            this.btnDefaulSettings.TabIndex = 20;
            this.btnDefaulSettings.Text = "Настройки по умолчанию";
            this.btnDefaulSettings.UseVisualStyleBackColor = true;
            this.btnDefaulSettings.Click += new System.EventHandler(this.btnDefaulSettings_Click);
            // 
            // cbFileformat
            // 
            this.cbFileformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFileformat.FormattingEnabled = true;
            this.cbFileformat.Location = new System.Drawing.Point(112, 273);
            this.cbFileformat.Name = "cbFileformat";
            this.cbFileformat.Size = new System.Drawing.Size(177, 21);
            this.cbFileformat.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Формат файла";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FileDescription
            // 
            this.FileDescription.AutoSize = true;
            this.FileDescription.Location = new System.Drawing.Point(25, 329);
            this.FileDescription.Name = "FileDescription";
            this.FileDescription.Size = new System.Drawing.Size(307, 17);
            this.FileDescription.TabIndex = 24;
            this.FileDescription.Text = "При сохранении запрашивать текстовый комментарий";
            this.FileDescription.UseVisualStyleBackColor = true;
            // 
            // GraphEditor
            // 
            this.GraphEditor.AutoSize = true;
            this.GraphEditor.Location = new System.Drawing.Point(25, 352);
            this.GraphEditor.Name = "GraphEditor";
            this.GraphEditor.Size = new System.Drawing.Size(145, 17);
            this.GraphEditor.TabIndex = 24;
            this.GraphEditor.Text = "Редактор изображений";
            this.GraphEditor.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(25, 115);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(103, 17);
            this.radioButton4.TabIndex = 12;
            this.radioButton4.Text = "На сервисе QQ";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(376, 6);
            // 
            // Qq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(783, 436);
            this.Controls.Add(this.GraphEditor);
            this.Controls.Add(this.FileDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFileformat);
            this.Controls.Add(this.btnDefaulSettings);
            this.Controls.Add(this.btnClearFilenameTemplate);
            this.Controls.Add(this.btnAddTemplate);
            this.Controls.Add(this.Templates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filenameTemplate);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFolderBrowser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TargetFolder);
            this.Controls.Add(this.flgAutostart);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Qq";
            this.Opacity = 0.65D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кукушка - Мой скриншот";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Qq_FormClosing);
            this.Load += new System.EventHandler(this.Qq_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скриншотВсегоЭкранаPrintScrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скриншотАктивногоОкнаAltPrntScrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скриншотВыделеннойОбластиCtrlPrntScrToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox flgAutostart;
        private System.Windows.Forms.TextBox TargetFolder;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnFolderBrowser;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ToolStripMenuItem открытьПапкуСоСкриншотамиToolStripMenuItem;
        private System.Windows.Forms.TextBox filenameTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Templates;
        private System.Windows.Forms.Button btnAddTemplate;
        private System.Windows.Forms.Button btnClearFilenameTemplate;
        private System.Windows.Forms.Button btnDefaulSettings;
        private System.Windows.Forms.ComboBox cbFileformat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem снимокВсехЭкрановToolStripMenuItem;
        private System.Windows.Forms.CheckBox FileDescription;
        private System.Windows.Forms.CheckBox GraphEditor;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ToolStripMenuItem m_Grapheditor;
        private System.Windows.Forms.ToolStripMenuItem m_Comments;
        private System.Windows.Forms.ToolStripMenuItem сохранятьНаСервисеImgurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_Saveto_Imgur;
        private System.Windows.Forms.ToolStripMenuItem m_SavetoQQ;
        private System.Windows.Forms.ToolStripMenuItem m_SavetoFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

