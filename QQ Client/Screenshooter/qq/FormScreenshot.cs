using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qq
{
    public partial class formScreenShort : Form
    {

        public int locationX = 0, locationY = 0;
        private bool MouseD = false;
        public int Result { set; get; }
        public formScreenShort()
        {
            InitializeComponent();
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(
                ((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(128)));
            this.TransparencyKey = System.Drawing.Color.FromArgb(
                ((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(128)));
        }

          
        private void formScreenShort_MouseDown(object sender, MouseEventArgs e)
        {
            this.pictureBox1.Visible = true;
            this.pictureBox1.Location = new Point(e.X, e.Y);
            this.pictureBox1.Size = new Size(0,0);
            locationX = e.X;
            locationY = e.Y;
            MouseD = true;
  
        }

        private void formScreenShort_MouseMove(object sender, MouseEventArgs e)
        {
            if ((MouseD)&&(locationX<e.X)&&(locationY<e.Y))
            {
                this.pictureBox1.Size = new Size(e.X - locationX, e.Y - locationY);
            }

        }

        private void formScreenShort_MouseUp(object sender, MouseEventArgs e)
        {

 
            Screenshot.Rect.Left = pictureBox1.Location.X;
            Screenshot.Rect.Top = pictureBox1.Location.Y;
            Screenshot.Rect.Right = e.X;
            Screenshot.Rect.Bottom= e.Y;
            Result = 1;
            this.Close();

        }

        private void formScreenShort_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                Result = -1;
                this.Close();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

    }
}
