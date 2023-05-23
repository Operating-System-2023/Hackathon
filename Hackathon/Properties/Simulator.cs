using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon.Properties
{
    public partial class Simulator : UserControl
    {
        private Mutex lockObject = new Mutex();
        public Simulator()
        {
            InitializeComponent();
            Visible = true;

        }

        public void showProduce()
        {
            lockObject.WaitOne();
            if (!label1.Visible)
                label1.Visible = true;
            lockObject.ReleaseMutex();

        }

        public void showConsume()
        {
            if (label1.InvokeRequired)
            {
                label1.Invoke(new Action(() =>
                {
                    if (label1.Visible)
                        label1.Visible = false;
                }));
            }
            else
            {
                if (label1.Visible)
                    label1.Visible = false;
            }

        }

        private void Simulator_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
