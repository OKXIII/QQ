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
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;



namespace qq
{
    public partial class Qq : Form
    {
        const int WM_HOTKEY = 0x0312;
        public Qq()
        {
            InitializeComponent();
            notifyIcon1.Visible = true;
            this.ShowInTaskbar = false;
 //           this.notifyIcon1.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick);
           this.notifyIcon1.MouseClick += new MouseEventHandler(notifyIcon1_MouseClick);
 //           this.Resize += new System.EventHandler(this.Qq_Resize);
           this.Text = "Кукушка - Делаю снимки экрана " + this.ProductVersion;
           this.notifyIcon1.Text = this.Text;

        }

       protected override void WndProc ( ref Message m ) 
        {
//            if ((m.Msg==WM_HOTKEY) && (m.WParam.ToInt32()>0)) //== HotKeyId) 
//           {
//               MessageBox.Show("Lparam=" + m.LParam + "Wparam" + m.WParam);
//    //            MessageBox.Show("Msg=" + m.Msg);
////                Debug.Print("Msg=" + m.Msg);
////               Console.WriteLine("Msg=" + m.Msg);
//           }
////            if (m.WParam.ToInt32() > 0)  MessageBox.Show(m.LParam.ToString());

            if ((m.Msg == WM_HOTKEY) && (m.WParam.ToInt32() > 0))
           {

                switch( m.LParam.ToInt32())
                {
                        
                    case 2883588: //Shift+PrintScreen
                        PrintScreenFullWindow();
                        break;
                    case 2883586:  //Ctrl+PrintScreen
                        PrintScreenSelected();
                        break;
                    case 2883585: //Alt+PrintScreen
                      PrintScreenActiveWindow();
                      break;
                    case 2883590 : //Ctrl+Shift+PrintScreen
                      break;
                    //case 2883591: //Shift+Alt+PrintScreen
                      //  break;
                }
           }
            base.WndProc(ref m);
        }


       public void PrintScreenFullWindow()
       {
           Bitmap img;
           string filename;
           img = Screenshot.ImageFromScreen();
           Clipboard.SetImage(img); 
  //         filename = Screenshot.SaveImageToFolder(pictureBox1, img);
           Screenshot.Notify(notifyIcon1, "", 1);
           filename = Screenshot.SaveImage(pictureBox1, img);
           Screenshot.Notify(notifyIcon1, filename,2);
        }


       public void PrintAllScreensFullWindow()
       {
           Bitmap img;
           string filename;
           img = Screenshot.ImageFromAllScreens();
           Clipboard.SetImage(img);
           //         filename = Screenshot.SaveImageToFolder(pictureBox1, img);
           Screenshot.Notify(notifyIcon1, "", 1);
           filename = Screenshot.SaveImage(pictureBox1, img);
           Screenshot.Notify(notifyIcon1, filename, 2);
       }

       public void PrintScreenActiveWindow()
       {
           Screenshot.RECT rect;
           Bitmap img;
           string filename;
           rect = Screenshot.GetActiveWindowRect();
           img = Screenshot.ImageFromScreenXY(rect.Left, rect.Top, rect.Right, rect.Bottom);
           Clipboard.SetImage(img);
           Screenshot.Notify(notifyIcon1, "", 1);
           filename = Screenshot.SaveImage(pictureBox1, img);
           Screenshot.Notify(notifyIcon1, filename,2);
       }

       public void PrintScreenSelected()
       {
           formScreenShort frm = new formScreenShort();
//           frm.Size = Screen.PrimaryScreen.Bounds.Size;
           frm.Size = Screenshot.GetSizeAllScreens();
           frm.ShowDialog();
           if (frm.Result != -1)
           {

               Bitmap img;
               string filename;
               img = Screenshot.ImageFromScreenXY(Screenshot.Rect.Left, Screenshot.Rect.Top, Screenshot.Rect.Right, Screenshot.Rect.Bottom);
               if (Properties.Settings.Default.GraphEditor) 
               {
                   if (CallGraphEditor(img) == DialogResult.Cancel) { return;  }
               }
               Clipboard.SetImage(img);
               Screenshot.Notify(notifyIcon1, "", 1);
               filename = Screenshot.SaveImage(pictureBox1, img);
               Screenshot.Notify(notifyIcon1, filename, 2);
           }
        }

