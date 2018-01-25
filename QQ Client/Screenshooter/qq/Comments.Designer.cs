namespace qq
{
    partial class Comments
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Comments = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_withoutComments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите комментарий, который будет добавлен к имени файла";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Comments
            // 
            this.txt_Comments.Location = new System.Drawing.Point(36, 80);
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(451, 20);
            this.txt_Comments.TabIndex = 1;
            // 
            // btn_Save
            // 
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Save.Location = new System.Drawing.Point(289, 124);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_withoutComments
            // 
            this.btn_withoutComments.Location = new System.Drawing.Point(370, 124);
            this.btn_withoutComments.Name = "btn_withoutComments";
            this.btn_withoutComments.Size = new System.Drawing.Size(117, 23);
            this.btn_withoutComments.TabIndex = 3;
            this.btn_withoutComments.Text = "Без комментария";
            this.btn_withoutComments.UseVisualStyleBackColor = true;
            this.btn_withoutComments.Click += new System.EventHandler(this.btn_withoutComments_Click);
            // 
            // Comments
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 159);
            this.Controls.Add(this.btn_withoutComments);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Comments);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Comments";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Комментарии";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Comments;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_withoutComments;
    }
}