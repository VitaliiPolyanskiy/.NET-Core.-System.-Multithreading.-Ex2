using System;
using System.Threading;
using System.Windows.Forms;

namespace Multithreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void MyThread()
        {
            for (int i = 0; i < 10; i++)
                Thread.Sleep(1000);
            MessageBox.Show("Вторичный поток завершил работу!", "Многопоточность", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
                Thread.Sleep(1000);
            MessageBox.Show("Первичный поток завершил работу!", "Многопоточность", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(MyThread));
            th.Start();
        }
    }
}
