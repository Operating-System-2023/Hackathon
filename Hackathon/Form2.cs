using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hackathon
{
    public partial class Form2 : Form
    {
        private DateTime startTime;
        private int numbakers;
        private int numcustomers;
        private int bakerate;
        private int customerate;
        public int cakesVisible;
        public int waitingNum;
        public int inProcess;
        public int currentHide;
        public int preHide;
        public int sum = 0;
        public int count = 0;

        public Form2(int numB, int numC, int rateB, int rateC)
        {
            this.numbakers = numB;
            this.numcustomers = numC;
            this.bakerate = rateB;
            this.customerate = rateC;

            InitializeComponent();
            startTime = DateTime.Now;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Thread toCreate = new Thread(() => this.create());
            toCreate.Start();
        }

        public void create()
        {

            ConcurrentQueue<int> buffer = new ConcurrentQueue<int>();

            while (true)
            {
                if (waitingNum <= 0)
                    waitingNum = numcustomers;
                for (int i = 0; i < this.numbakers; i++)
                {
                    ThreadPool.QueueUserWorkItem(state => produce(buffer));
                }
                for (int i = 0; i < this.numcustomers; i++)
                {
                    ThreadPool.QueueUserWorkItem(state => consume(buffer));
                }
            }

        }
        private object bufferLock = new object();
        private void produce(ConcurrentQueue<int> buffer)
        {
            updateInprocess();
            Thread.Sleep(this.bakerate);
            bool lockTaken = false;
            try
            {
                Random r = new Random();
                int num = r.Next(1, 11);
                Monitor.Enter(bufferLock, ref lockTaken);
                if (lockTaken)
                {
                    buffer.Enqueue(num);
                    ShowCake(num);

                }
                Monitor.Exit(bufferLock);

            }
            catch (Exception e) { Console.WriteLine("BUG"); }

        }

        private void consume(ConcurrentQueue<int> buffer)
        {
            Thread.Sleep(this.customerate);
            bool lockTaken = false;
            try
            {
                Monitor.Enter(bufferLock, ref lockTaken);
                if (buffer.TryDequeue(out int cake))
                {
                    if (checkCake(cake))
                        hideCake(cake);
                    
                    else
                        buffer.Enqueue(cake);
                }
                Monitor.Exit(bufferLock);

            }
            catch (Exception e) { Console.WriteLine("BUG"); }

        }

        private void cake1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            int seconds = (int)elapsedTime.TotalSeconds;
            textBox1.Text = seconds.ToString();
            textBox2.Text = ((int)((double)cakesVisible / inProcess * 100)).ToString() + "%";
            textBox3.Text = waitingNum.ToString();
            if (count == 0)
                textBox4.Text = ((double)sum / 1).ToString($"F{2}") + " sec";
            else
                textBox4.Text = ((double)sum / count).ToString($"F{2}") + " sec";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
