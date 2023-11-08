using System.Threading;

namespace FrmBasicThreadCSharp
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        class MyThreadClass
        {
            public static void Thread1()
            {
                for (int loopCount = 0; loopCount <= 10; loopCount++)
                {
                    Console.WriteLine("Name Of Thread: ThreadA Process = " + loopCount);

                    if (loopCount == 5)
                    {
                        break;
                    }

                    Thread.Sleep(1500);
                }

            }

            public static void Thread2()
            {
                for (int loopCount = 0; loopCount <= 10; loopCount++)
                {
                    Console.WriteLine("Name Of Thread: ThreadB Process = " + loopCount);

                    if (loopCount == 5)
                    {
                        break;
                    }

                    Thread.Sleep(1500);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread threadA = new Thread(MyThreadClass.Thread1);
            Thread threadB = new Thread(MyThreadClass.Thread2);
            threadA.Start();
            threadB.Start();


            threadA.Join();
            threadB.Join();
            label1.Text = "-End Of Thread-";
        }
    }
}