       private DialogResult CallGraphEditor(Bitmap img)
       {
           GraphEditor frmGE = new GraphEditor();
           //frmGE.Size = Screenshot.GetSizeAllScreens();
           //frmGE.Left = Screenshot.Rect.Left;
           //frmGE.Top = Screenshot.Rect.Top - 46;
           if (Screenshot.Rect.Right - Screenshot.Rect.Left+30 > 700)
           {
               frmGE.Width = Screenshot.Rect.Right - Screenshot.Rect.Left+30;
           }
           else { frmGE.Width = 700; }
           if (Screenshot.Rect.Bottom - Screenshot.Rect.Top + 100 > 300)
           {
               frmGE.Height = Screenshot.Rect.Bottom - Screenshot.Rect.Top + 100;
           }
           else { frmGE.Height = 300; }
           frmGE.img = img;
           return frmGE.ShowDialog();
       }
    
       public void PrintScreenSelectedActiveWindow()
       {
  //         Screenshot.RECT rect;
           Bitmap img;
           string filename;
           Screenshot.Rect = Screenshot.GetActiveWindowRect();
           formScreenShort frm = new formScreenShort();
           frm.Size = Screen.PrimaryScreen.Bounds.Size;
           frm.ShowDialog();
           img = Screenshot.ImageFromScreenXY(Screenshot.Rect.Left, Screenshot.Rect.Top, Screenshot.Rect.Right, Screenshot.Rect.Bottom);
           Clipboard.SetImage(img);
           Screenshot.Notify(notifyIcon1, "", 1);
           filename = Screenshot.SaveImage(pictureBox1, img);
           Screenshot.Notify(notifyIcon1, filename,2);
       }
    
       public int HotKeyId { get; set; }

        private void Qq_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            this.Visible = false;
            notifyIcon1.Visible = true;
            //вынести класс работы с настройками
            flgAutostart.Checked = Properties.Settings.Default.Autorun;
            TargetFolder.Text=Properties.Settings.Default.TargetFolder ;
            if (Properties.Settings.Default.Storage ==1 ) radioButton1.Checked=true;
            if (Properties.Settings.Default.Storage == 2)
            {
                radioButton2.Checked=true;
                comboBox1.SelectedIndex=Properties.Settings.Default.DefinedFolder;
            }
            if (Properties.Settings.Default.Storage == 3) { radioButton3.Checked=true ; }
            if (Properties.Settings.Default.Storage == 4) radioButton4.Checked = true; 
            filenameTemplate.Text = Properties.Settings.Default.FilenameTemplate;
            cbFileformat.Items.Add(System.Drawing.Imaging.ImageFormat.Bmp);
            cbFileformat.Items.Add(System.Drawing.Imaging.ImageFormat.Jpeg);
            cbFileformat.Items.Add(System.Drawing.Imaging.ImageFormat.Png);
            cbFileformat.Items.Add(System.Drawing.Imaging.ImageFormat.Tiff);
            cbFileformat.SelectedItem= Properties.Settings.Default.FileFormat;

 

            if (cbFileformat.SelectedIndex == -1) 
                cbFileformat.SelectedItem = System.Drawing.Imaging.ImageFormat.Jpeg;
            if (radioButton3.Checked && TargetFolder.Text.Trim() == "") radioButton2.Checked = true;
            if (comboBox1.SelectedIndex==-1)
                comboBox1.SelectedIndex = 1;
            if (filenameTemplate.Text.Trim() == "") filenameTemplate.Text = "[FolderScreenshots]\\[FolderDate]\\qq_[Date YYYYMMDD][Time HHMM][Numerator]";
            if (Properties.Settings.Default.FileDescription) FileDescription.Checked = true;
            if (Properties.Settings.Default.GraphEditor) GraphEditor.Checked = true; 
            SaveSettings();
     
        
        }

