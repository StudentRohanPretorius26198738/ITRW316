using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Threading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread th;
        Thread th1;

        private async void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;

            string nOt = txbThreads.Text;
            MessageBox.Show("Number of thread's created is: " + nOt);
            th = new Thread(split);
            th.Start();
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = new Bitmap(opf.FileName);
            }
        }

        private void btnPicTest_Click(object sender, EventArgs e)
        {                 
            split();
        }

        public void split()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(i);
            }

            Bitmap orgPic = new Bitmap(pictureBox1.Image);
            Bitmap HorgPic = new Bitmap(pictureBox1.Image);
            double nthreads = Convert.ToInt64( txbThreads.Text );
            int myIntValue = unchecked((int)nthreads);
            int x = 3;

            for (int y = 3; y < orgPic.Height -3; y++)
            {
                int counter = 1;
                for (x = 3; x < (orgPic.Width * counter / nthreads) - 3; x++)
                {
                    Point[] arrayP = new Point[] {  new Point(x - 3, y - 3),
                                                    new Point(x - 0, y - 3),
                                                    new Point(x + 3, y - 3),
                                                    new Point(x - 3, y - 0),
                                                    new Point(x - 0, y - 0),
                                                    new Point(x + 3, y - 0),
                                                    new Point(x - 3, y + 3),
                                                    new Point(x - 0, y + 3),
                                                    new Point(x + 3, y + 3)};

                    int sumA = 0, sumR = 0, sumG = 0, sumB = 0;
                    foreach (Point item in arrayP)
                    {
                        sumA += orgPic.GetPixel(item.X, item.Y).A;
                        sumR += orgPic.GetPixel(item.X, item.Y).R;
                        sumG += orgPic.GetPixel(item.X, item.Y).G;
                        sumB += orgPic.GetPixel(item.X, item.Y).B;
                    }
                    int meanARGB = 0x01000000 * (sumA / 9) +
                                   0x00010000 * (sumR / 9) +
                                   0x00000100 * (sumG / 9) +
                                   0x00000001 * (sumB / 9);

                    HorgPic.SetPixel(x, y, Color.FromArgb(meanARGB));
                }
                counter++;
               while (counter < nthreads +1)
               {
                    for (x = (orgPic.Width * 1 / myIntValue) - 6; x < (orgPic.Width * counter / nthreads) - 3; x++)
                    {
                        Point[] arrayP = new Point[] {  new Point(x - 3, y - 3),
                                                    new Point(x - 0, y - 3),
                                                    new Point(x + 3, y - 3),
                                                    new Point(x - 3, y - 0),
                                                    new Point(x - 0, y - 0),
                                                    new Point(x + 3, y - 0),
                                                    new Point(x - 3, y + 3),
                                                    new Point(x - 0, y + 3),
                                                    new Point(x + 3, y + 3)};

                        int sumA = 0, sumR = 0, sumG = 0, sumB = 0;
                        foreach (Point item in arrayP)
                        {
                            sumA += orgPic.GetPixel(item.X, item.Y).A;
                            sumR += orgPic.GetPixel(item.X, item.Y).R;
                            sumG += orgPic.GetPixel(item.X, item.Y).G;
                            sumB += orgPic.GetPixel(item.X, item.Y).B;
                        }
                        int meanARGB = 0x01000000 * (sumA / 9) +
                                       0x00010000 * (sumR / 9) +
                                       0x00000100 * (sumG / 9) +
                                       0x00000001 * (sumB / 9);

                        HorgPic.SetPixel(x, y, Color.FromArgb(meanARGB));
                    }
                    counter++;
                }
            }
            pictureBox2.Image = HorgPic;

            watch.Stop();
            MessageBox.Show($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }
    }
}
