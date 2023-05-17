using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class SuperPaint : Form
    {
        public SuperPaint()
        {
            InitializeComponent();
            SetSize();
            WhiteBoard();
        }
           
        private ArrayPoints arraypoints = new ArrayPoints(2);

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
                isMouse = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse= false;
            arraypoints.ResetPoints();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouse) { return; }
            arraypoints.SetPoint(e.X, e.Y);

            if (index == 1)
            {

                if (arraypoints.GetCountPoints() >= 2)
                {
                    graphics.DrawLines(pen, arraypoints.GetPoints());
                    pictureBox1.Image = map;
                    arraypoints.SetPoint(e.X, e.Y);

                }
            }

            if (index == 2)
            {
                if (arraypoints.GetCountPoints() >= 2)
                {
                    graphics.DrawLines(eraser, arraypoints.GetPoints());
                    pictureBox1.Image = map;
                    arraypoints.SetPoint(e.X, e.Y);
                }
            }
        }
        private void rjButton1_Click(object sender, EventArgs e)
        {
            pen.Color = ((RJButton)sender).BackColor;
            pictureBox2.BackColor = ((RJButton)sender).BackColor;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                ((PictureBox)sender).BackColor = colorDialog1.Color;
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ClearDesk();
        }
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            ValueChange();
        }

        private void pngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pngSave();
        }

        private void jpgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jpgSave();
        }
        private void тёмнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlackTheme();
        }

        private void светлаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WhiteTheme();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Brush();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Eraser();
        }
        


























































        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
