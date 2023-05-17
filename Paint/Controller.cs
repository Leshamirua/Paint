using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class SuperPaint 
    {
        Int32 index = 1;
        Bitmap map = new Bitmap(100, 100);
        Graphics graphics;
        Pen pen = new Pen(Color.Black, 3f);
        Pen eraser = new Pen(Color.White, 30f);
        private PictureBox previousPictureBox;
        private bool isMouse = false;
        public void WhiteBoard()
        {
            graphics.Clear(pictureBox1.BackColor);
            pictureBox1.Image = map;
        }
        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            eraser.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            eraser.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        public void pngSave()
        {
            saveFileDialog1.Filter = "PNG(*.PNG)|*.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName);
                }
            }
        }
        public void jpgSave() 
        {
            saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName);
                }
            }
        }
        
        public void BlackTheme()
        {
            this.BackColor = Color.Gray;
            menuStrip1.BackColor = Color.Black;
            menuStrip1.ForeColor = Color.White;
            panel1.BackColor = Color.Gray;
            flowLayoutPanel1.BackColor = Color.Gray;
            panel2.BackColor = Color.Gray;
            panel3.BackColor = Color.Black;
            panel4.BackColor = Color.Black;
            panel5.BackColor = Color.Black;
            panel6.BackColor = Color.Black;
        }
        public void WhiteTheme()
        {
            this.BackColor = Color.White;
            menuStrip1.BackColor = Color.Silver;
            menuStrip1.ForeColor = Color.Black;
            panel1.BackColor = Color.White;
            flowLayoutPanel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.Gainsboro;
            panel4.BackColor = Color.Gainsboro;
            panel5.BackColor = Color.Gainsboro;
            panel6.BackColor = Color.Gainsboro;
        }
        public void Brush()
        {
            if (previousPictureBox != null)
            {
                previousPictureBox.BackColor = Color.Transparent;
                previousPictureBox.BorderStyle = BorderStyle.None;
            }

            index = 1;
            pictureBox3.BackColor = Color.WhiteSmoke;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;

            previousPictureBox = pictureBox3;
        }
        public void Eraser()
        {
            if (previousPictureBox != null)
            {
                previousPictureBox.BackColor = Color.Transparent;
                previousPictureBox.BorderStyle = BorderStyle.None;
            }

            index = 2;
            pictureBox5.BackColor = Color.WhiteSmoke;
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;

            previousPictureBox = pictureBox5;
        }
        public void ValueChange()
        {
            eraser.Width = trackBar1.Value;
            pen.Width = trackBar1.Value;
        }
        public void ClearDesk()
        {
            graphics.Clear(pictureBox1.BackColor);
            pictureBox1.Image = map;
        }
    }
   
}
