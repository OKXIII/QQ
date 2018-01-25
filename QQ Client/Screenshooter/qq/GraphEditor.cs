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
using System.Runtime.InteropServices;


namespace qq
{
   
    public partial class GraphEditor : Form
    {
        public Bitmap img;

        Tool tool;
        private Bitmap bmpMain, bmpTemp;
        private struct geLocation
        {
            public int left;
            public int right;
            public int top;
            public int bottom;
        }

        private geLocation imgLoc, imgLocOld;
        private Pen mainPen, eraserPen, markerPen;
        private bool keydown = false;
        private Graphics grMain, grTemp;
        private CtrlZ HistoryImages = new CtrlZ(10);

        public GraphEditor()
        {
            InitializeComponent();
            tool = new Tool();
   
            eraserPen = new Pen(System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(128))));
            mainPen = new Pen(tool.ToolColor, tool.ToolSize);
            markerPen = new Pen(Color.FromArgb( 128, tool.ToolColor), tool.ToolSize*4);
            this.tempPictureBox.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(128)));
            this.mainPictureBox.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(128)));
         //   this.TransparencyKey = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(128)));
            bmpTemp = new Bitmap(this.tempPictureBox.Width, this.tempPictureBox.Height, PixelFormat.Format32bppRgb);
            bmpMain = new Bitmap(this.mainPictureBox.Width, this.mainPictureBox.Height, PixelFormat.Format32bppRgb);
            bmpMain.MakeTransparent();
            keydown = false;
        }
        
        private void GraphEditor_Load(object sender, EventArgs e)
        {

            tempPictureBox.Width = Screenshot.Rect.Right - Screenshot.Rect.Left;
            tempPictureBox.Height = Screenshot.Rect.Bottom - Screenshot.Rect.Top;

            mainPictureBox.Width = Screenshot.Rect.Right - Screenshot.Rect.Left;
            mainPictureBox.Height = Screenshot.Rect.Bottom - Screenshot.Rect.Top;

            toolStripFigure.Visible = true;
            if (Properties.Settings.Default.ToolsDefaultFigure == 0)
            { tool.ToolFigure = Figure.Marker; toolStripFigure.SelectedIndex = 0; }
            else 
            { 
                toolStripFigure.SelectedIndex = Properties.Settings.Default.ToolsDefaultFigure;
                toolStripFigure_SelectedIndexChanged (sender,e);
            }
            toolStripColor.Visible = true;
            if (Properties.Settings.Default.ToolsDefaultColor == Color.Empty)
            { toolStripColor.BackColor = System.Drawing.Color.Fuchsia; tool.ToolColor = toolStripColor.BackColor; }
            else 
            { 
                toolStripColor.BackColor = Properties.Settings.Default.ToolsDefaultColor;
                tool.ToolColor = toolStripColor.BackColor;
            }
            toolStripSize.Visible = true;
            if (Properties.Settings.Default.ToolsDefaultSize == 0)
            { toolStripSize.SelectedIndex = 2; tool.ToolSize = 8; }
            else
            {
                toolStripSize.SelectedIndex = Properties.Settings.Default.ToolsDefaultSize;
                tool.ToolSize = Convert.ToInt32(toolStripSize.SelectedItem);
            }

            tempPictureBox.Image = img;
            mainPictureBox.Image = img;
            bmpTemp = img;
            bmpMain = img;
            bmpMain = (System.Drawing.Bitmap)bmpTemp;
            tempPictureBox.Invalidate();
            toolStripFigure.Visible = false;
            toolStripSize.Visible = false;
        }

        private void GraphEditor_Enter(object sender, EventArgs e)
        {

        }

        private void GraphEditor_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 13:
                    this.DialogResult = DialogResult.OK;
                    SaveSettings();

                    this.Close();
                    break;
                case 27:
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                    break;
            }
        }

        private void btnToolsColor_Click(object sender, EventArgs e)
        {
            ColorDialog DlgColor = new ColorDialog();
            DlgColor.Color = toolStripColor.BackColor;
            if (DlgColor.ShowDialog() == DialogResult.OK)
            {
                toolStripColor.BackColor = DlgColor.Color;
                tool.ToolColor = DlgColor.Color;
            }

        }

        
        private void ToolsFigure_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ToolsPen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tool.ToolSize = Convert.ToInt32(toolStripSize.SelectedItem);
        }

        private void tempPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            imgLoc.left = e.Location.X;
            imgLoc.top = e.Location.Y;
            imgLocOld.left = e.Location.X;
            imgLocOld.top = e.Location.Y;
            mainPen = new Pen(tool.ToolColor, tool.ToolSize);
            markerPen = new Pen(Color.FromArgb(10, tool.ToolColor), tool.ToolSize);
            markerPen.Width=25;
             keydown = true;
             HistoryImages.Add(bmpMain);
        }

        private void tempPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!keydown) return;
            bmpTemp = (System.Drawing.Bitmap)bmpMain.Clone();
            grTemp = Graphics.FromImage(bmpTemp);
            switch (tool.ToolFigure)
            {
                case Figure.Pencil:
                    grTemp.FillEllipse(new SolidBrush(tool.ToolColor), e.Location.X - tool.ToolSize / 2, e.Location.Y - tool.ToolSize / 2, tool.ToolSize, tool.ToolSize);
                    grMain = Graphics.FromImage(bmpMain);
                    grMain.FillEllipse(new SolidBrush(tool.ToolColor), e.Location.X - tool.ToolSize / 2, e.Location.Y - tool.ToolSize / 2, tool.ToolSize, tool.ToolSize);
                    grMain.Dispose();
                    break;
                case Figure.Marker:
                    grTemp.DrawLine(markerPen, e.Location.X, e.Location.Y - tool.ToolSize, e.Location.X, e.Location.Y + tool.ToolSize);
                    grMain = Graphics.FromImage(bmpMain);
                    grMain.DrawLine(markerPen, e.Location.X, e.Location.Y - tool.ToolSize, e.Location.X, e.Location.Y + tool.ToolSize);
                    grMain.Dispose();
                    break;
                case Figure.Line:
  //                   grTemp.DrawLine(eraserPen, imgLocOld.left, imgLocOld.top, imgLocOld.right, imgLocOld.bottom);
                    grTemp.DrawLine(mainPen, imgLocOld.left,imgLocOld.top, e.Location.X, e.Location.Y);
                    break;
                case Figure.Rectangle:
   //                 grTemp.DrawRectangle(eraserPen, imgLocOld.left, imgLocOld.top, imgLocOld.right-imgLocOld.left, imgLocOld.bottom-imgLocOld.top);
                    grTemp.DrawRectangle(mainPen, imgLoc.left, imgLoc.top, e.Location.X - imgLoc.left, e.Location.Y - imgLoc.top); 
                    break;
                case Figure.Ellipse:
    //                grTemp.DrawEllipse(eraserPen, imgLocOld.left, imgLocOld.top, imgLocOld.right-imgLocOld.left, imgLocOld.bottom-imgLocOld.top);
                    grTemp.DrawEllipse(mainPen, imgLoc.left, imgLoc.top, e.Location.X - imgLoc.left, e.Location.Y - imgLoc.top); 
                    break;
                case Figure.Eraser:
                    //grTemp.FillEllipse(new SolidBrush(Color.White), e.Location.X - tool.ToolSize , e.Location.Y - tool.ToolSize , tool.ToolSize, tool.ToolSize);
                    //grMain = Graphics.FromImage(bmpMain);
                    //grMain.FillEllipse(new SolidBrush(Color.White), e.Location.X - tool.ToolSize , e.Location.Y - tool.ToolSize , tool.ToolSize, tool.ToolSize);
                    //grMain.Dispose();
                    eraserPen = new Pen(Color.FromArgb(100, Color.White), tool.ToolSize);
                     eraserPen.Width = 10;

                     grTemp.DrawEllipse(eraserPen, e.Location.X - tool.ToolSize/2, e.Location.Y - tool.ToolSize/2,  tool.ToolSize, tool.ToolSize);
                    grMain = Graphics.FromImage(bmpMain);
                    grMain.DrawEllipse(eraserPen, e.Location.X - tool.ToolSize/2, e.Location.Y - tool.ToolSize/2,  tool.ToolSize,  tool.ToolSize);
                    grMain.Dispose();
                    break;
            }
            imgLocOld.left = imgLoc.left;
            imgLocOld.right = e.Location.X;
            imgLocOld.top = imgLoc.top;
            imgLocOld.bottom = e.Location.Y;
            tempPictureBox.Image = bmpTemp;
            grTemp.Dispose();
            tempPictureBox.Invalidate();
        }

        private void tempPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            keydown = false;
            grMain = Graphics.FromImage(bmpMain);
            switch (tool.ToolFigure)
            {
                case Figure.Pencil:
                    grMain.DrawEllipse(mainPen, e.Location.X - tool.ToolSize / 2, e.Location.Y - tool.ToolSize / 2, tool.ToolSize, tool.ToolSize);
                    break;
                case Figure.Marker:
  //                  grMain.DrawLine(markerPen, e.Location.X, e.Location.Y - tool.ToolSize , e.Location.X, e.Location.Y + tool.ToolSize );
                    break;

                case Figure.Line:
                    grMain.DrawLine(mainPen, imgLocOld.left, imgLocOld.top, e.Location.X, e.Location.Y);
                    break;
                case Figure.Rectangle:
                    grMain.DrawRectangle(mainPen, imgLoc.left, imgLoc.top, e.Location.X - imgLoc.left, e.Location.Y - imgLoc.top);
                    break;
                case Figure.Ellipse:
                    grMain.DrawEllipse(mainPen, imgLoc.left, imgLoc.top, e.Location.X - imgLoc.left, e.Location.Y - imgLoc.top);
                    break;
            }
            imgLoc.left = 0;
            imgLoc.top = 0;
            imgLocOld.left = 0;
            imgLocOld.top = 0;
            imgLocOld.right = 0;
            imgLocOld.bottom = 0;
            grMain.Dispose();
            tempPictureBox.Image = bmpMain;
            tempPictureBox.Invalidate();
            mainPictureBox.Image = bmpMain;
            mainPictureBox.Invalidate();

        }

        private void tempPictureBox_Click(object sender, EventArgs e)
        {
        }

        private void tempPictureBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
   
        }

        private void toolStripColor_Click(object sender, EventArgs e)
        {
            ColorDialog DlgColor = new ColorDialog();
            DlgColor.Color = toolStripColor.BackColor;
            if (DlgColor.ShowDialog() == DialogResult.OK)
            {
                toolStripColor.BackColor = DlgColor.Color;
                tool.ToolColor = DlgColor.Color;
 
            }
        }

        private void toolStripFigure_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (toolStripFigure.SelectedIndex)
            {
                case 0:
                    tool.ToolFigure = Figure.Marker;
                    break;
                case 1:
                    tool.ToolFigure = Figure.Pencil;
                    break;
                case 2:
                    tool.ToolFigure = Figure.Line;
                    break;
                case 3:
                    tool.ToolFigure = Figure.Rectangle;
                    break;
                case 4:
                    tool.ToolFigure = Figure.Ellipse;
                    break;
                case 5:
                    tool.ToolFigure = Figure.Eraser;
                    break;
            }
        }

        private void toolStripSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            tool.ToolSize = Convert.ToInt32(toolStripSize.SelectedItem);
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            SaveSettings();
            this.Close();
        }

        private void SaveSettings()
        {
            Properties.Settings.Default.ToolsDefaultFigure = toolStripFigure.SelectedIndex;
            Properties.Settings.Default.ToolsDefaultColor = toolStripColor.BackColor;
            Properties.Settings.Default.ToolsDefaultSize = Convert.ToInt32(toolStripSize.SelectedIndex);
        }

        private void ToolStripCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void toolStripFigure_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSize_Click(object sender, EventArgs e)
        {

        }

        private void btn_Undo_Click(object sender, EventArgs e)
        {
            //if (HistoryImages.Length() > 0)
            //{
            //    Bitmap bmpTmp = (System.Drawing.Bitmap)HistoryImages.Get().Clone();
            //    bmpMain = bmpTmp;
            //    tempPictureBox.Image = bmpTmp;
            //    tempPictureBox.Invalidate();
            //    mainPictureBox.Image = bmpTmp;
            //    mainPictureBox.Invalidate();
            //}
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void отменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HistoryImages.Length() > 0)
            {
                Bitmap bmpTmp = (System.Drawing.Bitmap)HistoryImages.Get().Clone();
                bmpMain = bmpTmp;
                tempPictureBox.Image = bmpTmp;
                tempPictureBox.Invalidate();
                mainPictureBox.Image = bmpTmp;
                mainPictureBox.Invalidate();
            }
        }

        private void маркерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tool.ToolFigure = Figure.Marker;
            маркерToolStripMenuItem.Checked = true;
            карандашToolStripMenuItem.Checked = false;
            линияToolStripMenuItem1.Checked = false;
            ластикToolStripMenuItem1.Checked = false;
            прямоугольникToolStripMenuItem.Checked = false;
            окружностьToolStripMenuItem.Checked = false;
        }

        private void карандашToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tool.ToolFigure = Figure.Pencil;
            маркерToolStripMenuItem.Checked = false;
            карандашToolStripMenuItem.Checked = true;
            линияToolStripMenuItem1.Checked = false;
            ластикToolStripMenuItem1.Checked = false;
            прямоугольникToolStripMenuItem.Checked = false;
            окружностьToolStripMenuItem.Checked = false;
        }

        private void линияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tool.ToolFigure = Figure.Line;
            маркерToolStripMenuItem.Checked = false;
            карандашToolStripMenuItem.Checked = false;
            линияToolStripMenuItem1.Checked = true;
            ластикToolStripMenuItem1.Checked = false;
            прямоугольникToolStripMenuItem.Checked = false;
            окружностьToolStripMenuItem.Checked = false;
        }

   
        private void ластикToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tool.ToolFigure = Figure.Eraser;
            маркерToolStripMenuItem.Checked = false;
            карандашToolStripMenuItem.Checked = false;
            линияToolStripMenuItem1.Checked = false;
            ластикToolStripMenuItem1.Checked = true;
            прямоугольникToolStripMenuItem.Checked = false;
            окружностьToolStripMenuItem.Checked = false;
        }

        private void прямоугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tool.ToolFigure = Figure.Rectangle;
            маркерToolStripMenuItem.Checked = false;
            карандашToolStripMenuItem.Checked = false;
            линияToolStripMenuItem1.Checked = false;
            ластикToolStripMenuItem1.Checked = false;
            прямоугольникToolStripMenuItem.Checked = true;
            окружностьToolStripMenuItem.Checked = false;
        }

        private void окружностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tool.ToolFigure = Figure.Ellipse;
            маркерToolStripMenuItem.Checked = false;
            карандашToolStripMenuItem.Checked = false;
            линияToolStripMenuItem1.Checked = false;
            ластикToolStripMenuItem1.Checked = false;
            прямоугольникToolStripMenuItem.Checked = false;
            окружностьToolStripMenuItem.Checked = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = true;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem7.Checked = false;
            tool.ToolSize = 2;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = true;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem7.Checked = false;
            tool.ToolSize = 4;

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = true;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem7.Checked = false;
            tool.ToolSize = 8;

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = true;
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem7.Checked = false;
            tool.ToolSize = 16;

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = true;
            toolStripMenuItem7.Checked = false;
            tool.ToolSize = 32;

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            toolStripMenuItem4.Checked = false;
            toolStripMenuItem5.Checked = false;
            toolStripMenuItem6.Checked = false;
            toolStripMenuItem7.Checked = true;
            tool.ToolSize = 64;
        }

        private void толщинаЛинииToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
     public enum Figure
    {
        Pencil=1,
        Marker=0,
        Line=2,
        Rectangle=3,
        Ellipse=4,
        Eraser=5


    }
    public class Tool
    {
        public Figure ToolFigure;
        public System.Drawing.Color ToolColor;
        public int ToolSize;
        public Tool()
        {
            ToolColor = Properties.Settings.Default.ToolsDefaultColor;
            ToolSize = Properties.Settings.Default.ToolsDefaultSize;
        }

        public Tool(Figure Figure, System.Drawing.Color Color, int Size)
        {
            ToolFigure = Figure;
            ToolColor = Color;
            ToolSize = Size;
        }

    }
}
