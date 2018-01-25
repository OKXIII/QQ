using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Bitmap bmpMain, bmpTemp, bmpScreen;
        Graphics grMain, grTemp, grScreen;
        private Point oldloc;
        private Point oldStart, oldEnd;
        private int locX=0, locY=0;
        private int oldlocX = 0, oldlocY = 0, oldlocRight=0, oldlocBottom=0;
        private Pen mainPen, eraserPen;
        private int mainDraw=1;
        private int mainDrawSize = 10;
        private Brush mainBrush;
        private int act;
        private Pen semiTransPen;
        public Form1()
        {
            InitializeComponent();
            eraserPen = new Pen(System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(128))));
            mainPen = new Pen(System.Drawing.Color.DarkGreen,mainDrawSize);
       //     mainPen = new Pen(Color.FromArgb(1, 0, 0, 255),5);
            semiTransPen = new Pen(Color.FromArgb(128, 0, 0, 255), 15);
            this.tempPictureBox.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(128)));
            this.mainPictureBox.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(128)));
           this.TransparencyKey = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(128)));
            bmpTemp = new Bitmap(this.tempPictureBox.Width, this.tempPictureBox.Height, PixelFormat.Format32bppRgb);
            bmpMain = new Bitmap(this.mainPictureBox.Width, this.mainPictureBox.Height, PixelFormat.Format32bppRgb);
  

           bmpMain.MakeTransparent();

          //  bmpTemp.MakeTransparent();
            act = 0;
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
         
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
//            if (act == 0) return;
////            bmpFull = bmpStart; 
//   //         grTemp= Graphics.FromImage(bmpTemp);
//            Pen mp = new Pen(System.Drawing.Color.DarkGreen);
//            grTemp.DrawLine(mp, oldloc, e.Location);
//           tempPictureBox.Image = bmpTemp;
//     //       grTemp.Dispose();
// //           tempPictureBox.Invalidate();
  

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
////            System.Threading.Thread.Sleep(1000);
// //           Pen mp = new Pen(System.Drawing.Color.Aqua);
//  //          grMain = Graphics.FromImage(bmpMain);
//   //         grMain.DrawLine(mp, oldloc, e.Location);
//   //         mainPictureBox.Image = bmpMain;
//   //         grMain.Dispose();
//   //         mainPictureBox.Invalidate();
//            act = 0;

         }

        private void tempPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void tempPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            oldloc = e.Location;
            oldStart = oldloc;
            oldEnd = oldloc;

            locX = e.Location.X;
            locY = e.Location.Y;
            oldlocX = locX;
            oldlocY = locY;
            //кнопка нажата
            act = 1;
   

        }

        private void tempPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (act == 0) return;
            bmpTemp= (System.Drawing.Bitmap) bmpMain.Clone();
            grTemp = Graphics.FromImage(bmpTemp);
            switch (mainDraw)
            {
                case 0:
//                    grTemp.DrawEllipse(eraserPen, oldlocBottom-5, oldlocY-5, oldlocRight - oldlocX, oldlocBottom - oldlocY);.
                    grTemp.CompositingMode = CompositingMode.SourceOver;
                    grTemp.CompositingQuality = CompositingQuality.GammaCorrected;
                    grTemp.FillEllipse(new SolidBrush(Color.FromArgb(128, 0, 0, 255)), e.Location.X - mainDrawSize / 2, e.Location.Y - mainDrawSize / 2, mainDrawSize, mainDrawSize);
                    grMain = Graphics.FromImage(bmpMain);
//                    grMain.DrawEllipse(mainPen, e.Location.X - mainDrawSize / 2, e.Location.Y - mainDrawSize / 2, mainDrawSize, mainDrawSize);
                    grMain.CompositingMode = CompositingMode.SourceOver;
                    grMain.CompositingQuality = CompositingQuality.GammaCorrected;
                    grMain.FillEllipse(new SolidBrush(Color.FromArgb(128, 0, 0, 255)), e.Location.X - mainDrawSize / 2, e.Location.Y - mainDrawSize / 2, mainDrawSize, mainDrawSize);

                    grMain.Dispose();
                     break;
                case 1:
                    grTemp.DrawLine(eraserPen, oldStart, oldEnd);
//                     grTemp.DrawLine(semiTransPen, oldStart, oldEnd);
                  grTemp.DrawLine(mainPen, oldloc, e.Location);
                    break;
                case 2:
                    grTemp.DrawRectangle(eraserPen, oldlocX, oldlocY, oldlocRight-oldlocX, oldlocBottom-oldlocY);
                    grTemp.DrawRectangle(mainPen, locX, locY, e.Location.X - locX, e.Location.Y - locY); 
                    break;
                case 3:
                    grTemp.DrawEllipse(eraserPen, oldlocX, oldlocY, oldlocRight - oldlocX, oldlocBottom - oldlocY);
                    grTemp.DrawEllipse(mainPen, locX, locY, e.Location.X - locX, e.Location.Y - locY);
                    break;
            }
            oldStart = oldloc;
            oldEnd = e.Location;
            oldlocRight = e.Location.X;
            oldlocBottom = e.Location.Y;
            tempPictureBox.Image = bmpTemp;
            grTemp.Dispose();
            tempPictureBox.Invalidate();
  

        }

        private void tempPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            //кнопка отпущена
            act = 0;
            grMain = Graphics.FromImage(bmpMain);
            switch (mainDraw)
            {
                case 0:
                    grMain.DrawEllipse(mainPen, e.Location.X - mainDrawSize / 2, e.Location.Y - mainDrawSize / 2, mainDrawSize, mainDrawSize);
                    break;
                case 1:
                    grMain.DrawLine(semiTransPen, oldStart, oldEnd);
                    break;
                case 2:
                    grMain.DrawRectangle(mainPen, locX, locY, e.Location.X - locX, e.Location.Y - locY);
                    break;
                case 3:
                    grMain.DrawEllipse(mainPen, locX, locY, e.Location.X - locX, e.Location.Y - locY);
                    break;
            }
            locX = 0;
            locY = 0;
            oldlocX = 0;
            oldlocY = 0;
            oldlocRight = 0;
            oldlocBottom = 0;
            grMain.Dispose();
            tempPictureBox.Image = bmpMain; 
            mainPictureBox.Invalidate();

        

        }

        private void tempPictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
      //      grScreen = Graphics.FromImage(bmpTemp);
      //      grScreen.CopyFromScreen(e.Location.X, e.Location.Y, 0, 0, tempPictureBox.Size);
      ////      bmpTemp = (System.Drawing.Bitmap)bmpScreen.Clone();
      //      grScreen.Dispose();
