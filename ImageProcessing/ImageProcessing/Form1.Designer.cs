namespace ImageProcessing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip2 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            dIPToolStripMenuItem = new ToolStripMenuItem();
            pixelCopyToolStripMenuItem = new ToolStripMenuItem();
            grayscalingToolStripMenuItem = new ToolStripMenuItem();
            inversionToolStripMenuItem = new ToolStripMenuItem();
            HistogramToolStripMenuItem = new ToolStripMenuItem();
            SepiaToolStripMenuItem = new ToolStripMenuItem();
            onToolStripMenuItem = new ToolStripMenuItem();
            offToolStripMenuItem = new ToolStripMenuItem();
            videoToolStripMenuItem = new ToolStripMenuItem();
            grayScaleToolStripMenuItem = new ToolStripMenuItem();
            pixelCopyToolStripMenuItem1 = new ToolStripMenuItem();
            inversionToolStripMenuItem1 = new ToolStripMenuItem();
            histogramToolStripMenuItem1 = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            pictureBox2 = new PictureBox();
            saveFileDialog1 = new SaveFileDialog();
            button1 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            timer5 = new System.Windows.Forms.Timer(components);
            sepiaToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, dIPToolStripMenuItem, onToolStripMenuItem, offToolStripMenuItem, videoToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1070, 28);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(128, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(128, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // dIPToolStripMenuItem
            // 
            dIPToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pixelCopyToolStripMenuItem, grayscalingToolStripMenuItem, inversionToolStripMenuItem, HistogramToolStripMenuItem, SepiaToolStripMenuItem });
            dIPToolStripMenuItem.Name = "dIPToolStripMenuItem";
            dIPToolStripMenuItem.Size = new Size(46, 24);
            dIPToolStripMenuItem.Text = "DIP";
            dIPToolStripMenuItem.Click += dIPToolStripMenuItem_Click;
            // 
            // pixelCopyToolStripMenuItem
            // 
            pixelCopyToolStripMenuItem.Name = "pixelCopyToolStripMenuItem";
            pixelCopyToolStripMenuItem.Size = new Size(168, 26);
            pixelCopyToolStripMenuItem.Text = "pixel copy";
            pixelCopyToolStripMenuItem.Click += pixelCopyToolStripMenuItem_Click;
            // 
            // grayscalingToolStripMenuItem
            // 
            grayscalingToolStripMenuItem.Name = "grayscalingToolStripMenuItem";
            grayscalingToolStripMenuItem.Size = new Size(168, 26);
            grayscalingToolStripMenuItem.Text = "Grayscaling";
            grayscalingToolStripMenuItem.Click += grayscalingToolStripMenuItem_Click;
            // 
            // inversionToolStripMenuItem
            // 
            inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            inversionToolStripMenuItem.Size = new Size(168, 26);
            inversionToolStripMenuItem.Text = "Inversion";
            inversionToolStripMenuItem.Click += inversionToolStripMenuItem_Click;
            // 
            // HistogramToolStripMenuItem
            // 
            HistogramToolStripMenuItem.Name = "HistogramToolStripMenuItem";
            HistogramToolStripMenuItem.Size = new Size(168, 26);
            HistogramToolStripMenuItem.Text = "Histogram";
            HistogramToolStripMenuItem.Click += HistogramToolStripMenuItem_Click;
            // 
            // SepiaToolStripMenuItem
            // 
            SepiaToolStripMenuItem.Name = "SepiaToolStripMenuItem";
            SepiaToolStripMenuItem.Size = new Size(168, 26);
            SepiaToolStripMenuItem.Text = "Sepia";
            SepiaToolStripMenuItem.Click += SepiaToolStripMenuItem_Click;
            // 
            // onToolStripMenuItem
            // 
            onToolStripMenuItem.Name = "onToolStripMenuItem";
            onToolStripMenuItem.Size = new Size(40, 24);
            onToolStripMenuItem.Text = "on";
            onToolStripMenuItem.Click += onToolStripMenuItem_Click;
            // 
            // offToolStripMenuItem
            // 
            offToolStripMenuItem.Name = "offToolStripMenuItem";
            offToolStripMenuItem.Size = new Size(42, 24);
            offToolStripMenuItem.Text = "off";
            offToolStripMenuItem.Click += offToolStripMenuItem_Click;
            // 
            // videoToolStripMenuItem
            // 
            videoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { grayScaleToolStripMenuItem, pixelCopyToolStripMenuItem1, inversionToolStripMenuItem1, histogramToolStripMenuItem1, sepiaToolStripMenuItem1 });
            videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            videoToolStripMenuItem.Size = new Size(62, 24);
            videoToolStripMenuItem.Text = "Video";
            videoToolStripMenuItem.Click += videoToolStripMenuItem_Click;
            // 
            // grayScaleToolStripMenuItem
            // 
            grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            grayScaleToolStripMenuItem.Size = new Size(224, 26);
            grayScaleToolStripMenuItem.Text = "GrayScale";
            grayScaleToolStripMenuItem.Click += grayScaleToolStripMenuItem_Click;
            // 
            // pixelCopyToolStripMenuItem1
            // 
            pixelCopyToolStripMenuItem1.Name = "pixelCopyToolStripMenuItem1";
            pixelCopyToolStripMenuItem1.Size = new Size(224, 26);
            pixelCopyToolStripMenuItem1.Text = "Pixel Copy";
            pixelCopyToolStripMenuItem1.Click += pixelCopyToolStripMenuItem1_Click;
            // 
            // inversionToolStripMenuItem1
            // 
            inversionToolStripMenuItem1.Name = "inversionToolStripMenuItem1";
            inversionToolStripMenuItem1.Size = new Size(224, 26);
            inversionToolStripMenuItem1.Text = "Inversion";
            inversionToolStripMenuItem1.Click += inversionToolStripMenuItem1_Click;
            // 
            // histogramToolStripMenuItem1
            // 
            histogramToolStripMenuItem1.Name = "histogramToolStripMenuItem1";
            histogramToolStripMenuItem1.Size = new Size(224, 26);
            histogramToolStripMenuItem1.Text = "Histogram";
            histogramToolStripMenuItem1.Click += histogramToolStripMenuItem1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(36, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(459, 549);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(579, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(459, 549);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // button1
            // 
            button1.Location = new Point(314, 12);
            button1.Name = "button1";
            button1.Size = new Size(71, 29);
            button1.TabIndex = 4;
            button1.Text = "Part 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(391, 12);
            button2.Name = "button2";
            button2.Size = new Size(71, 29);
            button2.TabIndex = 5;
            button2.Text = "Part 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 10;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 10;
            timer3.Tick += timer3_Tick;
            // 
            // timer4
            // 
            timer4.Interval = 10;
            timer4.Tick += timer4_Tick;
            // 
            // timer5
            // 
            timer5.Interval = 10;
            timer5.Tick += timer5_Tick;
            // 
            // sepiaToolStripMenuItem1
            // 
            sepiaToolStripMenuItem1.Name = "sepiaToolStripMenuItem1";
            sepiaToolStripMenuItem1.Size = new Size(224, 26);
            sepiaToolStripMenuItem1.Text = "Sepia";
            sepiaToolStripMenuItem1.Click += sepiaToolStripMenuItem1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 627);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip2;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem dIPToolStripMenuItem;
        private ToolStripMenuItem pixelCopyToolStripMenuItem;
        private ToolStripMenuItem grayscalingToolStripMenuItem;
        private ToolStripMenuItem inversionToolStripMenuItem;
        private ToolStripMenuItem HistogramToolStripMenuItem;
        private ToolStripMenuItem SepiaToolStripMenuItem;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private PictureBox pictureBox2;
        private SaveFileDialog saveFileDialog1;
        private Button button1;
        private Button button2;
        private ToolStripMenuItem onToolStripMenuItem;
        private ToolStripMenuItem offToolStripMenuItem;
        private ToolStripMenuItem videoToolStripMenuItem;
        private ToolStripMenuItem grayScaleToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private ToolStripMenuItem pixelCopyToolStripMenuItem1;
        private ToolStripMenuItem inversionToolStripMenuItem1;
        private ToolStripMenuItem histogramToolStripMenuItem1;
        private ToolStripMenuItem sepiaToolStripMenuItem1;
    }
}
