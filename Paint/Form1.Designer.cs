namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.темаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тёмнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.светлаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синяяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.краснаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rjButton5 = new CustomControls.RJControls.RJButton();
            this.rjButton8 = new CustomControls.RJControls.RJButton();
            this.rjButton9 = new CustomControls.RJControls.RJButton();
            this.rjButton6 = new CustomControls.RJControls.RJButton();
            this.rjButton10 = new CustomControls.RJControls.RJButton();
            this.rjButton12 = new CustomControls.RJControls.RJButton();
            this.rjButton11 = new CustomControls.RJControls.RJButton();
            this.rjButton7 = new CustomControls.RJControls.RJButton();
            this.rjButton4 = new CustomControls.RJControls.RJButton();
            this.rjButton3 = new CustomControls.RJControls.RJButton();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.видToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.темаToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // темаToolStripMenuItem
            // 
            this.темаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тёмнаяToolStripMenuItem,
            this.светлаяToolStripMenuItem,
            this.синяяToolStripMenuItem,
            this.краснаяToolStripMenuItem});
            this.темаToolStripMenuItem.Name = "темаToolStripMenuItem";
            this.темаToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.темаToolStripMenuItem.Text = "Тема";
            // 
            // тёмнаяToolStripMenuItem
            // 
            this.тёмнаяToolStripMenuItem.Name = "тёмнаяToolStripMenuItem";
            this.тёмнаяToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.тёмнаяToolStripMenuItem.Text = "Тёмная";
            // 
            // светлаяToolStripMenuItem
            // 
            this.светлаяToolStripMenuItem.Name = "светлаяToolStripMenuItem";
            this.светлаяToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.светлаяToolStripMenuItem.Text = "Светлая";
            // 
            // синяяToolStripMenuItem
            // 
            this.синяяToolStripMenuItem.Name = "синяяToolStripMenuItem";
            this.синяяToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.синяяToolStripMenuItem.Text = "Синяя";
            // 
            // краснаяToolStripMenuItem
            // 
            this.краснаяToolStripMenuItem.Name = "краснаяToolStripMenuItem";
            this.краснаяToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.краснаяToolStripMenuItem.Text = "Красная";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(200, 23);
            this.toolStripTextBox1.Text = "Кристина лучший преподаватель!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1064, 657);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.rjButton1);
            this.flowLayoutPanel1.Controls.Add(this.rjButton2);
            this.flowLayoutPanel1.Controls.Add(this.rjButton3);
            this.flowLayoutPanel1.Controls.Add(this.rjButton4);
            this.flowLayoutPanel1.Controls.Add(this.rjButton7);
            this.flowLayoutPanel1.Controls.Add(this.rjButton11);
            this.flowLayoutPanel1.Controls.Add(this.rjButton12);
            this.flowLayoutPanel1.Controls.Add(this.rjButton10);
            this.flowLayoutPanel1.Controls.Add(this.rjButton6);
            this.flowLayoutPanel1.Controls.Add(this.rjButton9);
            this.flowLayoutPanel1.Controls.Add(this.rjButton8);
            this.flowLayoutPanel1.Controls.Add(this.rjButton5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(279, 94);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // rjButton5
            // 
            this.rjButton5.BackColor = System.Drawing.Color.Cyan;
            this.rjButton5.BackgroundColor = System.Drawing.Color.Cyan;
            this.rjButton5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjButton5.BorderRadius = 20;
            this.rjButton5.BorderSize = 1;
            this.rjButton5.FlatAppearance.BorderSize = 0;
            this.rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton5.ForeColor = System.Drawing.Color.White;
            this.rjButton5.Location = new System.Drawing.Point(233, 49);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Size = new System.Drawing.Size(40, 40);
            this.rjButton5.TabIndex = 0;
            this.rjButton5.TextColor = System.Drawing.Color.White;
            this.rjButton5.UseVisualStyleBackColor = false;
            this.rjButton5.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton8
            // 
            this.rjButton8.BackColor = System.Drawing.Color.Blue;
            this.rjButton8.BackgroundColor = System.Drawing.Color.Blue;
            this.rjButton8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjButton8.BorderRadius = 20;
            this.rjButton8.BorderSize = 1;
            this.rjButton8.FlatAppearance.BorderSize = 0;
            this.rjButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton8.ForeColor = System.Drawing.Color.White;
            this.rjButton8.Location = new System.Drawing.Point(187, 49);
            this.rjButton8.Name = "rjButton8";
            this.rjButton8.Size = new System.Drawing.Size(40, 40);
            this.rjButton8.TabIndex = 0;
            this.rjButton8.TextColor = System.Drawing.Color.White;
            this.rjButton8.UseVisualStyleBackColor = false;
            this.rjButton8.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton9
            // 
            this.rjButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rjButton9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rjButton9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjButton9.BorderRadius = 20;
            this.rjButton9.BorderSize = 1;
            this.rjButton9.FlatAppearance.BorderSize = 0;
            this.rjButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton9.ForeColor = System.Drawing.Color.White;
            this.rjButton9.Location = new System.Drawing.Point(141, 49);
            this.rjButton9.Name = "rjButton9";
            this.rjButton9.Size = new System.Drawing.Size(40, 40);
            this.rjButton9.TabIndex = 0;
            this.rjButton9.TextColor = System.Drawing.Color.White;
            this.rjButton9.UseVisualStyleBackColor = false;
            this.rjButton9.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton6
            // 
            this.rjButton6.BackColor = System.Drawing.Color.Magenta;
            this.rjButton6.BackgroundColor = System.Drawing.Color.Magenta;
            this.rjButton6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjButton6.BorderRadius = 20;
            this.rjButton6.BorderSize = 1;
            this.rjButton6.FlatAppearance.BorderSize = 0;
            this.rjButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton6.ForeColor = System.Drawing.Color.White;
            this.rjButton6.Location = new System.Drawing.Point(95, 49);
            this.rjButton6.Name = "rjButton6";
            this.rjButton6.Size = new System.Drawing.Size(40, 40);
            this.rjButton6.TabIndex = 0;
            this.rjButton6.TextColor = System.Drawing.Color.White;
            this.rjButton6.UseVisualStyleBackColor = false;
            this.rjButton6.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton10
            // 
            this.rjButton10.BackColor = System.Drawing.Color.Gray;
            this.rjButton10.BackgroundColor = System.Drawing.Color.Gray;
            this.rjButton10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjButton10.BorderRadius = 20;
            this.rjButton10.BorderSize = 1;
            this.rjButton10.FlatAppearance.BorderSize = 0;
            this.rjButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton10.ForeColor = System.Drawing.Color.White;
            this.rjButton10.Location = new System.Drawing.Point(49, 49);
            this.rjButton10.Name = "rjButton10";
            this.rjButton10.Size = new System.Drawing.Size(40, 40);
            this.rjButton10.TabIndex = 0;
            this.rjButton10.TextColor = System.Drawing.Color.White;
            this.rjButton10.UseVisualStyleBackColor = false;
            this.rjButton10.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton12
            // 
            this.rjButton12.BackColor = System.Drawing.Color.White;
            this.rjButton12.BackgroundColor = System.Drawing.Color.White;
            this.rjButton12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjButton12.BorderRadius = 20;
            this.rjButton12.BorderSize = 1;
            this.rjButton12.FlatAppearance.BorderSize = 0;
            this.rjButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton12.ForeColor = System.Drawing.Color.White;
            this.rjButton12.Location = new System.Drawing.Point(3, 49);
            this.rjButton12.Name = "rjButton12";
            this.rjButton12.Size = new System.Drawing.Size(40, 40);
            this.rjButton12.TabIndex = 0;
            this.rjButton12.TextColor = System.Drawing.Color.White;
            this.rjButton12.UseVisualStyleBackColor = false;
            this.rjButton12.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton11
            // 
            this.rjButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rjButton11.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rjButton11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjButton11.BorderRadius = 20;
            this.rjButton11.BorderSize = 1;
            this.rjButton11.FlatAppearance.BorderSize = 0;
            this.rjButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton11.ForeColor = System.Drawing.Color.White;
            this.rjButton11.Location = new System.Drawing.Point(233, 3);
            this.rjButton11.Name = "rjButton11";
            this.rjButton11.Size = new System.Drawing.Size(40, 40);
            this.rjButton11.TabIndex = 0;
            this.rjButton11.TextColor = System.Drawing.Color.White;
            this.rjButton11.UseVisualStyleBackColor = false;
            this.rjButton11.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton7
            // 
            this.rjButton7.BackColor = System.Drawing.Color.Yellow;
            this.rjButton7.BackgroundColor = System.Drawing.Color.Yellow;
            this.rjButton7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjButton7.BorderRadius = 20;
            this.rjButton7.BorderSize = 1;
            this.rjButton7.FlatAppearance.BorderSize = 0;
            this.rjButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton7.ForeColor = System.Drawing.Color.White;
            this.rjButton7.Location = new System.Drawing.Point(187, 3);
            this.rjButton7.Name = "rjButton7";
            this.rjButton7.Size = new System.Drawing.Size(40, 40);
            this.rjButton7.TabIndex = 0;
            this.rjButton7.TextColor = System.Drawing.Color.White;
            this.rjButton7.UseVisualStyleBackColor = false;
            this.rjButton7.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton4
            // 
            this.rjButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rjButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rjButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjButton4.BorderRadius = 20;
            this.rjButton4.BorderSize = 1;
            this.rjButton4.FlatAppearance.BorderSize = 0;
            this.rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton4.ForeColor = System.Drawing.Color.White;
            this.rjButton4.Location = new System.Drawing.Point(141, 3);
            this.rjButton4.Name = "rjButton4";
            this.rjButton4.Size = new System.Drawing.Size(40, 40);
            this.rjButton4.TabIndex = 0;
            this.rjButton4.TextColor = System.Drawing.Color.White;
            this.rjButton4.UseVisualStyleBackColor = false;
            this.rjButton4.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.Red;
            this.rjButton3.BackgroundColor = System.Drawing.Color.Red;
            this.rjButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjButton3.BorderRadius = 20;
            this.rjButton3.BorderSize = 1;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.ForeColor = System.Drawing.Color.White;
            this.rjButton3.Location = new System.Drawing.Point(95, 3);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(40, 40);
            this.rjButton3.TabIndex = 0;
            this.rjButton3.TextColor = System.Drawing.Color.White;
            this.rjButton3.UseVisualStyleBackColor = false;
            this.rjButton3.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.rjButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 1;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(49, 3);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(40, 40);
            this.rjButton2.TabIndex = 0;
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Black;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Black;
            this.rjButton1.BorderColor = System.Drawing.Color.Black;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 1;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(3, 3);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(40, 40);
            this.rjButton1.TabIndex = 0;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(279, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 94);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = global::Paint.Properties.Resources._51517;
            this.pictureBox4.Location = new System.Drawing.Point(357, 24);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.Image = global::Paint.Properties.Resources.artisticbrush_121592;
            this.pictureBox3.Location = new System.Drawing.Point(101, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Snow;
            this.trackBar1.Location = new System.Drawing.Point(152, 24);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(199, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::Paint.Properties.Resources.color_wheel1;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 94);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1064, 10);
            this.panel3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem темаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тёмнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem светлаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синяяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem краснаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton3;
        private CustomControls.RJControls.RJButton rjButton4;
        private CustomControls.RJControls.RJButton rjButton7;
        private CustomControls.RJControls.RJButton rjButton11;
        private CustomControls.RJControls.RJButton rjButton12;
        private CustomControls.RJControls.RJButton rjButton10;
        private CustomControls.RJControls.RJButton rjButton6;
        private CustomControls.RJControls.RJButton rjButton9;
        private CustomControls.RJControls.RJButton rjButton8;
        private CustomControls.RJControls.RJButton rjButton5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

