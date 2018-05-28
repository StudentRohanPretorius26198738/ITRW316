namespace Threading
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPic = new System.Windows.Forms.Button();
            this.btnPicTest = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txbTime = new System.Windows.Forms.TextBox();
            this.txbThreads = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 775);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnPic
            // 
            this.btnPic.Location = new System.Drawing.Point(122, 12);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(75, 23);
            this.btnPic.TabIndex = 2;
            this.btnPic.Text = "Load Picture";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // btnPicTest
            // 
            this.btnPicTest.Location = new System.Drawing.Point(229, 11);
            this.btnPicTest.Name = "btnPicTest";
            this.btnPicTest.Size = new System.Drawing.Size(75, 23);
            this.btnPicTest.TabIndex = 3;
            this.btnPicTest.Text = "Scrable Picture 1Thread";
            this.btnPicTest.UseVisualStyleBackColor = true;
            this.btnPicTest.Click += new System.EventHandler(this.btnPicTest_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(807, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1042, 775);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // txbTime
            // 
            this.txbTime.Location = new System.Drawing.Point(310, 11);
            this.txbTime.Name = "txbTime";
            this.txbTime.Size = new System.Drawing.Size(100, 20);
            this.txbTime.TabIndex = 5;
            // 
            // txbThreads
            // 
            this.txbThreads.Location = new System.Drawing.Point(860, 9);
            this.txbThreads.Name = "txbThreads";
            this.txbThreads.Size = new System.Drawing.Size(100, 20);
            this.txbThreads.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Please enter the number of threads you want to use: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1874, 829);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbThreads);
            this.Controls.Add(this.txbTime);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnPicTest);
            this.Controls.Add(this.btnPic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.Button btnPicTest;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txbTime;
        private System.Windows.Forms.TextBox txbThreads;
        private System.Windows.Forms.Label label1;
    }
}

