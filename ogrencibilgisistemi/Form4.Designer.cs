namespace yazlab3
{
    partial class Form4
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
            yoneticiadlabel = new Label();
            yoneticisifrelabel = new Label();
            yoneticiadtext = new TextBox();
            yoneticisifretetxt = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            dersecimbuton = new Button();
            ogretmenbilgipanel = new Panel();
            verdigiderslertextbox = new TextBox();
            label9 = new Label();
            ogretmensifretextbox = new TextBox();
            label8 = new Label();
            ogretmenidtextbox = new TextBox();
            label7 = new Label();
            ogretmensicilnotextbox = new TextBox();
            label6 = new Label();
            ogretmenadtextbox = new TextBox();
            label5 = new Label();
            ogretmenguncellebuton = new Button();
            ogretmensilbuton = new Button();
            ogretmeneklebuton = new Button();
            dataGridView2 = new DataGridView();
            ogrencibilgipanel = new Panel();
            ogrenciidtextbox = new TextBox();
            label4 = new Label();
            ogrencisifretextbox = new TextBox();
            label3 = new Label();
            ogrencinotextbox = new TextBox();
            label2 = new Label();
            ogrenciadtextbox = new TextBox();
            label1 = new Label();
            button3 = new Button();
            silmebuton = new Button();
            ogrencieklebuton = new Button();
            dataGridView1 = new DataGridView();
            ogretmenbilgibutton = new Button();
            ogrencibilgibutton = new Button();
            panel1.SuspendLayout();
            ogretmenbilgipanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ogrencibilgipanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // yoneticiadlabel
            // 
            yoneticiadlabel.AutoSize = true;
            yoneticiadlabel.BackColor = Color.FromArgb(255, 224, 192);
            yoneticiadlabel.Location = new Point(273, 73);
            yoneticiadlabel.Name = "yoneticiadlabel";
            yoneticiadlabel.Size = new Size(109, 20);
            yoneticiadlabel.TabIndex = 0;
            yoneticiadlabel.Text = "KULLANICI ADI";
            yoneticiadlabel.Click += yoneticiadlabel_Click;
            // 
            // yoneticisifrelabel
            // 
            yoneticisifrelabel.AutoSize = true;
            yoneticisifrelabel.BackColor = Color.FromArgb(255, 224, 192);
            yoneticisifrelabel.Location = new Point(273, 189);
            yoneticisifrelabel.Name = "yoneticisifrelabel";
            yoneticisifrelabel.Size = new Size(45, 20);
            yoneticisifrelabel.TabIndex = 1;
            yoneticisifrelabel.Text = "ŞİFRE";
            yoneticisifrelabel.Click += yoneticisifrelabel_Click;
            // 
            // yoneticiadtext
            // 
            yoneticiadtext.BackColor = Color.FromArgb(192, 255, 192);
            yoneticiadtext.Location = new Point(273, 125);
            yoneticiadtext.Name = "yoneticiadtext";
            yoneticiadtext.Size = new Size(218, 27);
            yoneticiadtext.TabIndex = 2;
            yoneticiadtext.TextChanged += yoneticiadtext_TextChanged;
            // 
            // yoneticisifretetxt
            // 
            yoneticisifretetxt.BackColor = Color.FromArgb(192, 255, 192);
            yoneticisifretetxt.ImeMode = ImeMode.NoControl;
            yoneticisifretetxt.Location = new Point(273, 242);
            yoneticisifretetxt.Name = "yoneticisifretetxt";
            yoneticisifretetxt.Size = new Size(218, 27);
            yoneticisifretetxt.TabIndex = 3;
            yoneticisifretetxt.TextChanged += yoneticisifretetxt_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(293, 290);
            button1.Name = "button1";
            button1.Size = new Size(158, 91);
            button1.TabIndex = 4;
            button1.Text = "GİRİŞ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dersecimbuton);
            panel1.Controls.Add(ogretmenbilgipanel);
            panel1.Controls.Add(ogrencibilgipanel);
            panel1.Controls.Add(ogretmenbilgibutton);
            panel1.Controls.Add(ogrencibilgibutton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 608);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // dersecimbuton
            // 
            dersecimbuton.BackColor = Color.FromArgb(128, 255, 128);
            dersecimbuton.Location = new Point(741, 0);
            dersecimbuton.Name = "dersecimbuton";
            dersecimbuton.Size = new Size(205, 130);
            dersecimbuton.TabIndex = 4;
            dersecimbuton.Text = "DERS SEÇİM EKRANI";
            dersecimbuton.UseVisualStyleBackColor = false;
            dersecimbuton.Click += dersecimbuton_Click;
            // 
            // ogretmenbilgipanel
            // 
            ogretmenbilgipanel.Controls.Add(verdigiderslertextbox);
            ogretmenbilgipanel.Controls.Add(label9);
            ogretmenbilgipanel.Controls.Add(ogretmensifretextbox);
            ogretmenbilgipanel.Controls.Add(label8);
            ogretmenbilgipanel.Controls.Add(ogretmenidtextbox);
            ogretmenbilgipanel.Controls.Add(label7);
            ogretmenbilgipanel.Controls.Add(ogretmensicilnotextbox);
            ogretmenbilgipanel.Controls.Add(label6);
            ogretmenbilgipanel.Controls.Add(ogretmenadtextbox);
            ogretmenbilgipanel.Controls.Add(label5);
            ogretmenbilgipanel.Controls.Add(ogretmenguncellebuton);
            ogretmenbilgipanel.Controls.Add(ogretmensilbuton);
            ogretmenbilgipanel.Controls.Add(ogretmeneklebuton);
            ogretmenbilgipanel.Controls.Add(dataGridView2);
            ogretmenbilgipanel.Location = new Point(343, 122);
            ogretmenbilgipanel.Name = "ogretmenbilgipanel";
            ogretmenbilgipanel.Size = new Size(367, 464);
            ogretmenbilgipanel.TabIndex = 3;
            ogretmenbilgipanel.Paint += ogretmenbilgipanel_Paint;
            // 
            // verdigiderslertextbox
            // 
            verdigiderslertextbox.Location = new Point(142, 410);
            verdigiderslertextbox.Name = "verdigiderslertextbox";
            verdigiderslertextbox.Size = new Size(125, 27);
            verdigiderslertextbox.TabIndex = 13;
            verdigiderslertextbox.TextChanged += verdigiderslertextbox_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(255, 192, 192);
            label9.Location = new Point(141, 387);
            label9.Name = "label9";
            label9.Size = new Size(107, 20);
            label9.TabIndex = 12;
            label9.Text = "Verdiği Dersler";
            label9.Click += label9_Click;
            // 
            // ogretmensifretextbox
            // 
            ogretmensifretextbox.Location = new Point(140, 357);
            ogretmensifretextbox.Name = "ogretmensifretextbox";
            ogretmensifretextbox.Size = new Size(125, 27);
            ogretmensifretextbox.TabIndex = 11;
            ogretmensifretextbox.TextChanged += ogretmensifretextbox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(255, 192, 192);
            label8.Location = new Point(140, 335);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 10;
            label8.Text = "Şifre";
            label8.Click += label8_Click;
            // 
            // ogretmenidtextbox
            // 
            ogretmenidtextbox.Location = new Point(140, 305);
            ogretmenidtextbox.Name = "ogretmenidtextbox";
            ogretmenidtextbox.Size = new Size(125, 27);
            ogretmenidtextbox.TabIndex = 9;
            ogretmenidtextbox.TextChanged += ogretmenidtextbox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(255, 192, 192);
            label7.Location = new Point(140, 282);
            label7.Name = "label7";
            label7.Size = new Size(22, 20);
            label7.TabIndex = 8;
            label7.Text = "id";
            label7.Click += label7_Click;
            // 
            // ogretmensicilnotextbox
            // 
            ogretmensicilnotextbox.Location = new Point(140, 251);
            ogretmensicilnotextbox.Name = "ogretmensicilnotextbox";
            ogretmensicilnotextbox.Size = new Size(125, 27);
            ogretmensicilnotextbox.TabIndex = 7;
            ogretmensicilnotextbox.TextChanged += ogretmensicilnotextbox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 192, 192);
            label6.Location = new Point(140, 219);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 6;
            label6.Text = "Sicil No";
            label6.Click += label6_Click;
            // 
            // ogretmenadtextbox
            // 
            ogretmenadtextbox.Location = new Point(141, 180);
            ogretmenadtextbox.Name = "ogretmenadtextbox";
            ogretmenadtextbox.Size = new Size(125, 27);
            ogretmenadtextbox.TabIndex = 5;
            ogretmenadtextbox.TextChanged += ogretmenadtextbox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 192, 192);
            label5.Location = new Point(142, 157);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 4;
            label5.Text = "Ad ve Soyad";
            label5.Click += label5_Click;
            // 
            // ogretmenguncellebuton
            // 
            ogretmenguncellebuton.BackColor = Color.FromArgb(255, 255, 192);
            ogretmenguncellebuton.Location = new Point(20, 316);
            ogretmenguncellebuton.Name = "ogretmenguncellebuton";
            ogretmenguncellebuton.Size = new Size(96, 62);
            ogretmenguncellebuton.TabIndex = 3;
            ogretmenguncellebuton.Text = "Öğretmen Güncelle";
            ogretmenguncellebuton.UseVisualStyleBackColor = false;
            ogretmenguncellebuton.Click += ogretmenguncellebuton_Click;
            // 
            // ogretmensilbuton
            // 
            ogretmensilbuton.BackColor = Color.FromArgb(255, 255, 192);
            ogretmensilbuton.Location = new Point(17, 237);
            ogretmensilbuton.Name = "ogretmensilbuton";
            ogretmensilbuton.Size = new Size(94, 54);
            ogretmensilbuton.TabIndex = 2;
            ogretmensilbuton.Text = "Öğretmen Sil";
            ogretmensilbuton.UseVisualStyleBackColor = false;
            ogretmensilbuton.Click += ogretmensilbuton_Click;
            // 
            // ogretmeneklebuton
            // 
            ogretmeneklebuton.BackColor = Color.FromArgb(255, 255, 192);
            ogretmeneklebuton.Location = new Point(20, 159);
            ogretmeneklebuton.Name = "ogretmeneklebuton";
            ogretmeneklebuton.Size = new Size(91, 55);
            ogretmeneklebuton.TabIndex = 1;
            ogretmeneklebuton.Text = "Öğretmen Ekle";
            ogretmeneklebuton.UseVisualStyleBackColor = false;
            ogretmeneklebuton.Click += ogretmeneklebuton_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(361, 153);
            dataGridView2.TabIndex = 0;
            // 
            // ogrencibilgipanel
            // 
            ogrencibilgipanel.Controls.Add(ogrenciidtextbox);
            ogrencibilgipanel.Controls.Add(label4);
            ogrencibilgipanel.Controls.Add(ogrencisifretextbox);
            ogrencibilgipanel.Controls.Add(label3);
            ogrencibilgipanel.Controls.Add(ogrencinotextbox);
            ogrencibilgipanel.Controls.Add(label2);
            ogrencibilgipanel.Controls.Add(ogrenciadtextbox);
            ogrencibilgipanel.Controls.Add(label1);
            ogrencibilgipanel.Controls.Add(button3);
            ogrencibilgipanel.Controls.Add(silmebuton);
            ogrencibilgipanel.Controls.Add(ogrencieklebuton);
            ogrencibilgipanel.Controls.Add(dataGridView1);
            ogrencibilgipanel.Location = new Point(3, 125);
            ogrencibilgipanel.Name = "ogrencibilgipanel";
            ogrencibilgipanel.Size = new Size(340, 464);
            ogrencibilgipanel.TabIndex = 2;
            ogrencibilgipanel.Paint += ogrencibilgipanel_Paint;
            // 
            // ogrenciidtextbox
            // 
            ogrenciidtextbox.Location = new Point(143, 355);
            ogrenciidtextbox.Name = "ogrenciidtextbox";
            ogrenciidtextbox.Size = new Size(125, 27);
            ogrenciidtextbox.TabIndex = 12;
            ogrenciidtextbox.TextChanged += ogrenciidtextbox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 192, 192);
            label4.Location = new Point(143, 331);
            label4.Name = "label4";
            label4.Size = new Size(22, 20);
            label4.TabIndex = 11;
            label4.Text = "id";
            label4.Click += label4_Click;
            // 
            // ogrencisifretextbox
            // 
            ogrencisifretextbox.Location = new Point(143, 301);
            ogrencisifretextbox.Name = "ogrencisifretextbox";
            ogrencisifretextbox.Size = new Size(125, 27);
            ogrencisifretextbox.TabIndex = 10;
            ogrencisifretextbox.TextChanged += ogrencisifretextbox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 192, 192);
            label3.Location = new Point(147, 278);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 9;
            label3.Text = "Şifre";
            label3.Click += label3_Click;
            // 
            // ogrencinotextbox
            // 
            ogrencinotextbox.Location = new Point(147, 248);
            ogrencinotextbox.Name = "ogrencinotextbox";
            ogrencinotextbox.Size = new Size(125, 27);
            ogrencinotextbox.TabIndex = 8;
            ogrencinotextbox.TextChanged += ogrencinotextbox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 192);
            label2.Location = new Point(149, 225);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 7;
            label2.Text = "Öğrenci No";
            label2.Click += label2_Click;
            // 
            // ogrenciadtextbox
            // 
            ogrenciadtextbox.Location = new Point(149, 195);
            ogrenciadtextbox.Name = "ogrenciadtextbox";
            ogrenciadtextbox.Size = new Size(123, 27);
            ogrenciadtextbox.TabIndex = 6;
            ogrenciadtextbox.TextChanged += ogrenciadtextbox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.Location = new Point(149, 172);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 5;
            label1.Text = "Ad ve Soyad";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 192);
            button3.Location = new Point(17, 291);
            button3.Name = "button3";
            button3.Size = new Size(78, 62);
            button3.TabIndex = 3;
            button3.Text = "Öğrenci Güncelleme";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // silmebuton
            // 
            silmebuton.BackColor = Color.FromArgb(255, 255, 192);
            silmebuton.Location = new Point(17, 226);
            silmebuton.Name = "silmebuton";
            silmebuton.Size = new Size(78, 51);
            silmebuton.TabIndex = 2;
            silmebuton.Text = "Öğrenci Sil";
            silmebuton.UseVisualStyleBackColor = false;
            silmebuton.Click += silmebuton_Click;
            // 
            // ogrencieklebuton
            // 
            ogrencieklebuton.BackColor = Color.FromArgb(255, 255, 192);
            ogrencieklebuton.Location = new Point(17, 172);
            ogrencieklebuton.Name = "ogrencieklebuton";
            ogrencieklebuton.Size = new Size(78, 48);
            ogrencieklebuton.TabIndex = 1;
            ogrencieklebuton.Text = "Öğrenci ekle";
            ogrencieklebuton.UseVisualStyleBackColor = false;
            ogrencieklebuton.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ImeMode = ImeMode.NoControl;
            dataGridView1.Location = new Point(-3, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(334, 169);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // ogretmenbilgibutton
            // 
            ogretmenbilgibutton.BackColor = Color.FromArgb(128, 255, 128);
            ogretmenbilgibutton.Location = new Point(369, 0);
            ogretmenbilgibutton.Name = "ogretmenbilgibutton";
            ogretmenbilgibutton.Size = new Size(228, 130);
            ogretmenbilgibutton.TabIndex = 1;
            ogretmenbilgibutton.Text = "Öğretmen Bilgi";
            ogretmenbilgibutton.UseVisualStyleBackColor = false;
            ogretmenbilgibutton.Click += ogretmenbilgibutton_Click;
            // 
            // ogrencibilgibutton
            // 
            ogrencibilgibutton.BackColor = Color.FromArgb(128, 255, 128);
            ogrencibilgibutton.Location = new Point(3, 0);
            ogrencibilgibutton.Name = "ogrencibilgibutton";
            ogrencibilgibutton.Size = new Size(220, 130);
            ogrencibilgibutton.TabIndex = 0;
            ogrencibilgibutton.Text = "Öğrenci Bilgi";
            ogrencibilgibutton.UseVisualStyleBackColor = false;
            ogrencibilgibutton.Click += ogrencibilgibutton_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 568);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(yoneticisifretetxt);
            Controls.Add(yoneticiadtext);
            Controls.Add(yoneticisifrelabel);
            Controls.Add(yoneticiadlabel);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            panel1.ResumeLayout(false);
            ogretmenbilgipanel.ResumeLayout(false);
            ogretmenbilgipanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ogrencibilgipanel.ResumeLayout(false);
            ogrencibilgipanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label yoneticiadlabel;
        private Label yoneticisifrelabel;
        private TextBox yoneticiadtext;
        private TextBox yoneticisifretetxt;
        private Button button1;
        private Panel panel1;
        private Button ogretmenbilgibutton;
        private Button ogrencibilgibutton;
        private Panel ogretmenbilgipanel;
        private Panel ogrencibilgipanel;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Button ogrencieklebuton;
        private Button button3;
        private Button silmebuton;
        private Button ogretmenguncellebuton;
        private Button ogretmensilbuton;
        private Button ogretmeneklebuton;
        private TextBox ogrencinotextbox;
        private Label label2;
        private TextBox ogrenciadtextbox;
        private Label label1;
        private TextBox ogrencisifretextbox;
        private Label label3;
        private TextBox ogrenciidtextbox;
        private Label label4;
        private TextBox ogretmensifretextbox;
        private Label label8;
        private TextBox ogretmenidtextbox;
        private Label label7;
        private TextBox ogretmensicilnotextbox;
        private Label label6;
        private TextBox ogretmenadtextbox;
        private Label label5;
        private TextBox verdigiderslertextbox;
        private Label label9;
        private Button dersecimbuton;
    }
}