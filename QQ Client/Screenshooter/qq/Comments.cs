using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qq
{
    public partial class Comments : Form
    {
        public string Result { set; get; }
        public Comments()
        {
            InitializeComponent();
            Result = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String comments="";
            comments = txt_Comments.Text.Trim();
            comments = comments.Replace(",", "");
            comments = comments.Replace("\\", "");
            comments = comments.Replace("/", "");
            comments = comments.Replace("*", "");
            comments = comments.Replace(".", "");
            comments = comments.Replace(":", "");
            comments = comments.Replace(";", "");
            comments = comments.Replace("\"", "");
            comments = comments.Replace("?", "");
            comments = comments.Replace("'", "");
            comments = comments.Replace("&", "");
            if (comments == "")
                MessageBox.Show("Введите комментарий или нажмите \"Без комментария\"", "Комментарий не внесен",MessageBoxButtons.OK);
            else
            {
                this.DialogResult = DialogResult.OK;
                Result = comments;
                this.Close();
            }
        }

        private void btn_withoutComments_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Result = "";
            this.Close();

        }
    }
}
