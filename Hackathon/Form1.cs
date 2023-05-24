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
        private Form2 window = new Form2();

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
                Thread t = new Thread(() => create());
                t.Start();
                window.ShowDialog();
                t.Join();
                

            }
            catch (Exception xe)
            {
                Console.WriteLine(xe.Message);
            }
        }

        private void create()
        {
            ConcurrentQueue<int> buffer = new ConcurrentQueue<int>();
            while(true)
            {
                for (int i = 0; i < this.numbakers; i++)
                {
                    Thread baker = new Thread(() => produce(buffer));
                    baker.Start();
                }
                for (int i = 0; i < this.numcustomers; i++)
                {
                    Thread customer = new Thread(() => consume(buffer));
                    customer.Start();
                }
            }


        }
        private object bufferLock = new object();
        private void produce(ConcurrentQueue<int> buffer)
        {
            Thread.Sleep(this.bakerate);
            Random r = new Random();
            int num = r.Next(1, 11);

            lock (bufferLock)
            {
                buffer.Enqueue(num);
                window.ShowCake(num);
            }
            

        }

        private void consume(ConcurrentQueue<int> buffer)
        {
            Thread.Sleep(this.customerate);
            lock (bufferLock)
            {
                if (buffer.TryDequeue(out int cake))
                {
                    if (window.checkCake(cake))
                        window.hideCake(cake);
                    else
                        buffer.Enqueue(cake);
                }
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