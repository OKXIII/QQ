using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace qq
{
    static class Screenshot
    {
        [DllImport("user32.dll")]
        static extern int GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(int hWnd, StringBuilder text, int count);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hWnd, out Rectangle lpRect);

        [DllImport("user32.dll", SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        public static RECT Rect;

    
        
        // Скриншот всего экрана
        public static Bitmap ImageFromScreen()
        {
            Graphics gr;
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height,
                PixelFormat.Format32bppRgb);
            gr = Graphics.FromImage(bmp);
            gr.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y,
                0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
            return bmp;
        }

        public static Size GetSizeAllScreens()
        {
            int screenWidth=0, screenHeight=0;
            int countScreens=0;
            countScreens=Screen.AllScreens.Count();
            for (int i=0; i<countScreens; i++)
            {
                screenWidth=screenWidth+Screen.AllScreens[i].Bounds.Width;
                if (Screen.AllScreens[i].Bounds.Height > screenHeight) screenHeight = Screen.AllScreens[i].Bounds.Height;
            }
            return new Size(screenWidth, screenHeight);
        }



        //Снимок со всех экранов
        public static Bitmap ImageFromAllScreens()
        {
            Graphics grScreen, grFull;
            int screenWidth = 0, screenHeight = 0, screenX = 0;
            int countScreens=0;
            countScreens=Screen.AllScreens.Count();
            for (int i=0; i<countScreens; i++)
            {
                screenWidth=screenWidth+Screen.AllScreens[i].Bounds.Width;
                if (Screen.AllScreens[i].Bounds.Height > screenHeight) screenHeight = Screen.AllScreens[i].Bounds.Height;
            }

            Bitmap bmpFull = new Bitmap(screenWidth, screenHeight, PixelFormat.Format32bppRgb);
            grFull = Graphics.FromImage(bmpFull);
            Bitmap bmpScreen;
            //записываем скриншот с PrimaryScreen
            bmpScreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppRgb);
            grScreen = Graphics.FromImage(bmpScreen);
            grScreen.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height), CopyPixelOperation.SourceCopy);
            grFull.DrawImage(bmpScreen, 0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            screenX = Screen.PrimaryScreen.Bounds.Width;
            // дополняем изображение остальными экранами
            for (int i = 0; i < countScreens; i++)
            {
                if (!Screen.AllScreens[i].Primary)
                {
                    bmpScreen = new Bitmap(Screen.AllScreens[i].Bounds.Width, Screen.AllScreens[i].Bounds.Height, PixelFormat.Format32bppRgb);
                    grScreen = Graphics.FromImage(bmpScreen);
                    grScreen.CopyFromScreen(Screen.AllScreens[i].Bounds.X, Screen.AllScreens[i].Bounds.Y, 0, 0, new Size(Screen.AllScreens[i].Bounds.Width, Screen.AllScreens[i].Bounds.Height), CopyPixelOperation.SourceCopy);
                    grFull.DrawImage(bmpScreen, screenX, 0, Screen.AllScreens[i].Bounds.Width, Screen.AllScreens[i].Bounds.Height);
                    screenX = Screen.AllScreens[i].Bounds.Width;

                }
            }

            
            
            return bmpFull;
        }



        public static Bitmap ImageFromScreenXY(int locLeft, int locTop, int locRight, int locBottom)
        {
            Graphics gr;
            int Temp;
            if (locRight < locLeft) { Temp = locLeft; locLeft = locRight; locRight = Temp; }
            if (locBottom < locTop) { Temp = locTop; locTop = locBottom; locBottom = Temp; }
            if (locRight == locLeft) locRight++;
            if (locBottom == locTop) locBottom++;
            Bitmap bmp = new Bitmap(locRight-locLeft, locBottom-locTop, PixelFormat.Format32bppRgb);
            gr = Graphics.FromImage(bmp);
            gr.CopyFromScreen(locLeft, locTop, 0, 0, new Size(locRight-locLeft,locBottom-locTop), CopyPixelOperation.SourceCopy);
            return bmp;
        }



        //Получение заголовка активного окна
        public static string GetActiveWindowCaption()
        {
            const int nChars = 256;
            int handle = 0;
            StringBuilder Buff = new StringBuilder(nChars);
            handle = GetForegroundWindow();
            GetWindowText(handle, Buff, nChars);
//            if (GetWindowText(handle, Buff, nChars) > 0)
//            {
//                MessageBox.Show("Buff.ToString()=" + Buff.ToString() + " handle.ToString()=" + handle.ToString());
 //           }
            return Buff.ToString();
        }

        //получение координат активного окна
        public static RECT GetActiveWindowRect()
        {
            //    Rectangle rect = new Rectangle();
            IntPtr handle;
            handle = (IntPtr)GetForegroundWindow();
            RECT rect;
            GetWindowRect(handle, out rect);
            return rect;
        }


        public static string SaveImageToFolder(PictureBox picbox, Bitmap bmp)
        {
            picbox.Image = null;
            picbox.Image = bmp;
            string filename = "";
            filename = GetFileName(Properties.Settings.Default.FilenameTemplate);
            if (File.Exists(filename + "." + Properties.Settings.Default.FileFormat.ToString()))
            {
                filename = filename + DateTime.Now.ToString("ss") + "." + Properties.Settings.Default.FileFormat.ToString();
            }
            else
            {
                filename = filename + "." + Properties.Settings.Default.FileFormat.ToString();
                               
            }

            //System.Drawing.Imaging.ImageFormat.Png
            //    ImageFormat 
            picbox.Image.Tag = "QQ";
    //        MessageBox.Show( picbox.Image.PropertyItems.ToString());
            picbox.Image.Save(filename, Properties.Settings.Default.FileFormat);
   //     Image image = Image.FromFile(filename);

   //     PropertyItem pi= image.GetPropertyItem()
   
   //     pi.Id = 37510;

   //     pi.Type = 1;
   //     pi.Value = Encoding.UTF8.GetBytes("MyImageInfo");
   //     pi.Len = pi.Value.Length;
   //     image.SetPropertyItem(pi);
   ////     image.Save();
   //     image.Save(filename);


            return filename;
        }

        public static string SaveImage(PictureBox picbox, Bitmap img)
        {
            string filename="";
            switch (Properties.Settings.Default.Storage)
            {   
                case 1:
                   filename=ScreenPaste.PostingServices.PostToImgur(img);
                    break;
                case 4:
                    filename = ScreenPaste.PostingServices.PostToQQ(img);
                    break;
//                default:
//                   filename = SaveImageToFolder(picbox, img);
//                    break;
            }
            if (filename == "")
            {
                filename = SaveImageToFolder(picbox, img);
            }
            Clipboard.SetText(filename);
            Clipboard.SetImage(img);
            return filename;
        }

        public static void Notify(NotifyIcon notifyIcon1, string filename, int actiontype)
        {
            switch (actiontype)
            {
                case 1:
                    notifyIcon1.BalloonTipTitle = "Сохранение";
                    notifyIcon1.BalloonTipText = "Сохраняется скриншот..." + filename;
                    break;
                case 2:
                    notifyIcon1.BalloonTipTitle = "Скриншот сохранен";
                    notifyIcon1.BalloonTipText = "Скриншот сохранен " + filename;
                    break;
            }
            notifyIcon1.ShowBalloonTip(60);
        }

        public static string GetFolderName()
        {
            string result = "";
            result = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (Properties.Settings.Default.Storage == 2)
            {
                switch (Properties.Settings.Default.DefinedFolder)
                {
                    case 0:
                        result = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        break;
                    case 1:
                        result = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                        break;
                    case 2:
                        result = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        break;
                 }
            }
            if (Properties.Settings.Default.Storage == 3)
            {
                result = Properties.Settings.Default.TargetFolder;
            }
            return result;
        }


        public static string GetFileName(string filenameTemplate)
        {
            string result = "";
            string stringreplace = "";
            //формирование полного имени файла
            result = filenameTemplate;
            if (result.Trim() == "")
            {
                result = "[FolderScreenshots]\\qq_[Date YYYYMMDD][Time HHMM]";
            }
            result=result.Replace("[FolderScreenshots]","Screenshots");
            stringreplace = Environment.UserName.ToString();
            result = result.Replace("[FolderUserName]", stringreplace);
            result = result.Replace("[UserName]", stringreplace);
            stringreplace = Environment.UserDomainName.ToString();
            result = result.Replace("[DomainUserName]", stringreplace);
            result = result.Replace("[FolderDomainUserName]", stringreplace);
            stringreplace = Environment.MachineName.ToString();
            result = result.Replace("[FolderComputerName]", stringreplace);
            result = result.Replace("[ComputerName]", stringreplace);

            stringreplace=GetActiveWindowCaption();
            result = result.Replace("[FolderAppName]", stringreplace);
            result = result.Replace("[AppName]", stringreplace);
            //Придумать как сделать нумератор
            result = result.Replace("[Numerator]", "");
            result = result.Replace("[FolderDate]", DateTime.Now.ToString("yyyyMMdd"));
            result = result.Replace("[Date YYYY-MM-DD]", DateTime.Now.ToString("yyyy-MM-dd"));
            result = result.Replace("[Date YYYYMMDD]", DateTime.Now.ToString("yyyyMMdd"));
            result = result.Replace("[Date DD-MM-YYYY]", DateTime.Now.ToString("dd-MM-yyyy"));
            result = result.Replace("[Time HH-MM]", DateTime.Now.ToString("HH-mm"));
            result = result.Replace("[Time MM-HH]", DateTime.Now.ToString("mm-HH"));
            result = result.Replace("[Time HHMM]", DateTime.Now.ToString("HHmm"));
            if ((Properties.Settings.Default.FileDescription == true) && ((Properties.Settings.Default.Storage == 2) || (Properties.Settings.Default.Storage == 3)))
            {
                Comments frm = new Comments();
                if ((frm.ShowDialog() == DialogResult.OK) && (frm.Result.Trim() != ""))
                {
                    result = result.Replace("[Comments]", frm.Result);
                }
            }
            result = result.Replace("[Comments]", "");
            result = GetFolderName() + "\\" + result + "@";
            //проверка наличия всех папок
            string foldername = "";
            string filename="";
            string[] split = result.Split(new Char[] { '\\' });
            foreach (string s in split) 
            {
                if (s.Trim() != "")
                {
                    if (foldername != "") foldername += "\\";
                    if (s.Substring(s.Length-1, 1)!= "@")
                    {
                        foldername += s;
                        Trace.WriteLine("foldername=" + foldername);
                    }
                    else
                    {
                        filename=s.Substring(0,s.Length-1);
                    }
                }
                if (!Directory.Exists(foldername))
                {
                    DirectoryInfo di = Directory.CreateDirectory(foldername);
                    if (di.Exists) Trace.WriteLine(foldername + "создано");
                } 
                else
                {
                    Trace.WriteLine(foldername + "-существует");

                }
            }
            //проверка наличия файла с таким же именем
            result = foldername + filename;
            //Trace.WriteLine("полное имя файла " + result);
            return result;
        }
    
    }
}
