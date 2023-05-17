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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetSize();
            WhiteBoard();
        }
           
        private ArrayPoints arraypoints = new ArrayPoints(2);

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            graphics.Clear(pictureBox1.BackColor);
            pictureBox1.Image = map;

        }

        
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
            if (!isMouse) { return;  }
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

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            eraser.Width = trackBar1.Value;
            pen.Width = trackBar1.Value;
        }

       

        private void pngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pngSave();
        }

        private void jpgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jpgSave();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
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
        private void pictureBox5_Click(object sender, EventArgs e)
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

        private void тёмнаяToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void светлаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            menuStrip1.BackColor = Color.Silver;
            panel1.BackColor = Color.White;
            flowLayoutPanel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.Silver;
            panel4.BackColor = Color.Silver;
            panel5.BackColor = Color.Silver;
            panel6.BackColor = Color.Silver; 
        }
    }
}
