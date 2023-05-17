using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 
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
        private void FloodFill(Bitmap bitmap, Point pt, Color targetColor, Color replacementColor)
        {
            Stack<Point> pixels = new Stack<Point>();

            targetColor = bitmap.GetPixel(pt.X, pt.Y);
            pixels.Push(pt);

            while (pixels.Count != 0)
            {
                Point a = pixels.Pop();
                if (a.X < bitmap.Width && a.X > 0 &&
                        a.Y < bitmap.Height && a.Y > 0)
                {
                    if (bitmap.GetPixel(a.X, a.Y) == targetColor)
                    {
                        bitmap.SetPixel(a.X, a.Y, replacementColor);
                        pixels.Push(new Point(a.X - 1, a.Y));
                        pixels.Push(new Point(a.X + 1, a.Y));
                        pixels.Push(new Point(a.X, a.Y - 1));
                        pixels.Push(new Point(a.X, a.Y + 1));
                    }
                }
            }

            pictureBox1.Refresh();
        }
    }
    

    internal class Controller
    {

    }
}
