namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.tempPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.mainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPictureBox.Location = new System.Drawing.Point(0, 0);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(927, 438);
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            this.mainPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.mainPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.mainPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // tempPictureBox
            // 
            this.tempPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.tempPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tempPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.tempPictureBox.Location = new System.Drawing.Point(0, 0);
            this.tempPictureBox.Name = "tempPictureBox";
            this.tempPictureBox.Size = new System.Drawing.Size(796, 338);
            this.tempPictureBox.TabIndex = 1;
            this.tempPictureBox.TabStop = false;
            this.tempPictureBox.Click += new System.EventHandler(this.tempPictureBox_Click);
            this.tempPictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tempPictureBox_MouseDoubleClick);
            this.tempPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tempPictureBox_MouseDown);
            this.tempPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tempPictureBox_MouseMove);
            this.tempPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tempPictureBox_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 438);
            this.Controls.Add(this.tempPictureBox);
            this.Controls.Add(this.mainPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.PictureBox tempPictureBox;
    }
}

