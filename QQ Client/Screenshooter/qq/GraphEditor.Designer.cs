namespace qq
{
    partial class GraphEditor
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
            this.ToolsColorDialog = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.инструментToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маркерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.карандашToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.прямоугольникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окружностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ластикToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSave = new System.Windows.Forms.ToolStripMenuItem();
            this.толщинаЛинииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.отменаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFigure = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSize = new System.Windows.Forms.ToolStripComboBox();
            this.tempPictureBox = new System.Windows.Forms.PictureBox();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инструментToolStripMenuItem,
            this.toolStripColor,
            this.ToolStripCancel,
            this.toolStripSave,
            this.толщинаЛинииToolStripMenuItem,
            this.отменаToolStripMenuItem,
            this.toolStripFigure,
            this.toolStripSize});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 27);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // инструментToolStripMenuItem
            // 
            this.инструментToolStripMenuItem.AutoToolTip = true;
            this.инструментToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.маркерToolStripMenuItem,
            this.карандашToolStripMenuItem,
            this.линияToolStripMenuItem1,
            this.прямоугольникToolStripMenuItem,
            this.окружностьToolStripMenuItem,
            this.ластикToolStripMenuItem1});
            this.инструментToolStripMenuItem.Image = global::qq.Properties.Resources.Administrative_Tools_64;
            this.инструментToolStripMenuItem.Name = "инструментToolStripMenuItem";
            this.инструментToolStripMenuItem.Size = new System.Drawing.Size(102, 23);
            this.инструментToolStripMenuItem.Text = "Инструмент";
            // 
            // маркерToolStripMenuItem
            // 
            this.маркерToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.маркерToolStripMenuItem.Checked = true;
            this.маркерToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.маркерToolStripMenuItem.Image = global::qq.Properties.Resources.highlight;
            this.маркерToolStripMenuItem.Name = "маркерToolStripMenuItem";
            this.маркерToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.маркерToolStripMenuItem.Text = "Маркер";
            this.маркерToolStripMenuItem.Click += new System.EventHandler(this.маркерToolStripMenuItem_Click);
            // 
            // карандашToolStripMenuItem
            // 
            this.карандашToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.карандашToolStripMenuItem.Image = global::qq.Properties.Resources.pencil3_7194;
            this.карандашToolStripMenuItem.Name = "карандашToolStripMenuItem";
            this.карандашToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.карандашToolStripMenuItem.Text = "Карандаш";
            this.карандашToolStripMenuItem.Click += new System.EventHandler(this.карандашToolStripMenuItem_Click);
            // 
            // линияToolStripMenuItem1
            // 
            this.линияToolStripMenuItem1.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.линияToolStripMenuItem1.Image = global::qq.Properties.Resources.stock_draw_line_4514;
            this.линияToolStripMenuItem1.Name = "линияToolStripMenuItem1";
            this.линияToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.линияToolStripMenuItem1.Text = "Линия";
            this.линияToolStripMenuItem1.Click += new System.EventHandler(this.линияToolStripMenuItem1_Click);
            // 
            // прямоугольникToolStripMenuItem
            // 
            this.прямоугольникToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.прямоугольникToolStripMenuItem.Image = global::qq.Properties.Resources.rectangle;
            this.прямоугольникToolStripMenuItem.Name = "прямоугольникToolStripMenuItem";
            this.прямоугольникToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.прямоугольникToolStripMenuItem.Text = "Прямоугольник";
            this.прямоугольникToolStripMenuItem.Click += new System.EventHandler(this.прямоугольникToolStripMenuItem_Click);
            // 
            // окружностьToolStripMenuItem
            // 
            this.окружностьToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.окружностьToolStripMenuItem.Image = global::qq.Properties.Resources.stock_draw_ellipse_unfilled;
            this.окружностьToolStripMenuItem.Name = "окружностьToolStripMenuItem";
            this.окружностьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.окружностьToolStripMenuItem.Text = "Окружность";
            this.окружностьToolStripMenuItem.Click += new System.EventHandler(this.окружностьToolStripMenuItem_Click);
            // 
            // ластикToolStripMenuItem1
            // 
            this.ластикToolStripMenuItem1.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.ластикToolStripMenuItem1.Image = global::qq.Properties.Resources.eraser_9436;
            this.ластикToolStripMenuItem1.Name = "ластикToolStripMenuItem1";
            this.ластикToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.ластикToolStripMenuItem1.Text = "Ластик";
            this.ластикToolStripMenuItem1.Click += new System.EventHandler(this.ластикToolStripMenuItem1_Click);
            // 
            // toolStripColor
            // 
            this.toolStripColor.AutoToolTip = true;
            this.toolStripColor.BackColor = System.Drawing.Color.Transparent;
            this.toolStripColor.Image = global::qq.Properties.Resources.color_palette;
            this.toolStripColor.Name = "toolStripColor";
            this.toolStripColor.Size = new System.Drawing.Size(61, 23);
            this.toolStripColor.Text = "Цвет";
            this.toolStripColor.ToolTipText = "Выбор цвета";
            this.toolStripColor.Click += new System.EventHandler(this.toolStripColor_Click);
            // 
            // ToolStripCancel
            // 
            this.ToolStripCancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripCancel.Image = global::qq.Properties.Resources.cancel;
            this.ToolStripCancel.Name = "ToolStripCancel";
            this.ToolStripCancel.Size = new System.Drawing.Size(77, 23);
            this.ToolStripCancel.Text = "Отмена";
            this.ToolStripCancel.ToolTipText = "Отмена";
            this.ToolStripCancel.Click += new System.EventHandler(this.ToolStripCancel_Click);
            // 
            // toolStripSave
            // 
            this.toolStripSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSave.AutoToolTip = true;
            this.toolStripSave.Image = global::qq.Properties.Resources.save_accept;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(93, 23);
            this.toolStripSave.Text = "Сохранить";
            this.toolStripSave.ToolTipText = "Сохранить";
            this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
            // 
            // толщинаЛинииToolStripMenuItem
            // 
            this.толщинаЛинииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.толщинаЛинииToolStripMenuItem.Image = global::qq.Properties.Resources.stock_draw_line_4514;
            this.толщинаЛинииToolStripMenuItem.Name = "толщинаЛинииToolStripMenuItem";
            this.толщинаЛинииToolStripMenuItem.Size = new System.Drawing.Size(125, 23);
            this.толщинаЛинииToolStripMenuItem.Text = "Толщина линии";
            this.толщинаЛинииToolStripMenuItem.Click += new System.EventHandler(this.толщинаЛинииToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem2.Text = "2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem3.Text = "4";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem4.Text = "8";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem5.Text = "16";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem6.Text = "32";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem7.Text = "64";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // отменаToolStripMenuItem
            // 
            this.отменаToolStripMenuItem.Image = global::qq.Properties.Resources.arrow_undo;
            this.отменаToolStripMenuItem.Name = "отменаToolStripMenuItem";
            this.отменаToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.отменаToolStripMenuItem.Text = "Отмена";
            this.отменаToolStripMenuItem.Click += new System.EventHandler(this.отменаToolStripMenuItem_Click);
            // 
            // toolStripFigure
            // 
            this.toolStripFigure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripFigure.Enabled = false;
            this.toolStripFigure.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripFigure.Items.AddRange(new object[] {
            "Маркер",
            "Карандаш",
            "Линия",
            "Прямоугольник",
            "Окружность",
            "Ластик"});
            this.toolStripFigure.Name = "toolStripFigure";
            this.toolStripFigure.Size = new System.Drawing.Size(110, 23);
            this.toolStripFigure.Visible = false;
            this.toolStripFigure.SelectedIndexChanged += new System.EventHandler(this.toolStripFigure_SelectedIndexChanged);
            this.toolStripFigure.Click += new System.EventHandler(this.toolStripFigure_Click);
            // 
            // toolStripSize
            // 
            this.toolStripSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripSize.Enabled = false;
            this.toolStripSize.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.toolStripSize.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "16",
            "32",
            "64"});
            this.toolStripSize.Name = "toolStripSize";
            this.toolStripSize.Size = new System.Drawing.Size(75, 23);
            this.toolStripSize.Tag = "Тощина кисти";
            this.toolStripSize.ToolTipText = "Тощина кисти";
            this.toolStripSize.Visible = false;
            this.toolStripSize.SelectedIndexChanged += new System.EventHandler(this.toolStripSize_SelectedIndexChanged);
            this.toolStripSize.Click += new System.EventHandler(this.toolStripSize_Click);
            // 
            // tempPictureBox
            // 
            this.tempPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.tempPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tempPictureBox.Location = new System.Drawing.Point(0, 33);
            this.tempPictureBox.Name = "tempPictureBox";
            this.tempPictureBox.Size = new System.Drawing.Size(821, 356);
            this.tempPictureBox.TabIndex = 3;
            this.tempPictureBox.TabStop = false;
            this.tempPictureBox.Click += new System.EventHandler(this.tempPictureBox_Click);
            this.tempPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tempPictureBox_MouseDown);
            this.tempPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tempPictureBox_MouseMove);
            this.tempPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tempPictureBox_MouseUp);
            this.tempPictureBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tempPictureBox_PreviewKeyDown);
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.mainPictureBox.Location = new System.Drawing.Point(0, 33);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(821, 356);
            this.mainPictureBox.TabIndex = 2;
            this.mainPictureBox.TabStop = false;
            // 
            // GraphEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(821, 389);
            this.Controls.Add(this.tempPictureBox);
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GraphEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Сделайте пометки на изображении";
            this.Load += new System.EventHandler(this.GraphEditor_Load);
            this.Enter += new System.EventHandler(this.GraphEditor_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GraphEditor_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog ToolsColorDialog;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.PictureBox tempPictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripFigure;
        private System.Windows.Forms.ToolStripMenuItem toolStripColor;
        private System.Windows.Forms.ToolStripComboBox toolStripSize;
        private System.Windows.Forms.ToolStripMenuItem toolStripSave;
        private System.Windows.Forms.ToolStripMenuItem ToolStripCancel;
        private System.Windows.Forms.ToolStripMenuItem отменаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструментToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маркерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem карандашToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem линияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem прямоугольникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окружностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ластикToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem толщинаЛинииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
    }
}