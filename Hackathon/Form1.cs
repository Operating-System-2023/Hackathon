using Hackathon.Properties;
using System.Collections.Concurrent;
using System.Windows.Forms;



namespace Hackathon
{
    public partial class Form1 : Form
    {
        private int numbakers;
        private int numcustomers;
        private int bakerate;
        private int customerate;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numBakers_TextChanged(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            try
            {
                numbakers = int.Parse(numBakers.Text);
                numcustomers = int.Parse(numCustomers.Text);
                bakerate = int.Parse(bakerRate.Text);
                customerate = int.Parse(customerRate.Text);
                Form2 window = new Form2(numbakers,numcustomers,bakerate,customerate);
                Thread show = new Thread(() => window.ShowDialog());
                show.Start();
            }
            catch (Exception xe)
            {
                Console.WriteLine(xe.Message);
            }
        }

        

        private void simulator1_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}