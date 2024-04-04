namespace yazlab3
{
    partial class Form3
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
            ogretmenadlabel = new Label();
            ogretmensifrelabel = new Label();
            oretmenadtext = new TextBox();
            ogretmensifretext = new TextBox();
            ogretmengirisbuton = new Button();
            panel1 = new Panel();
            listBox1 = new ListBox();
            label3 = new Label();
            secimonaylabuton = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            dersisecenogrencilabel = new Label();
            button1 = new Button();
            panel3 = new Panel();
            gelenkutusulistview = new ListView();
            gelenkutusubuton = new Button();
            gonderbuton = new Button();
            mesajtextbox = new TextBox();
            mesajcombobox = new ComboBox();
            label4 = new Label();
            panel2 = new Panel();
            mesajlarbuton = new Button();
            dersecimbutton = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ogretmenadlabel
            // 
            ogretmenadlabel.AutoSize = true;
            ogretmenadlabel.BackColor = Color.FromArgb(255, 224, 192);
            ogretmenadlabel.Location = new Point(251, 87);
            ogretmenadlabel.Name = "ogretmenadlabel";
            ogretmenadlabel.Size = new Size(109, 20);
            ogretmenadlabel.TabIndex = 0;
            ogretmenadlabel.Text = "KULLANICI ADI";
            ogretmenadlabel.Click += ogretmenadlabel_Click;
            // 
            // ogretmensifrelabel
            // 
            ogretmensifrelabel.AutoSize = true;
            ogretmensifrelabel.BackColor = Color.FromArgb(255, 224, 192);
            ogretmensifrelabel.Location = new Point(251, 186);
            ogretmensifrelabel.Name = "ogretmensifrelabel";
            ogretmensifrelabel.Size = new Size(45, 20);
            ogretmensifrelabel.TabIndex = 1;
            ogretmensifrelabel.Text = "ŞİFRE";
            ogretmensifrelabel.Click += ogretmensifrelabel_Click;
            // 
            // oretmenadtext
            // 
            oretmenadtext.BackColor = Color.FromArgb(192, 255, 192);
            oretmenadtext.Location = new Point(251, 121);
            oretmenadtext.Name = "oretmenadtext";
            oretmenadtext.Size = new Size(246, 27);
            oretmenadtext.TabIndex = 2;
            oretmenadtext.TextChanged += oretmenadtext_TextChanged;
            // 
            // ogretmensifretext
            // 
            ogretmensifretext.BackColor = Color.FromArgb(192, 255, 192);
            ogretmensifretext.Location = new Point(254, 235);
            ogretmensifretext.Name = "ogretmensifretext";
            ogretmensifretext.Size = new Size(243, 27);
            ogretmensifretext.TabIndex = 3;
            ogretmensifretext.TextChanged += ogretmensifretext_TextChanged;
            // 
            // ogretmengirisbuton
            // 
            ogretmengirisbuton.BackColor = Color.Lime;
            ogretmengirisbuton.Location = new Point(304, 287);
            ogretmengirisbuton.Name = "ogretmengirisbuton";
            ogretmengirisbuton.Size = new Size(127, 90);
            ogretmengirisbuton.TabIndex = 4;
            ogretmengirisbuton.Text = "GİRİŞ";
            ogretmengirisbuton.UseVisualStyleBackColor = false;
            ogretmengirisbuton.Click += ogretmengirisbuton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(secimonaylabuton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(checkedListBox1);
            panel1.Controls.Add(dersisecenogrencilabel);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1007, 453);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(529, 123);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(221, 144);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 192, 192);
            label3.Location = new Point(542, 100);
            label3.Name = "label3";
            label3.Size = new Size(231, 20);
            label3.TabIndex = 6;
            label3.Text = "DERSİ ONAYLANAN ÖĞRENCİLER";
            label3.Click += label3_Click;
            // 
            // secimonaylabuton
            // 
            secimonaylabuton.BackColor = Color.FromArgb(128, 255, 128);
            secimonaylabuton.Location = new Point(318, 289);
            secimonaylabuton.Name = "secimonaylabuton";
            secimonaylabuton.Size = new Size(140, 98);
            secimonaylabuton.TabIndex = 5;
            secimonaylabuton.Text = "SEÇİMİ ONAYLA";
            secimonaylabuton.UseVisualStyleBackColor = false;
            secimonaylabuton.Click += secimonaylabuton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 192);
            label2.Location = new Point(276, 100);
            label2.Name = "label2";
            label2.Size = new Size(210, 20);
            label2.TabIndex = 4;
            label2.Text = "ONAY BEKLEYEN ÖĞRENCİLER";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 156);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(268, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.Location = new Point(59, 100);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 2;
            label1.Text = "VERDİĞİNİZ DERSLER";
            label1.Click += label1_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(276, 128);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(247, 136);
            checkedListBox1.TabIndex = 1;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // dersisecenogrencilabel
            // 
            dersisecenogrencilabel.AutoSize = true;
            dersisecenogrencilabel.BackColor = Color.FromArgb(128, 255, 128);
            dersisecenogrencilabel.Location = new Point(285, 32);
            dersisecenogrencilabel.Name = "dersisecenogrencilabel";
            dersisecenogrencilabel.Size = new Size(117, 20);
            dersisecenogrencilabel.TabIndex = 0;
            dersisecenogrencilabel.Text = "DERS TALEPLERİ";
            dersisecenogrencilabel.Click += dersisecenogrencilabel_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(592, 289);
            button1.Name = "button1";
            button1.Size = new Size(127, 90);
            button1.TabIndex = 8;
            button1.Text = "ONAYI GERİ ÇEK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(gelenkutusulistview);
            panel3.Controls.Add(gelenkutusubuton);
            panel3.Controls.Add(gonderbuton);
            panel3.Controls.Add(mesajtextbox);
            panel3.Controls.Add(mesajcombobox);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1007, 453);
            panel3.TabIndex = 9;
            // 
            // gelenkutusulistview
            // 
            gelenkutusulistview.Location = new Point(466, 66);
            gelenkutusulistview.Name = "gelenkutusulistview";
            gelenkutusulistview.Size = new Size(358, 272);
            gelenkutusulistview.TabIndex = 5;
            gelenkutusulistview.UseCompatibleStateImageBehavior = false;
            // 
            // gelenkutusubuton
            // 
            gelenkutusubuton.BackColor = Color.FromArgb(255, 192, 192);
            gelenkutusubuton.Location = new Point(533, 9);
            gelenkutusubuton.Name = "gelenkutusubuton";
            gelenkutusubuton.Size = new Size(209, 51);
            gelenkutusubuton.TabIndex = 4;
            gelenkutusubuton.Text = "GELEN KUTUSU";
            gelenkutusubuton.UseVisualStyleBackColor = false;
            gelenkutusubuton.Click += gelenkutusubuton_Click;
            // 
            // gonderbuton
            // 
            gonderbuton.BackColor = Color.FromArgb(128, 255, 128);
            gonderbuton.Location = new Point(76, 205);
            gonderbuton.Name = "gonderbuton";
            gonderbuton.Size = new Size(164, 107);
            gonderbuton.TabIndex = 3;
            gonderbuton.Text = "GÖNDER";
            gonderbuton.UseVisualStyleBackColor = false;
            gonderbuton.Click += gonderbuton_Click;
            // 
            // mesajtextbox
            // 
            mesajtextbox.Location = new Point(29, 112);
            mesajtextbox.Name = "mesajtextbox";
            mesajtextbox.Size = new Size(249, 27);
            mesajtextbox.TabIndex = 2;
            // 
            // mesajcombobox
            // 
            mesajcombobox.FormattingEnabled = true;
            mesajcombobox.Location = new Point(29, 60);
            mesajcombobox.Name = "mesajcombobox";
            mesajcombobox.Size = new Size(249, 28);
            mesajcombobox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 192, 192);
            label4.Location = new Point(29, 19);
            label4.Name = "label4";
            label4.Size = new Size(261, 20);
            label4.TabIndex = 0;
            label4.Text = "MESAJ GÖNDERİLECEK KİŞİYİ SEÇİNİZ";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(mesajlarbuton);
            panel2.Controls.Add(dersecimbutton);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1007, 453);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // mesajlarbuton
            // 
            mesajlarbuton.BackColor = Color.FromArgb(192, 255, 255);
            mesajlarbuton.Location = new Point(528, 124);
            mesajlarbuton.Name = "mesajlarbuton";
            mesajlarbuton.Size = new Size(254, 106);
            mesajlarbuton.TabIndex = 6;
            mesajlarbuton.Text = "MESAJLAR";
            mesajlarbuton.UseVisualStyleBackColor = false;
            mesajlarbuton.Click += mesajlarbuton_Click;
            // 
            // dersecimbutton
            // 
            dersecimbutton.BackColor = Color.FromArgb(192, 255, 192);
            dersecimbutton.Location = new Point(122, 121);
            dersecimbutton.Name = "dersecimbutton";
            dersecimbutton.Size = new Size(243, 113);
            dersecimbutton.TabIndex = 0;
            dersecimbutton.Text = "DERS SEÇİM EKRANI";
            dersecimbutton.UseVisualStyleBackColor = false;
            dersecimbutton.Click += dersecimbutton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 453);
            Controls.Add(panel2);
            Controls.Add(ogretmengirisbuton);
            Controls.Add(ogretmensifretext);
            Controls.Add(oretmenadtext);
            Controls.Add(ogretmensifrelabel);
            Controls.Add(ogretmenadlabel);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ogretmenadlabel;
        private Label ogretmensifrelabel;
        private TextBox oretmenadtext;
        private TextBox ogretmensifretext;
        private Button ogretmengirisbuton;
        private Panel panel1;
        private Label dersisecenogrencilabel;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private Label label2;
        private ComboBox comboBox1;
        private Button secimonaylabuton;
        private Button button1;
        private ListBox listBox1;
        private Label label3;
        private Panel panel2;
        private Button mesajlarbuton;
        private Button dersecimbutton;
        private Panel panel3;
        private TextBox mesajtextbox;
        private ComboBox mesajcombobox;
        private Label label4;
        private ListView gelenkutusulistview;
        private Button gelenkutusubuton;
        private Button gonderbuton;
    }
}