using Hackathon.Properties;
using System.Collections.Concurrent;

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
                
                Controls.Add(simulator1);
                simulator1.Visible = true;
                create();

            }
            catch (Exception xe)
            {
                Console.WriteLine(xe.Message);
            }
        }

        private void create()
        {
            Thread[] arrayThreads = new Thread[this.numbakers + this.numcustomers];
            ConcurrentQueue<String> buffer = new ConcurrentQueue<String>();
            for (int i = 0; i < this.numbakers; i++)
            {
                arrayThreads[i] = new Thread(() => produce(buffer));
                arrayThreads[i].Start();
            }
            for (int i = this.numbakers; i < arrayThreads.Length; i++)
            {
                arrayThreads[i] = new Thread(() => consume(buffer));
                arrayThreads[i].Start();
            }
            for (int i = 0; i < arrayThreads.Length; i++)
            {
                arrayThreads[i].Join();
            }
            Console.WriteLine("END");


        }

        private void produce(ConcurrentQueue<String> buffer)
        {
            Thread.Sleep(this.bakerate);
            simulator1.showProduce();
            Random r = new Random();
            int num = r.Next(1,11);
            buffer.Enqueue("cake"+num);

        }

        private void consume(ConcurrentQueue<String> buffer)
        {
            Thread.Sleep(this.customerate);
            String cake= String.Empty;
            if (buffer.TryDequeue(out cake))
                simulator1.showConsume();

        }

        private void simulator1_Load(object sender, EventArgs e)
        {

        }
    }
}