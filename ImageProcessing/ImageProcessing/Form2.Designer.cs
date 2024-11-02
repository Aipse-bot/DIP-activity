namespace ImageProcessing
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button5 = new Button();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            button4 = new Button();
            button3 = new Button();
            menuStrip1 = new MenuStrip();
            onToolStripMenuItem = new ToolStripMenuItem();
            offToolStripMenuItem = new ToolStripMenuItem();
            videoToolStripMenuItem = new ToolStripMenuItem();
            subtractToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(314, 12);
            button1.Name = "button1";
            button1.Size = new Size(71, 29);
            button1.TabIndex = 5;
            button1.Text = "Part 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(391, 12);
            button2.Name = "button2";
            button2.Size = new Size(71, 29);
            button2.TabIndex = 6;
            button2.Text = "Part 2";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(319, 468);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(377, 55);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(319, 468);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(739, 55);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(319, 468);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // button5
            // 
            button5.Location = new Point(830, 542);
            button5.Name = "button5";
            button5.Size = new Size(137, 29);
            button5.TabIndex = 12;
            button5.Text = "Subtract";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            openFileDialog2.FileOk += openFileDialog2_FileOk;
            // 
            // button4
            // 
            button4.Location = new Point(461, 542);
            button4.Name = "button4";
            button4.Size = new Size(137, 29);
            button4.TabIndex = 11;
            button4.Text = "Load Background";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(95, 542);
            button3.Name = "button3";
            button3.Size = new Size(137, 29);
            button3.TabIndex = 10;
            button3.Text = "Load Image";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { onToolStripMenuItem, offToolStripMenuItem, videoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1070, 28);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
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
            videoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { subtractToolStripMenuItem });
            videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            videoToolStripMenuItem.Size = new Size(62, 24);
            videoToolStripMenuItem.Text = "Video";
            // 
            // subtractToolStripMenuItem
            // 
            subtractToolStripMenuItem.Name = "subtractToolStripMenuItem";
            subtractToolStripMenuItem.Size = new Size(224, 26);
            subtractToolStripMenuItem.Text = "Subtract";
            subtractToolStripMenuItem.Click += subtractToolStripMenuItem_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 627);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button5;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private Button button4;
        private Button button3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem onToolStripMenuItem;
        private ToolStripMenuItem offToolStripMenuItem;
        private ToolStripMenuItem videoToolStripMenuItem;
        private ToolStripMenuItem subtractToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}