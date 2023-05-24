namespace Hackathon
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private object cake1Lock = new object();
        private object cake2Lock = new object();
        private object cake3Lock = new object();
        private object cake4Lock = new object();
        private object cake5Lock = new object();
        private object cake6Lock = new object();
        private object cake7Lock = new object();
        private object cake8Lock = new object();
        private object cake9Lock = new object();
        private object cake10Lock = new object();
        public void ShowCake(int index)
        {
            switch (index)
            {
                case 1:
                    ShowCakeConcurrent(cake1, cake1Lock);
                    break;
                case 2:
                    ShowCakeConcurrent(cake2, cake2Lock);
                    break;
                case 3:
                    ShowCakeConcurrent(cake3, cake3Lock);
                    break;
                case 4:
                    ShowCakeConcurrent(cake4, cake4Lock);
                    break;
                case 5:
                    ShowCakeConcurrent(cake5, cake5Lock);
                    break;
                case 6:
                    ShowCakeConcurrent(cake6, cake6Lock);
                    break;
                case 7:
                    ShowCakeConcurrent(cake7, cake7Lock);
                    break;
                case 8:
                    ShowCakeConcurrent(cake8, cake8Lock);
                    break;
                case 9:
                    ShowCakeConcurrent(cake9, cake9Lock);
                    break;
                case 10:
                    ShowCakeConcurrent(cake10, cake10Lock);
                    break;
                default:
                    break;
            }
        }

        private void ShowCakeConcurrent(PictureBox cake, object cakeLock)
        {
            bool lockTaken = false;
            try
            {
                Monitor.Enter(cakeLock, ref lockTaken);
                if (lockTaken)
                {
                    cake.Visible = true;
                }

            }
            catch (Exception e) { Console.WriteLine("BUG"); }
        }

        public void hideCake(int index)
        {
            switch (index)
            {
                case 1:
                    HideCakeConcurrent(cake1, cake1Lock);
                    break;
                case 2:
                    HideCakeConcurrent(cake2, cake2Lock);
                    break;
                case 3:
                    HideCakeConcurrent(cake3, cake3Lock);
                    break;
                case 4:
                    HideCakeConcurrent(cake4, cake4Lock);
                    break;
                case 5:
                    HideCakeConcurrent(cake5, cake5Lock);
                    break;
                case 6:
                    HideCakeConcurrent(cake6, cake6Lock);
                    break;
                case 7:
                    HideCakeConcurrent(cake7, cake7Lock);
                    break;
                case 8:
                    HideCakeConcurrent(cake8, cake8Lock);
                    break;
                case 9:
                    HideCakeConcurrent(cake9, cake9Lock);
                    break;
                case 10:
                    HideCakeConcurrent(cake10, cake10Lock);
                    break;
                default:
                    break;

            }
        }
        public Boolean checkCake(int index)
        {
            switch (index)
            {
                case 1:
                    return cake1.Visible;
                case 2:
                    return cake2.Visible;
                case 3:
                    return cake3.Visible;
                case 4:
                    return cake4.Visible;
                case 5:
                    return cake5.Visible;
                case 6:
                    return cake6.Visible;
                case 7:
                    return cake7.Visible;
                case 8:
                    return cake8.Visible;
                case 9:
                    return cake9.Visible;
                case 10:
                    return cake10.Visible;
                default:
                    break;

            }
            return false;
        }



        private void HideCakeConcurrent(PictureBox cake, object cakeLock)
        {
            bool lockTaken = false;
            try
            {
                Monitor.Enter(cakeLock, ref lockTaken);
                if (lockTaken)
                {
                    cake.Visible = false;
                }

            }
            catch (Exception e) { Console.WriteLine("BUG"); }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            fileSystemWatcher1 = new FileSystemWatcher();
            cake9 = new PictureBox();
            cake8 = new PictureBox();
            cake7 = new PictureBox();
            cake10 = new PictureBox();
            cake6 = new PictureBox();
            cake5 = new PictureBox();
            cake4 = new PictureBox();
            cake3 = new PictureBox();
            cake2 = new PictureBox();
            cake1 = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cake9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cake8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cake7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cake10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cake6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cake5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cake4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cake3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cake2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cake1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // cake9
            // 
            cake9.Image = (Image)resources.GetObject("cake9.Image");
            cake9.Location = new Point(1240, 599);
            cake9.Name = "cake9";
            cake9.Size = new Size(200, 100);
            cake9.SizeMode = PictureBoxSizeMode.StretchImage;
            cake9.TabIndex = 45;
            cake9.TabStop = false;
            cake9.Visible = false;
            // 
            // cake8
            // 
            cake8.Image = (Image)resources.GetObject("cake8.Image");
            cake8.Location = new Point(1002, 599);
            cake8.Name = "cake8";
            cake8.Size = new Size(146, 100);
            cake8.SizeMode = PictureBoxSizeMode.StretchImage;
            cake8.TabIndex = 44;
            cake8.TabStop = false;
            cake8.Visible = false;
            // 
            // cake7
            // 
            cake7.Image = (Image)resources.GetObject("cake7.Image");
            cake7.Location = new Point(1488, 479);
            cake7.Name = "cake7";
            cake7.Size = new Size(146, 84);
            cake7.SizeMode = PictureBoxSizeMode.StretchImage;
            cake7.TabIndex = 43;
            cake7.TabStop = false;
            cake7.Visible = false;
            // 
            // cake10
            // 
            cake10.Image = (Image)resources.GetObject("cake10.Image");
            cake10.Location = new Point(1512, 578);
            cake10.Name = "cake10";
            cake10.Size = new Size(122, 135);
            cake10.SizeMode = PictureBoxSizeMode.StretchImage;
            cake10.TabIndex = 42;
            cake10.TabStop = false;
            cake10.Visible = false;
            // 
            // cake6
            // 
            cake6.Image = (Image)resources.GetObject("cake6.Image");
            cake6.Location = new Point(1205, 463);
            cake6.Name = "cake6";
            cake6.Size = new Size(200, 100);
            cake6.SizeMode = PictureBoxSizeMode.StretchImage;
            cake6.TabIndex = 41;
            cake6.TabStop = false;
            cake6.Visible = false;
            // 
            // cake5
            // 
            cake5.Image = (Image)resources.GetObject("cake5.Image");
            cake5.Location = new Point(1014, 463);
            cake5.Name = "cake5";
            cake5.Size = new Size(144, 99);
            cake5.SizeMode = PictureBoxSizeMode.StretchImage;
            cake5.TabIndex = 40;
            cake5.TabStop = false;
            cake5.Visible = false;
            // 
            // cake4
            // 
            cake4.Image = (Image)resources.GetObject("cake4.Image");
            cake4.Location = new Point(1472, 319);
            cake4.Name = "cake4";
            cake4.Size = new Size(137, 107);
            cake4.SizeMode = PictureBoxSizeMode.StretchImage;
            cake4.TabIndex = 39;
            cake4.TabStop = false;
            cake4.Visible = false;
            // 
            // cake3
            // 
            cake3.Image = (Image)resources.GetObject("cake3.Image");
            cake3.Location = new Point(1311, 319);
            cake3.Name = "cake3";
            cake3.Size = new Size(139, 107);
            cake3.SizeMode = PictureBoxSizeMode.StretchImage;
            cake3.TabIndex = 38;
            cake3.TabStop = false;
            cake3.Visible = false;
            // 
            // cake2
            // 
            cake2.Image = (Image)resources.GetObject("cake2.Image");
            cake2.Location = new Point(1161, 319);
            cake2.Name = "cake2";
            cake2.Size = new Size(131, 107);
            cake2.SizeMode = PictureBoxSizeMode.StretchImage;
            cake2.TabIndex = 37;
            cake2.TabStop = false;
            cake2.Visible = false;
            // 
            // cake1
            // 
            cake1.BackColor = Color.Transparent;
            cake1.Image = (Image)resources.GetObject("cake1.Image");
            cake1.Location = new Point(1002, 319);
            cake1.Name = "cake1";
            cake1.Size = new Size(141, 107);
            cake1.SizeMode = PictureBoxSizeMode.StretchImage;
            cake1.TabIndex = 36;
            cake1.TabStop = false;
            cake1.Visible = false;
            cake1.Click += cake1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(982, 319);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(661, 420);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(520, 580);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 39);
            textBox4.TabIndex = 34;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(520, 428);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 32;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(520, 357);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 31;
            // 
            // button1
            // 
            button1.BackColor = Color.LavenderBlush;
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(780, 739);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 30;
            button1.Text = "exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Perpetua Titling MT", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(110, 587);
            label7.Name = "label7";
            label7.Size = new Size(343, 32);
            label7.TabIndex = 29;
            label7.Text = "average waiting time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Perpetua Titling MT", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(110, 508);
            label6.Name = "label6";
            label6.Size = new Size(371, 32);
            label6.TabIndex = 28;
            label6.Text = "How many are waiting";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Perpetua Titling MT", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(110, 428);
            label5.Name = "label5";
            label5.Size = new Size(333, 32);
            label5.TabIndex = 27;
            label5.Text = "Percentage capacity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(110, 357);
            label1.Name = "label1";
            label1.Size = new Size(196, 32);
            label1.TabIndex = 26;
            label1.Text = "Time \\ clock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.RosyBrown;
            label4.Location = new Point(1240, 236);
            label4.Name = "label4";
            label4.Size = new Size(193, 53);
            label4.TabIndex = 25;
            label4.Text = "bakery";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.RosyBrown;
            label3.Location = new Point(194, 236);
            label3.Name = "label3";
            label3.Size = new Size(249, 53);
            label3.TabIndex = 24;
            label3.Text = "statistics";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lucida Calligraphy", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(629, 23);
            label2.Name = "label2";
            label2.Size = new Size(549, 124);
            label2.TabIndex = 1;
            label2.Text = "Patisserie";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(520, 501);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 33;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1680, 134);
            panel1.TabIndex = 23;
            // 
            // Form2
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1680, 856);
            Controls.Add(cake9);
            Controls.Add(cake8);
            Controls.Add(cake7);
            Controls.Add(cake10);
            Controls.Add(cake6);
            Controls.Add(cake5);
            Controls.Add(cake4);
            Controls.Add(cake3);
            Controls.Add(cake2);
            Controls.Add(cake1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cake9).EndInit();
            ((System.ComponentModel.ISupportInitialize)cake8).EndInit();
            ((System.ComponentModel.ISupportInitialize)cake7).EndInit();
            ((System.ComponentModel.ISupportInitialize)cake10).EndInit();
            ((System.ComponentModel.ISupportInitialize)cake6).EndInit();
            ((System.ComponentModel.ISupportInitialize)cake5).EndInit();
            ((System.ComponentModel.ISupportInitialize)cake4).EndInit();
            ((System.ComponentModel.ISupportInitialize)cake3).EndInit();
            ((System.ComponentModel.ISupportInitialize)cake2).EndInit();
            ((System.ComponentModel.ISupportInitialize)cake1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private PictureBox cake9;
        private PictureBox cake8;
        private PictureBox cake7;
        private PictureBox cake10;
        private PictureBox cake6;
        private PictureBox cake5;
        private PictureBox cake4;
        private PictureBox cake3;
        private PictureBox cake2;
        private PictureBox cake1;
        private PictureBox pictureBox1;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox textBox3;
        private Panel panel1;
        private Label label2;
    }
}