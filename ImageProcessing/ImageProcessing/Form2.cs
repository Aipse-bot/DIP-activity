using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamLib;

namespace ImageProcessing
{
    public partial class Form2 : Form
    {
        Bitmap imageB, imageA, colorgreen, resultImage;
        Device[] mgaDevice;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 existingForm1 = (Form1)Application.OpenForms["Form1"];

            if (existingForm1 != null)
            {
                existingForm1.Show();
                existingForm1.Activate();
            }

            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            imageB = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = imageB;
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            imageA = new Bitmap(openFileDialog2.FileName);
            pictureBox2.Image = imageA;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            resultImage = new Bitmap(imageB.Width, imageB.Height);


            Color mygreen = Color.FromArgb(0, 0, 255);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
            int threshold = 5;


            for (int x = 0; x < imageB.Width; x++)
                for (int y = 0; y < imageB.Height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    Color backpixel = imageA.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractivevalue = Math.Abs(grey - greygreen);


                    if (subtractivevalue > threshold)
                        resultImage.SetPixel(x, y, pixel);
                    else
                        resultImage.SetPixel(x, y, backpixel);
                }
            pictureBox3.Image = resultImage;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            mgaDevice = DeviceManager.GetAllDevices();
        }
        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mgaDevice[0].ShowWindow(pictureBox1);
        }

        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mgaDevice[0].Stop();
        }

        private void subtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            mgaDevice[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            Bitmap B = new Bitmap(bmap);

            resultImage = new Bitmap(B.Width, B.Height);


            Color mygreen = Color.FromArgb(0, 0, 255);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
            int threshold = 5;


            for (int x = 0; x < B.Width; x++)
                for (int y = 0; y < B.Height; y++)
                {
                    Color pixel = B.GetPixel(x, y);
                    Color backpixel = imageA.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractivevalue = Math.Abs(grey - greygreen);


                    if (subtractivevalue > threshold)
                        resultImage.SetPixel(x, y, pixel);
                    else
                        resultImage.SetPixel(x, y, backpixel);
                }
            pictureBox3.Image = resultImage;
        }
    }
}
