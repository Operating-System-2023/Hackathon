namespace Hackathon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numBakers = new TextBox();
            numCustomers = new TextBox();
            bakerRate = new TextBox();
            customerRate = new TextBox();
            start = new Button();
            panel3 = new Panel();
            simulator1 = new Properties.Simulator();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(1680, 141);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(578, 11);
            label1.Name = "label1";
            label1.Size = new Size(559, 124);
            label1.TabIndex = 0;
            label1.Text = "Patisserie";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1162, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(461, 493);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 231);
            label2.Name = "label2";
            label2.Size = new Size(427, 53);
            label2.TabIndex = 3;
            label2.Text = "Number of Bakers";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 325);
            label3.Name = "label3";
            label3.Size = new Size(508, 53);
            label3.TabIndex = 4;
            label3.Text = "Number of Customers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 422);
            label4.Name = "label4";
            label4.Size = new Size(298, 53);
            label4.TabIndex = 5;
            label4.Text = "Bakers rate";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 518);
            label5.Name = "label5";
            label5.Size = new Size(379, 53);
            label5.TabIndex = 6;
            label5.Text = "Customers Rate";
            // 
            // numBakers
            // 
            numBakers.Location = new Point(668, 231);
            numBakers.Name = "numBakers";
            numBakers.Size = new Size(319, 61);
            numBakers.TabIndex = 7;
            numBakers.TextChanged += numBakers_TextChanged;
            // 
            // numCustomers
            // 
            numCustomers.Location = new Point(668, 325);
            numCustomers.Name = "numCustomers";
            numCustomers.Size = new Size(319, 61);
            numCustomers.TabIndex = 8;
            // 
            // bakerRate
            // 
            bakerRate.Location = new Point(668, 422);
            bakerRate.Name = "bakerRate";
            bakerRate.Size = new Size(319, 61);
            bakerRate.TabIndex = 9;
            // 
            // customerRate
            // 
            customerRate.Location = new Point(668, 518);
            customerRate.Name = "customerRate";
            customerRate.Size = new Size(319, 61);
            customerRate.TabIndex = 10;
            // 
            // start
            // 
            start.BackColor = Color.White;
            start.FlatAppearance.MouseOverBackColor = Color.LightGray;
            start.Location = new Point(369, 39);
            start.Name = "start";
            start.Size = new Size(294, 99);
            start.TabIndex = 0;
            start.Text = "start";
            start.UseVisualStyleBackColor = false;
            start.Click += start_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RosyBrown;
            panel3.Controls.Add(simulator1);
            panel3.Controls.Add(start);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 641);
            panel3.Name = "panel3";
            panel3.Size = new Size(1680, 215);
            panel3.TabIndex = 2;
            // 
            // simulator1
            // 
            simulator1.AutoSize = true;
            simulator1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            simulator1.AutoValidate = AutoValidate.EnableAllowFocusChange;
            simulator1.ForeColor = Color.DimGray;
            simulator1.Location = new Point(0, 0);
            simulator1.Margin = new Padding(0);
            simulator1.Name = "simulator1";
            simulator1.Size = new Size(3545, 1186);
            simulator1.TabIndex = 1;
            simulator1.Visible = false;
            simulator1.Load += simulator1_Load;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1680, 60);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1680, 856);
            Controls.Add(customerRate);
            Controls.Add(bakerRate);
            Controls.Add(numCustomers);
            Controls.Add(numBakers);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Showcard Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button start;
        private Label label5;
        private TextBox numBakers;
        private TextBox numCustomers;
        private TextBox bakerRate;
        private TextBox customerRate;
        private Properties.Simulator simulator1;
    }
}