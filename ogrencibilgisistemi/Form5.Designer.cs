namespace yazlab3
{
    partial class Form5
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
            derssecimlabel = new Label();
            dersisimcombobox = new ComboBox();
            dersisimlerisecpanel = new Label();
            ogretmenseclabel = new Label();
            ogretmensecimcombobox = new ComboBox();
            listBox1 = new ListBox();
            dersonaylabutton = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            textBox1 = new TextBox();
            gonderbuton = new Button();
            label1 = new Label();
            mesajcombobox = new ComboBox();
            panel3 = new Panel();
            gericekbuton = new Button();
            listBox3 = new ListBox();
            panel2 = new Panel();
            listBox2 = new ListBox();
            onaybeklemebuton = new Button();
            mesajbuton = new Button();
            onaylananbuton = new Button();
            panel5 = new Panel();
            gelenmesajbuton = new Button();
            gelenmesajlistview = new ListView();
            panel6 = new Panel();
            panel7 = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // derssecimlabel
            // 
            derssecimlabel.AutoSize = true;
            derssecimlabel.BackColor = Color.FromArgb(255, 192, 192);
            derssecimlabel.Location = new Point(187, 59);
            derssecimlabel.Name = "derssecimlabel";
            derssecimlabel.Size = new Size(475, 20);
            derssecimlabel.TabIndex = 0;
            derssecimlabel.Text = "LÜTFEN SEÇMEK İSTEDİĞİNİZ DERSLERİ VE ÖĞRETMENLERİNİ SEÇİNİZ";
            derssecimlabel.Click += label1_Click;
            // 
            // dersisimcombobox
            // 
            dersisimcombobox.FormattingEnabled = true;
            dersisimcombobox.Items.AddRange(new object[] { "Mikroişlemci Sistemleri", "Mantıksal Tasarım ve Uygulamaları", "Sayısal Yöntemler", "Bilgisayar Bilimlerinde Yeni Teknolojiler", "İşaret ve Sistemler", "SPOR VE EGZERSİZ BESLENMESİ", "Yazılım Laboratuvarı - I", "İşletim Sistemleri" });
            dersisimcombobox.Location = new Point(35, 145);
            dersisimcombobox.Name = "dersisimcombobox";
            dersisimcombobox.Size = new Size(319, 28);
            dersisimcombobox.TabIndex = 1;
            dersisimcombobox.SelectedIndexChanged += dersisimcombobox_SelectedIndexChanged;
            // 
            // dersisimlerisecpanel
            // 
            dersisimlerisecpanel.AutoSize = true;
            dersisimlerisecpanel.BackColor = Color.FromArgb(192, 255, 192);
            dersisimlerisecpanel.Location = new Point(35, 112);
            dersisimlerisecpanel.Name = "dersisimlerisecpanel";
            dersisimlerisecpanel.Size = new Size(327, 20);
            dersisimlerisecpanel.TabIndex = 2;
            dersisimlerisecpanel.Text = "LÜTFEN SEÇMEK İSTEDİĞİNİZ DERSLERİ GİRİNİZ";
            dersisimlerisecpanel.Click += dersisimlerisecpanel_Click;
            // 
            // ogretmenseclabel
            // 
            ogretmenseclabel.AutoSize = true;
            ogretmenseclabel.BackColor = Color.FromArgb(192, 255, 192);
            ogretmenseclabel.Location = new Point(490, 112);
            ogretmenseclabel.Name = "ogretmenseclabel";
            ogretmenseclabel.Size = new Size(375, 20);
            ogretmenseclabel.TabIndex = 3;
            ogretmenseclabel.Text = "DERSİ HANGİ HOCADAN ALMAK İSTEDİĞİNİZİ SEÇİNİZ";
            ogretmenseclabel.Click += ogretmenseclabel_Click;
            // 
            // ogretmensecimcombobox
            // 
            ogretmensecimcombobox.FormattingEnabled = true;
            ogretmensecimcombobox.Items.AddRange(new object[] { "" });
            ogretmensecimcombobox.Location = new Point(490, 145);
            ogretmensecimcombobox.Name = "ogretmensecimcombobox";
            ogretmensecimcombobox.Size = new Size(375, 28);
            ogretmensecimcombobox.TabIndex = 4;
            ogretmensecimcombobox.SelectedIndexChanged += ogretmensecimcombobox_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(199, 193);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(463, 224);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // dersonaylabutton
            // 
            dersonaylabutton.BackColor = Color.FromArgb(128, 255, 128);
            dersonaylabutton.Location = new Point(359, 438);
            dersonaylabutton.Name = "dersonaylabutton";
            dersonaylabutton.Size = new Size(152, 29);
            dersonaylabutton.TabIndex = 6;
            dersonaylabutton.Text = "ONAYLA";
            dersonaylabutton.UseVisualStyleBackColor = false;
            dersonaylabutton.Click += dersonaylabutton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(onaybeklemebuton);
            panel1.Controls.Add(mesajbuton);
            panel1.Controls.Add(onaylananbuton);
            panel1.Location = new Point(12, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(892, 495);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(gonderbuton);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(mesajcombobox);
            panel4.Location = new Point(595, 79);
            panel4.Name = "panel4";
            panel4.Size = new Size(280, 189);
            panel4.TabIndex = 8;
            panel4.Paint += panel4_Paint;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 27);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // gonderbuton
            // 
            gonderbuton.BackColor = Color.FromArgb(0, 192, 0);
            gonderbuton.Location = new Point(16, 108);
            gonderbuton.Name = "gonderbuton";
            gonderbuton.Size = new Size(180, 50);
            gonderbuton.TabIndex = 8;
            gonderbuton.Text = "GÖNDER";
            gonderbuton.UseVisualStyleBackColor = false;
            gonderbuton.Click += gonderbuton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(16, 5);
            label1.Name = "label1";
            label1.Size = new Size(223, 20);
            label1.TabIndex = 7;
            label1.Text = "Mesaj Gönderilecek kişiyi seçiniz";
            label1.Click += label1_Click_1;
            // 
            // mesajcombobox
            // 
            mesajcombobox.FormattingEnabled = true;
            mesajcombobox.Location = new Point(16, 28);
            mesajcombobox.Name = "mesajcombobox";
            mesajcombobox.Size = new Size(223, 28);
            mesajcombobox.TabIndex = 6;
            mesajcombobox.SelectedIndexChanged += mesajcombobox_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(gericekbuton);
            panel3.Controls.Add(listBox3);
            panel3.Location = new Point(298, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(266, 375);
            panel3.TabIndex = 7;
            panel3.Paint += panel3_Paint;
            // 
            // gericekbuton
            // 
            gericekbuton.BackColor = Color.IndianRed;
            gericekbuton.Location = new Point(72, 310);
            gericekbuton.Name = "gericekbuton";
            gericekbuton.Size = new Size(129, 49);
            gericekbuton.TabIndex = 5;
            gericekbuton.Text = "İSTEĞİ GERİ ÇEK";
            gericekbuton.UseVisualStyleBackColor = false;
            gericekbuton.Click += gericekbuton_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Location = new Point(3, 40);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(243, 264);
            listBox3.TabIndex = 4;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(listBox2);
            panel2.Location = new Point(6, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(263, 375);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(3, 30);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(234, 304);
            listBox2.TabIndex = 3;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // onaybeklemebuton
            // 
            onaybeklemebuton.BackColor = Color.FromArgb(192, 255, 192);
            onaybeklemebuton.Location = new Point(331, 0);
            onaybeklemebuton.Name = "onaybeklemebuton";
            onaybeklemebuton.Size = new Size(213, 73);
            onaybeklemebuton.TabIndex = 2;
            onaybeklemebuton.Text = "ONAYLANMAMIŞ DERSLER";
            onaybeklemebuton.UseVisualStyleBackColor = false;
            onaybeklemebuton.Click += onaybeklemebuton_Click;
            // 
            // mesajbuton
            // 
            mesajbuton.BackColor = Color.FromArgb(192, 255, 255);
            mesajbuton.Location = new Point(618, 3);
            mesajbuton.Name = "mesajbuton";
            mesajbuton.Size = new Size(218, 73);
            mesajbuton.TabIndex = 1;
            mesajbuton.Text = "MESAJLAR";
            mesajbuton.UseVisualStyleBackColor = false;
            mesajbuton.Click += mesajbuton_Click;
            // 
            // onaylananbuton
            // 
            onaylananbuton.BackColor = Color.FromArgb(255, 255, 192);
            onaylananbuton.Location = new Point(6, 3);
            onaylananbuton.Name = "onaylananbuton";
            onaylananbuton.Size = new Size(220, 78);
            onaylananbuton.TabIndex = 0;
            onaylananbuton.Text = "ONAYLANAN DERSLER";
            onaylananbuton.UseVisualStyleBackColor = false;
            onaylananbuton.Click += onaylananbuton_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(3, 187);
            panel5.Name = "panel5";
            panel5.Size = new Size(274, 195);
            panel5.TabIndex = 9;
            // 
            // gelenmesajbuton
            // 
            gelenmesajbuton.BackColor = Color.FromArgb(255, 192, 192);
            gelenmesajbuton.Location = new Point(15, 3);
            gelenmesajbuton.Name = "gelenmesajbuton";
            gelenmesajbuton.Size = new Size(181, 31);
            gelenmesajbuton.TabIndex = 9;
            gelenmesajbuton.Text = "GELEN MESAJLAR";
            gelenmesajbuton.UseVisualStyleBackColor = false;
            gelenmesajbuton.Click += gelenmesajbuton_Click;
            // 
            // gelenmesajlistview
            // 
            gelenmesajlistview.Location = new Point(15, 40);
            gelenmesajlistview.Name = "gelenmesajlistview";
            gelenmesajlistview.Size = new Size(233, 155);
            gelenmesajlistview.TabIndex = 10;
            gelenmesajlistview.UseCompatibleStateImageBehavior = false;
            gelenmesajlistview.SelectedIndexChanged += gelenmesajlistview_SelectedIndexChanged;
            // 
            // panel6
            // 
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 177);
            panel6.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.Controls.Add(gelenmesajlistview);
            panel7.Controls.Add(gelenmesajbuton);
            panel7.Location = new Point(595, 269);
            panel7.Name = "panel7";
            panel7.Size = new Size(294, 210);
            panel7.TabIndex = 9;
            panel7.Paint += panel7_Paint;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 526);
            Controls.Add(panel1);
            Controls.Add(dersonaylabutton);
            Controls.Add(listBox1);
            Controls.Add(ogretmensecimcombobox);
            Controls.Add(ogretmenseclabel);
            Controls.Add(dersisimlerisecpanel);
            Controls.Add(dersisimcombobox);
            Controls.Add(derssecimlabel);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label derssecimlabel;
        private ComboBox dersisimcombobox;
        private Label dersisimlerisecpanel;
        private Label ogretmenseclabel;
        private ComboBox ogretmensecimcombobox;
        private ListBox listBox1;
        private Button dersonaylabutton;
        private Panel panel1;
        private ListBox listBox3;
        private ListBox listBox2;
        private Button onaybeklemebuton;
        private Button mesajbuton;
        private Button onaylananbuton;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private ComboBox mesajcombobox;
        private Button gonderbuton;
        private Button gericekbuton;
        private TextBox textBox1;
        private ListView gelenmesajlistview;
        private Button gelenmesajbuton;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
    }
}