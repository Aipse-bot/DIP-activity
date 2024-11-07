using System.Drawing.Drawing2D;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;
using WebCamLib;
namespace ImageProcessing
{
    public partial class Form1 : Form
    {

        Bitmap loaded, processed, filter, savedcopy;
        Device[] mgaDevice;
        String filename;
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dIPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void HistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageProcess.Histogram(ref loaded, ref processed);
            pictureBox2.Image = processed;
        }

        private void SepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color Sepia;
            for (int row = 0; row < loaded.Width; row++)
            {
                for (int col = 0; col < loaded.Height; col++)
                {
                    Sepia = loaded.GetPixel(row, col);

                    int a = Sepia.A;
                    int r = Sepia.R;
                    int g = Sepia.G;
                    int b = Sepia.B;

                    int tr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                    int tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                    int tb = (int)(0.272 * r + 0.534 * g + 0.131 * b);

                    if (tr > 255)
                    {
                        r = 255;
                    }
                    else
                    {
                        r = tr;
                    }

                    if (tg > 255)
                    {
                        g = 255;
                    }
                    else
                    {
                        g = tg;
                    }

                    if (tb > 255)
                    {
                        b = 255;
                    }
                    else
                    {
                        b = tb;
                    }

                    processed.SetPixel(row, col, Color.FromArgb(a, r, g, b));
                }
            }
            pictureBox2.Image = processed;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            filename = openFileDialog1.FileName;
            loaded = new Bitmap(filename);
            pictureBox1.Image = loaded;
            savedcopy = new Bitmap(filename);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void pixelCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int row = 0; row < loaded.Width; row++)
            {
                for (int col = 0; col < loaded.Height; col++)
                {
                    pixel = loaded.GetPixel(row, col);
                    processed.SetPixel(row, col, pixel);
                }
            }
            pictureBox2.Image = processed;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

            processed.Save(saveFileDialog1.FileName + ".jpg");
            saveFileDialog1.Filter = "JPG (*.jpg)|*.jpg.";
        }

        private void grayscalingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            int avg;
            for (int row = 0; row < loaded.Width; row++)
            {
                for (int col = 0; col < loaded.Height; col++)
                {
                    pixel = loaded.GetPixel(row, col);
                    avg = (int)(pixel.R + pixel.G + pixel.B) / 3;
                    Color gray = Color.FromArgb(avg, avg, avg);
                    processed.SetPixel(row, col, gray);
                }
            }
            pictureBox2.Image = processed;
        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int row = 0; row < loaded.Width; row++)
            {
                for (int col = 0; col < loaded.Height; col++)
                {
                    pixel = loaded.GetPixel(row, col);
                    Color Inv = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    processed.SetPixel(row, col, Inv);
                }
            }
            pictureBox2.Image = processed;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 existingForm2 = (Form2)Application.OpenForms["Form2"];

            if (existingForm2 != null)
            {
                this.Hide();
                existingForm2.Show();
                existingForm2.Activate();
            }
            else
            {
                Form2 newForm2 = new Form2();

                newForm2.Show();

                this.Hide();
            }

        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            mgaDevice[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            Bitmap b = new Bitmap(bmap);

            processed = new Bitmap(b.Width, b.Height);
            Color pixel;
            int avg;
            for (int row = 0; row < b.Width; row++)
            {
                for (int col = 0; col < b.Height; col++)
                {
                    pixel = b.GetPixel(row, col);
                    avg = (int)(pixel.R + pixel.G + pixel.B) / 3;
                    Color gray = Color.FromArgb(avg, avg, avg);
                    processed.SetPixel(row, col, gray);
                }
            }
            pictureBox2.Image = processed;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            mgaDevice[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            Bitmap b = new Bitmap(bmap);

            processed = new Bitmap(b.Width, b.Height);
            Color pixel;
            for (int row = 0; row < b.Width; row++)
            {
                for (int col = 0; col < b.Height; col++)
                {
                    pixel = b.GetPixel(row, col);
                    processed.SetPixel(row, col, pixel);
                }
            }
            pictureBox2.Image = processed;
        }

        private void pixelCopyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = true;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            mgaDevice[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            Bitmap b = new Bitmap(bmap);

            processed = new Bitmap(b.Width, b.Height);
            Color pixel;
            for (int row = 0; row < b.Width; row++)
            {
                for (int col = 0; col < b.Height; col++)
                {
                    pixel = b.GetPixel(row, col);
                    Color Inv = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    processed.SetPixel(row, col, Inv);
                }
            }
            pictureBox2.Image = processed;
        }

        private void inversionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = true;
            timer4.Enabled = false;
            timer5.Enabled = false;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            mgaDevice[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            Bitmap b = new Bitmap(bmap);

            ImageProcess.Histogram(ref b, ref processed);
            pictureBox2.Image = processed;
        }

        private void histogramToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = true;
            timer5.Enabled = false;
        }

        private void sepiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = true;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            mgaDevice[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));
            Bitmap B = new Bitmap(bmap);

            processed = new Bitmap(B.Width, B.Height);
            Color Sepia;
            for (int row = 0; row < B.Width; row++)
            {
                for (int col = 0; col < B.Height; col++)
                {
                    Sepia = B.GetPixel(row, col);

                    int a = Sepia.A;
                    int r = Sepia.R;
                    int g = Sepia.G;
                    int b = Sepia.B;

                    int tr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                    int tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                    int tb = (int)(0.272 * r + 0.534 * g + 0.131 * b);

                    if (tr > 255)
                    {
                        r = 255;
                    }
                    else
                    {
                        r = tr;
                    }

                    if (tg > 255)
                    {
                        g = 255;
                    }
                    else
                    {
                        g = tg;
                    }

                    if (tb > 255)
                    {
                        b = 255;
                    }
                    else
                    {
                        b = tb;
                    }

                    processed.SetPixel(row, col, Color.FromArgb(a, r, g, b));
                }
            }
            pictureBox2.Image = processed;
        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter = loaded;
            ImageProcess2.BitmapFilter.GaussianBlur(filter, 4);
            pictureBox2.Image = filter;
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter = loaded;
            ImageProcess2.BitmapFilter.Sharpen(filter, 11);
            pictureBox2.Image = filter;
        }

        private void meanRemovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter = loaded;
            ImageProcess2.BitmapFilter.MeanRemoval(filter, 9);
            pictureBox2.Image = filter;
        }

        private void embossingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter = loaded;
            ImageProcess2.BitmapFilter.EmbossLaplacian(filter);
            pictureBox2.Image = filter;
        }

        private void horizontalVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter = loaded;
            ImageProcess2.BitmapFilter.EmbossHorsVers(filter);
            pictureBox2.Image = filter;
        }

        private void lossyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter = loaded;
            ImageProcess2.BitmapFilter.EmbossLossy(filter);
            pictureBox2.Image = filter;
        }

        private void horizontalOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter = loaded;
            ImageProcess2.BitmapFilter.EmbossHor(filter);
            pictureBox2.Image = filter;
        }

        private void verticalOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filter = loaded;
            ImageProcess2.BitmapFilter.EmbossVert(filter);
            pictureBox2.Image = filter;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(loaded != null)
            {
                loaded = new Bitmap(filename);
                pictureBox2.Image = loaded;
            }
            
        }
    }

}
