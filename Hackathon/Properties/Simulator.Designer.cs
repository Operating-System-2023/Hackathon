namespace Hackathon.Properties
{
    partial class Simulator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1748, 134);
            panel1.TabIndex = 0;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.RosyBrown;
            label3.Location = new Point(194, 191);
            label3.Name = "label3";
            label3.Size = new Size(249, 53);
            label3.TabIndex = 1;
            label3.Text = "statistics";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.RosyBrown;
            label4.Location = new Point(1338, 191);
            label4.Name = "label4";
            label4.Size = new Size(193, 53);
            label4.TabIndex = 2;
            label4.Text = "bakery";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(110, 285);
            label1.Name = "label1";
            label1.Size = new Size(196, 32);
            label1.TabIndex = 3;
            label1.Text = "Time \\ clock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Perpetua Titling MT", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(110, 356);
            label5.Name = "label5";
            label5.Size = new Size(333, 32);
            label5.TabIndex = 4;
            label5.Text = "Percentage capacity";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Perpetua Titling MT", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(110, 436);
            label6.Name = "label6";
            label6.Size = new Size(371, 32);
            label6.TabIndex = 5;
            label6.Text = "How many are waiting";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Perpetua Titling MT", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(110, 515);
            label7.Name = "label7";
            label7.Size = new Size(343, 32);
            label7.TabIndex = 6;
            label7.Text = "average waiting time";
            // 
            // button1
            // 
            button1.BackColor = Color.LavenderBlush;
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(804, 621);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 7;
            button1.Text = "exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(520, 285);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(520, 356);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(520, 429);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(520, 508);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 39);
            textBox4.TabIndex = 11;
            // 
            // Simulator
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            ForeColor = Color.DimGray;
            Name = "Simulator";
            Size = new Size(1748, 969);
            Load += Simulator_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