        private void Qq_Resize(object sender, EventArgs e)
        {
         
  
          
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

              if (e.Button == MouseButtons.Left)
              {
                  this.Visible = true;
                    this.Opacity = 100;
                }
            
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
                this.ShowInTaskbar = false;
            }
            if (e.Button == MouseButtons.Left)
            {
                contextMenuStrip1.Visible = false;
            }
        }

        
        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.Opacity = 100;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {

            System.Environment.Exit(0);        
        }

        private void Qq_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel=true;
            this.Visible = false;
            this.Opacity = 0;

        }
                      
      

        private void Qq_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
          if (e.Button == MouseButtons.Left)
           {
   //             pictureBox1.Image = ImageFromScreenXY();
    //            pictureBox1.Image.Save(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\qw_" + System.DateTime.Now.Year.ToString() + System.DateTime.Now.Month.ToString() + System.DateTime.Now.Day.ToString() + System.DateTime.Now.Hour.ToString() + System.DateTime.Now.Minute.ToString() + System.DateTime.Now.Second.ToString() + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
  
            }
  //            MessageBox.Show("MouseDown");
        }

        private void скриншотВыделеннойОбластиCtrlPrntScrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintScreenSelected();
        }

        private void скриншотАктивногоОкнаAltPrntScrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintScreenActiveWindow();
        }

        private void скриншотВсегоЭкранаPrintScrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintScreenFullWindow();
        }



                       
        private void btnFolderBrowser_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            TargetFolder.Text = folderBrowserDialog1.SelectedPath;
        }

     

        public bool SetAutorunValue(bool autorun)
        {
            string name = "QQ";
            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {
                if (autorun)
                    reg.SetValue(name, ExePath);
                else
                    reg.DeleteValue(name);
 
                reg.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void SaveSettings()
        {
            if (flgAutostart.Checked)
            {
                SetAutorunValue(true);
            }
            else
            {
                SetAutorunValue(false);
            }
            Properties.Settings.Default.Autorun = flgAutostart.Checked;
            if (radioButton1.Checked) { Properties.Settings.Default.Storage = 1; }
            if (radioButton2.Checked)
            {
                Properties.Settings.Default.Storage = 2;
                Properties.Settings.Default.DefinedFolder = (byte)comboBox1.SelectedIndex;
            }
            if (radioButton3.Checked && TargetFolder.Text != "")
            {
                Properties.Settings.Default.Storage = 3;
                Properties.Settings.Default.TargetFolder = TargetFolder.Text;
            }
            if (radioButton3.Checked && TargetFolder.Text == "")
            {
                radioButton3.Checked = true;
                if (comboBox1.SelectedIndex == -1) comboBox1.SelectedIndex = 0;
            }
            if (radioButton4.Checked) { Properties.Settings.Default.Storage = 4; }
            Properties.Settings.Default.FilenameTemplate = filenameTemplate.Text;
            Properties.Settings.Default.FileFormat = (System.Drawing.Imaging.ImageFormat)cbFileformat.SelectedItem;
            Properties.Settings.Default.FileDescription = FileDescription.Checked;
            Properties.Settings.Default.GraphEditor = GraphEditor.Checked;
            Properties.Settings.Default.Save();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SaveSettings();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (Properties.Settings.Default.Storage == 1) m_Saveto_Imgur.Checked = true; else m_Saveto_Imgur.Checked = false;
            if ((Properties.Settings.Default.Storage == 2)||(Properties.Settings.Default.Storage == 3)) m_SavetoFolder.Checked = true; else m_SavetoFolder.Checked = false;
            if (Properties.Settings.Default.Storage == 4) m_SavetoQQ.Checked = true; else m_SavetoQQ.Checked = false;
            if (Properties.Settings.Default.FileDescription) m_Comments.Checked = true; else m_Comments.Checked = false;
            if (Properties.Settings.Default.GraphEditor) m_Grapheditor.Checked = true; else m_Grapheditor.Checked = false;

        }

        private void открытьПапкуСоСкриншотамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string foldername = "";
            foldername = Screenshot.GetFolderName();
            System.Diagnostics.Process.Start("explorer", foldername);
        }


        private void btnAddTemplate_Click(object sender, EventArgs e)
        {
            string SelectedTemplate = filenameTemplate.Text;
            switch (Templates.SelectedIndex)
            { 
                case 0:
                    SelectedTemplate += "[FolderScreenshots]\\";
                    break;
                case 1:
                    SelectedTemplate += "[FolderUserName]\\";
                    break;
                case 2:
                    SelectedTemplate += "[FolderDomainUserName]\\";
                    break;
                case 3:
                    SelectedTemplate += "[FolderComputerName]\\";
                    break;
                case 4:
                    SelectedTemplate += "[FolderDate]\\";
                    break;
                case 5:
                    SelectedTemplate += "[FolderAppName]\\";
                    break;
                case 6:
                    SelectedTemplate += "[UserName]";
                    break;
                case 7:
                    SelectedTemplate += "[DomainUserName]";
                    break;
                case 8:
                    SelectedTemplate += "[ComputerName]";
                    break;
                case 9:
                    SelectedTemplate += "[Date YYYY-MM-DD]";
                    break;
                case 10:
                    SelectedTemplate += "[Date YYYYMMDD]";
                    break;
                case 11:
                    SelectedTemplate += "[Date DD-MM-YYYY]";
                    break;
                case 12:
                    SelectedTemplate += "[Time HH-MM]";
                    break;
                case 13:
                    SelectedTemplate += "[Time MM-HH]";
                    break;
                case 14:
                    SelectedTemplate += "[Time HHMM]";
                    break;
                case 15:
                    SelectedTemplate += "[AppName]";
                    break;
                case 16:
                    SelectedTemplate += "[Numerator]";
                    break;
                case 17:
                    SelectedTemplate += "[Comments]";
                    break;
            }
            filenameTemplate.Text=SelectedTemplate;
            Templates.SelectedIndex = -1;
        }

        private void Templates_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClearFilenameTemplate_Click(object sender, EventArgs e)
        {
            filenameTemplate.Text = "";
        }

        private void btnDefaulSettings_Click(object sender, EventArgs e)
        {
            flgAutostart.Checked = true;
            comboBox1.SelectedIndex = 1;
            radioButton2.Checked = true;
            filenameTemplate.Text = "[FolderScreenshots]\\[FolderDate]\\[qq_[Date YYYYMMDD][Time HHMM]_[Comments]_[Numerator]";
            cbFileformat.SelectedItem = System.Drawing.Imaging.ImageFormat.Jpeg;
            FileDescription.Checked=false;
            GraphEditor.Checked = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void снимокВсехЭкрановToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintAllScreensFullWindow();
        }


        private void m_Comments_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FileDescription=m_Comments.Checked ;
            this.FileDescription.Checked = m_Comments.Checked;
            SaveSettings();
        }

        private void m_Grapheditor_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.GraphEditor=m_Grapheditor.Checked ;
            this.GraphEditor.Checked = m_Grapheditor.Checked;
            SaveSettings();
        }

        private void m_Saveto_Imgur_Click(object sender, EventArgs e)
        {
            if (m_Saveto_Imgur.Checked)
            {
                m_SavetoFolder.Checked = false;
                m_SavetoQQ.Checked = false;
                Properties.Settings.Default.Storage = 1;
            }
            this.radioButton1.Checked = m_Saveto_Imgur.Checked;
            SaveSettings();
        }

        private void m_SavetoQQ_Click(object sender, EventArgs e)
        {
            if (m_SavetoQQ.Checked)
            { 
                m_Saveto_Imgur.Checked =false;
                m_SavetoFolder.Checked =false;
                Properties.Settings.Default.Storage = 4;
            }
            this.radioButton4.Checked = m_SavetoQQ.Checked;
            SaveSettings();

        }

        private void m_SavetoFolder_Click(object sender, EventArgs e)
        {
            if (m_SavetoFolder.Checked)
            {
                m_Saveto_Imgur.Checked = false;
                m_SavetoQQ.Checked = false;
                Properties.Settings.Default.Storage = 2;
            }
            this.radioButton2.Checked = m_SavetoFolder.Checked;
            SaveSettings();

        }

         
    }
}