//            Graphics gr = Graphics.FromImage(bmpMain);
////            PaintEventArgs gr = new PaintEventArgs(gra, new Rectangle(0, 0, 10, 10));
//            Bitmap bitmap = new Bitmap("C:\\Users\\K.Ovchinnikov\\Pictures\\Screenshots\\20150619\\qq_201506191817.Jpeg");
//            gr.DrawImage(bitmap, 10, 5, bitmap.Width, bitmap.Height);

//            Pen opaquePen = new Pen(Color.FromArgb(255, 0, 0, 255), 15);
//            Pen semiTransPen = new Pen(Color.FromArgb(128, 0, 0, 255), 15);

//            gr.DrawLine(opaquePen, 0, 20, 100, 20);
//            gr.DrawLine(semiTransPen, 0, 40, 100, 40);

//            gr.CompositingQuality = CompositingQuality.GammaCorrected;
//            gr.DrawLine(semiTransPen, 0, 60, 100, 60);


            //grScreen = Graphics.FromImage(bmpScreen);
            //grScreen.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height), CopyPixelOperation.SourceCopy);
            //grFull.DrawImage(bmpScreen, 0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grScreen = Graphics.FromImage(bmpTemp);
            grScreen.CopyFromScreen(tempPictureBox.Left, tempPictureBox.Top, 0, 0, tempPictureBox.Size);
            grScreen.DrawImage(bmpTemp, 0, 0,tempPictureBox.Width, tempPictureBox.Height);
            tempPictureBox.Image = bmpTemp;
            mainPictureBox.Image = bmpTemp;
            bmpMain = (System.Drawing.Bitmap)bmpTemp;
            //      bmpTemp = (System.Drawing.Bitmap)bmpScreen.Clone();
            grScreen.Dispose();
        }


    }
}
