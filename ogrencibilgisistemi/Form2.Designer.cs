namespace yazlab3
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
            ogrencinolabel = new Label();
            sifrelabel = new Label();
            ogrencinotext = new TextBox();
            sifretext = new TextBox();
            girisbuton = new Button();
            panel1 = new Panel();
            derssecimpanel = new Panel();
            alınanderspanel = new Panel();
            dataGridViewAlinanDersler = new DataGridView();
            derssecimbutton = new Button();
            alınandersbutton = new Button();
            transkriptbuton = new Button();
            transkriptlabel = new Label();
            panel1.SuspendLayout();
            derssecimpanel.SuspendLayout();
            alınanderspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlinanDersler).BeginInit();
            SuspendLayout();
            // 
            // ogrencinolabel
            // 
            ogrencinolabel.AutoSize = true;
            ogrencinolabel.BackColor = Color.FromArgb(255, 224, 192);
            ogrencinolabel.Location = new Point(221, 106);
            ogrencinolabel.Name = "ogrencinolabel";
            ogrencinolabel.Size = new Size(150, 20);
            ogrencinolabel.TabIndex = 0;
            ogrencinolabel.Text = "ÖĞRENCİ NUMARASI";
            ogrencinolabel.Click += ogrencinolabel_Click;
            // 
            // sifrelabel
            // 
            sifrelabel.AutoSize = true;
            sifrelabel.BackColor = Color.FromArgb(255, 224, 192);
            sifrelabel.Location = new Point(221, 193);
            sifrelabel.Name = "sifrelabel";
            sifrelabel.Size = new Size(45, 20);
            sifrelabel.TabIndex = 1;
            sifrelabel.Text = "ŞİFRE";
            sifrelabel.Click += sifrelabel_Click;
            // 
            // ogrencinotext
            // 
            ogrencinotext.BackColor = Color.FromArgb(192, 255, 192);
            ogrencinotext.Location = new Point(221, 139);
            ogrencinotext.Name = "ogrencinotext";
            ogrencinotext.Size = new Size(324, 27);
            ogrencinotext.TabIndex = 2;
            ogrencinotext.TextChanged += ogrencinotext_TextChanged;
            // 
            // sifretext
            // 
            sifretext.BackColor = Color.FromArgb(192, 255, 192);
            sifretext.Location = new Point(223, 235);
            sifretext.Name = "sifretext";
            sifretext.Size = new Size(322, 27);
            sifretext.TabIndex = 3;
            sifretext.TextChanged += sifretext_TextChanged;
            // 
            // girisbuton
            // 
            girisbuton.BackColor = Color.Lime;
            girisbuton.Location = new Point(290, 310);
            girisbuton.Name = "girisbuton";
            girisbuton.Size = new Size(169, 79);
            girisbuton.TabIndex = 4;
            girisbuton.Text = "GİRİŞ";
            girisbuton.UseVisualStyleBackColor = false;
            girisbuton.Click += girisbuton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(derssecimpanel);
            panel1.Controls.Add(transkriptbuton);
            panel1.Controls.Add(transkriptlabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // derssecimpanel
            // 
            derssecimpanel.Controls.Add(alınanderspanel);
            derssecimpanel.Controls.Add(derssecimbutton);
            derssecimpanel.Controls.Add(alınandersbutton);
            derssecimpanel.Location = new Point(3, 3);
            derssecimpanel.Name = "derssecimpanel";
            derssecimpanel.Size = new Size(776, 435);
            derssecimpanel.TabIndex = 2;
            derssecimpanel.Paint += derssecimpanel_Paint;
            // 
            // alınanderspanel
            // 
            alınanderspanel.Controls.Add(dataGridViewAlinanDersler);
            alınanderspanel.Location = new Point(15, 9);
            alınanderspanel.Name = "alınanderspanel";
            alınanderspanel.Size = new Size(365, 432);
            alınanderspanel.TabIndex = 2;
            alınanderspanel.Paint += alınanderspanel_Paint;
            // 
            // dataGridViewAlinanDersler
            // 
            dataGridViewAlinanDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlinanDersler.Location = new Point(22, 6);
            dataGridViewAlinanDersler.Name = "dataGridViewAlinanDersler";
            dataGridViewAlinanDersler.RowHeadersWidth = 51;
            dataGridViewAlinanDersler.RowTemplate.Height = 29;
            dataGridViewAlinanDersler.Size = new Size(340, 429);
            dataGridViewAlinanDersler.TabIndex = 0;
            dataGridViewAlinanDersler.CellContentClick += dataGridViewAlinanDersler_CellContentClick;
            // 
            // derssecimbutton
            // 
            derssecimbutton.BackColor = Color.FromArgb(192, 255, 192);
            derssecimbutton.Location = new Point(426, 68);
            derssecimbutton.Name = "derssecimbutton";
            derssecimbutton.Size = new Size(252, 162);
            derssecimbutton.TabIndex = 1;
            derssecimbutton.Text = "DERS SEÇİMİ";
            derssecimbutton.UseVisualStyleBackColor = false;
            derssecimbutton.Click += derssecimbutton_Click;
            // 
            // alınandersbutton
            // 
            alınandersbutton.BackColor = Color.FromArgb(192, 255, 192);
            alınandersbutton.Location = new Point(50, 68);
            alınandersbutton.Name = "alınandersbutton";
            alınandersbutton.Size = new Size(264, 162);
            alınandersbutton.TabIndex = 0;
            alınandersbutton.Text = "ÖNCEKİ DERS BİLGİLERİ\r\n";
            alınandersbutton.UseVisualStyleBackColor = false;
            alınandersbutton.Click += alınandersbutton_Click;
            // 
            // transkriptbuton
            // 
            transkriptbuton.BackColor = Color.FromArgb(128, 255, 128);
            transkriptbuton.Location = new Point(290, 193);
            transkriptbuton.Name = "transkriptbuton";
            transkriptbuton.Size = new Size(201, 100);
            transkriptbuton.TabIndex = 1;
            transkriptbuton.Text = "YÜKLE";
            transkriptbuton.UseVisualStyleBackColor = false;
            transkriptbuton.Click += transkriptbuton_Click;
            // 
            // transkriptlabel
            // 
            transkriptlabel.AutoSize = true;
            transkriptlabel.BackColor = Color.FromArgb(255, 224, 192);
            transkriptlabel.Location = new Point(272, 139);
            transkriptlabel.Name = "transkriptlabel";
            transkriptlabel.Size = new Size(248, 20);
            transkriptlabel.TabIndex = 0;
            transkriptlabel.Text = "TRANSKRİPT BELGESİNİ YÜKLEYİNİZ";
            transkriptlabel.Click += transkriptlabel_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(girisbuton);
            Controls.Add(sifretext);
            Controls.Add(ogrencinotext);
            Controls.Add(sifrelabel);
            Controls.Add(ogrencinolabel);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            derssecimpanel.ResumeLayout(false);
            alınanderspanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlinanDersler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ogrencinolabel;
        private Label sifrelabel;
        private TextBox ogrencinotext;
        private TextBox sifretext;
        private Button girisbuton;
        private Panel panel1;
        private Label transkriptlabel;
        private Button transkriptbuton;
        private Panel derssecimpanel;
        private Button derssecimbutton;
        private Button alınandersbutton;
        private Panel alınanderspanel;
        private DataGridView dataGridViewAlinanDersler;
    }
}