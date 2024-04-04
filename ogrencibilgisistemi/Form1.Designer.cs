namespace yazlab3
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
            ogrencibuton = new Button();
            ogretmenbuton = new Button();
            yoneticibuton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // ogrencibuton
            // 
            ogrencibuton.BackColor = Color.FromArgb(192, 255, 255);
            ogrencibuton.Location = new Point(167, 257);
            ogrencibuton.Name = "ogrencibuton";
            ogrencibuton.Size = new Size(223, 138);
            ogrencibuton.TabIndex = 1;
            ogrencibuton.Text = "Öğrenci Giriş";
            ogrencibuton.UseVisualStyleBackColor = false;
            ogrencibuton.Click += button1_Click;
            // 
            // ogretmenbuton
            // 
            ogretmenbuton.BackColor = Color.FromArgb(128, 255, 255);
            ogretmenbuton.Location = new Point(532, 257);
            ogretmenbuton.Name = "ogretmenbuton";
            ogretmenbuton.Size = new Size(213, 138);
            ogretmenbuton.TabIndex = 2;
            ogretmenbuton.Text = "Öğretmen Giriş";
            ogretmenbuton.UseVisualStyleBackColor = false;
            ogretmenbuton.Click += button2_Click;
            // 
            // yoneticibuton
            // 
            yoneticibuton.BackColor = Color.Cyan;
            yoneticibuton.Location = new Point(912, 257);
            yoneticibuton.Name = "yoneticibuton";
            yoneticibuton.Size = new Size(208, 138);
            yoneticibuton.TabIndex = 3;
            yoneticibuton.Text = "Yönetici Giriş";
            yoneticibuton.UseVisualStyleBackColor = false;
            yoneticibuton.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(178, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 162);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(532, 74);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(213, 162);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(912, 74);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(208, 162);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 605);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(yoneticibuton);
            Controls.Add(ogretmenbuton);
            Controls.Add(ogrencibuton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button ogrencibuton;
        private Button ogretmenbuton;
        private Button yoneticibuton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}