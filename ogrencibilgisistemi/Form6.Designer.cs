namespace yazlab3
{
    partial class Form6
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            listBox1 = new ListBox();
            rastgelebuton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Location = new Point(110, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 0;
            label1.Text = "DERS SEÇİMİ TABLOSU";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(422, 268);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 255, 255);
            label2.Location = new Point(516, 9);
            label2.Name = "label2";
            label2.Size = new Size(262, 20);
            label2.TabIndex = 2;
            label2.Text = "DERS SEÇİMİ YAPMAMIŞ ÖĞRENCİLER";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(533, 44);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(220, 244);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // rastgelebuton
            // 
            rastgelebuton.BackColor = Color.FromArgb(128, 255, 255);
            rastgelebuton.Location = new Point(567, 326);
            rastgelebuton.Name = "rastgelebuton";
            rastgelebuton.Size = new Size(165, 53);
            rastgelebuton.TabIndex = 4;
            rastgelebuton.Text = "RASTGELE ATAMA YAP";
            rastgelebuton.UseVisualStyleBackColor = false;
            rastgelebuton.Click += rastgelebuton_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rastgelebuton);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private ListBox listBox1;
        private Button rastgelebuton;
    }
}