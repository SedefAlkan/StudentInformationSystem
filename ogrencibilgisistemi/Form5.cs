using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace yazlab3
{
    public partial class Form5 : Form
    {

        public Form5()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel7.Visible = false;
            FillComboBoxWithTeachers();

        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dersisimlerisecpanel_Click(object sender, EventArgs e)
        {

        }

        private void dersisimcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string selectedDersIsim = dersisimcombobox.SelectedItem.ToString();

           
            List<string> ogretmenAdlari = GetOgretmenAdlari(selectedDersIsim);
            ogretmensecimcombobox.Items.Clear();
            foreach (string ogretmenAdi in ogretmenAdlari)
            {
                ogretmensecimcombobox.Items.Add(ogretmenAdi);
            }
        }

        private List<string> GetOgretmenAdlari(string dersIsim)
        {
            List<string> ogretmenAdlari = new List<string>();
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234"))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT ogretmenad FROM ogretmen WHERE verdigidersler = @DersIsim", conn))
                    {
                        cmd.Parameters.AddWithValue("DersIsim", dersIsim);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ogretmenAdlari.Add(reader["ogretmenad"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            return ogretmenAdlari;
        }

        private void ogretmenseclabel_Click(object sender, EventArgs e)
        {

        }

        private void ogretmensecimcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string selectedDersIsim = dersisimcombobox.SelectedItem.ToString();
            string selectedOgretmen = ogretmensecimcombobox.SelectedItem.ToString();

           
            listBox1.Items.Add("Seçilen Ders: " + selectedDersIsim);
            listBox1.Items.Add("Seçilen Öğretmen: " + selectedOgretmen);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string ogrenciAdi = ""; // Öğrenci adını tutacak değişken

        private void dersonaylabutton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234"))
            {
                try
                {
                    conn.Open();

                    
                    using (NpgsqlCommand gecisCmd = new NpgsqlCommand("SELECT ogrenciad FROM gecis ORDER BY eklenmetarihi DESC LIMIT 1", conn))
                    {
                        using (NpgsqlDataReader gecisReader = gecisCmd.ExecuteReader())
                        {
                            if (gecisReader.Read())
                            {
                                ogrenciAdi = gecisReader["ogrenciad"].ToString();
                            }
                        }
                    }

                   
                    List<string> secilenDersler = new List<string>();
                    List<string> secilenOgretmenler = new List<string>();
                    for (int i = 0; i < listBox1.Items.Count; i += 2)
                    {
                        string dersAdi = listBox1.Items[i].ToString().Replace("Seçilen Ders: ", "");
                        string ogretmenAdi = listBox1.Items[i + 1].ToString().Replace("Seçilen Öğretmen: ", "");
                        secilenDersler.Add(dersAdi);
                        secilenOgretmenler.Add(ogretmenAdi);
                    }

                    for (int i = 0; i < secilenDersler.Count; i++)
                    {
                        if (IsDersSelected(ogrenciAdi, secilenDersler[i], secilenOgretmenler[i], conn))
                        {
                            MessageBox.Show("Bu dersi daha önce seçtiniz.");
                        }
                        else
                        {
                            InsertDersSecim(ogrenciAdi, secilenDersler[i], secilenOgretmenler[i], conn);
                        }
                    }

                    MessageBox.Show("Ders seçiminiz başarıyla gerçekleştirilmiştir.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private bool IsDersSelected(string ogrenciAdi, string dersAdi, string ogretmenAdi, NpgsqlConnection conn)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(*) FROM dersecim WHERE ogrenciadsoyad = @OgrenciAdi AND secilendersler = @DersIsim AND secilenogretmen = @OgretmenAdi", conn))
            {
                cmd.Parameters.AddWithValue("OgrenciAdi", ogrenciAdi);
                cmd.Parameters.AddWithValue("DersIsim", dersAdi);
                cmd.Parameters.AddWithValue("OgretmenAdi", ogretmenAdi);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private void InsertDersSecim(string ogrenciAdi, string dersAdi, string ogretmenAdi, NpgsqlConnection conn)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO dersecim (secilendersler, secilenogretmen, ogrenciadsoyad) VALUES (@DersIsim, @OgretmenAdi, @OgrenciAdi)", conn))
            {
                cmd.Parameters.AddWithValue("DersIsim", dersAdi);
                cmd.Parameters.AddWithValue("OgretmenAdi", ogretmenAdi);
                cmd.Parameters.AddWithValue("OgrenciAdi", ogrenciAdi);
                cmd.ExecuteNonQuery();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void onaylananbuton_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;

           
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234"))
            {
                try
                {
                    conn.Open();

                    
                    string ogrenciAdiKullan = ogrenciAdi;

                   
                    string query = "SELECT secilendersler, secilenogretmen FROM dersecim WHERE ogrenciadsoyad = @OgrenciAdi AND onaylanmadurumu = true";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("OgrenciAdi", ogrenciAdiKullan);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            listBox2.Items.Clear();

                            while (reader.Read())
                            {
                                string courseName = reader["secilendersler"].ToString();
                                string teacherName = reader["secilenogretmen"].ToString();
                              
                                listBox2.Items.Add("Ders: " + courseName);
                                listBox2.Items.Add("Öğretmen: " + teacherName);
                                listBox2.Items.Add(""); 
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void onaybeklemebuton_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;

           
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234"))
            {
                try
                {
                    conn.Open();

                    
                    string ogrenciAdiKullan = ogrenciAdi;

                   
                    string query = "SELECT secilendersler, secilenogretmen FROM dersecim WHERE ogrenciadsoyad = @OgrenciAdi AND (onaylanmadurumu IS NULL OR onaylanmadurumu = false)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("OgrenciAdi", ogrenciAdiKullan);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                           
                            listBox3.Items.Clear();

                            while (reader.Read())
                            {
                                string courseName = reader["secilendersler"].ToString();
                                string teacherName = reader["secilenogretmen"].ToString();
                                
                                listBox3.Items.Add("Ders: " + courseName);
                                listBox3.Items.Add("Öğretmen: " + teacherName);
                                listBox3.Items.Add(""); 
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void mesajbuton_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel7.Visible = true;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void mesajcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FillComboBoxWithTeachers()
        {
           
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234"))
            {
                try
                {
                    conn.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT ogretmenad FROM ogretmen", conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                mesajcombobox.Items.Add(reader["ogretmenad"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void gonderbuton_Click(object sender, EventArgs e)
        {
            string ogrenciAdiKullan = ogrenciAdi; 
            string seciliOgretmenAdi = mesajcombobox.SelectedItem.ToString(); 
            string mesajMetni = textBox1.Text; 

            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234"))
            {
                try
                {
                    conn.Open();

                    
                    using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO mesaj (gonderen, alici, mesaj) VALUES (@Gonderen, @Alici, @Mesaj)", conn))
                    {
                        cmd.Parameters.AddWithValue("Gonderen", ogrenciAdi);
                        cmd.Parameters.AddWithValue("Alici", seciliOgretmenAdi);
                        cmd.Parameters.AddWithValue("Mesaj", mesajMetni);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Mesaj başarıyla gönderildi.");
                        textBox1.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void gericekbuton_Click(object sender, EventArgs e)
        {

            
            if (listBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir ders seçin.");
                return;
            }

          
            string ogrenciAdiKullan = ogrenciAdi;
            int selectedIdx = listBox3.SelectedIndex;
            string seciliDersAdi = listBox3.Items[selectedIdx].ToString().Replace("Ders: ", "");
            string seciliOgretmenAdi = listBox3.Items[selectedIdx + 1].ToString().Replace("Öğretmen: ", "");

           
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234"))
            {
                try
                {
                    conn.Open();

                    string query = "DELETE FROM dersecim WHERE ogrenciadsoyad = @OgrenciAdi AND secilendersler = @DersAdi AND secilenogretmen = @OgretmenAdi";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("OgrenciAdi", ogrenciAdiKullan);
                        cmd.Parameters.AddWithValue("DersAdi", seciliDersAdi);
                        cmd.Parameters.AddWithValue("OgretmenAdi", seciliOgretmenAdi);

                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Ders seçimi başarıyla geri çekildi.");
                        }
                        else
                        {
                            MessageBox.Show("Ders seçimi geri çekilemedi.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }

           
            listBox3.Items.RemoveAt(selectedIdx + 1); // Öğretmeni kaldır
            listBox3.Items.RemoveAt(selectedIdx);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gelenmesajbuton_Click(object sender, EventArgs e)
        {
            // Öğrenci adını alın
            string ogrenciAdiKullan = ogrenciAdi;

          
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234"))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT gonderen, mesaj FROM mesaj WHERE alici = @Alici";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("Alici", ogrenciAdiKullan);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                           
                            gelenmesajlistview.Items.Clear();

                           
                            gelenmesajlistview.View = View.Details;

                           
                            gelenmesajlistview.Columns.Add("Gönderen", 150);
                            gelenmesajlistview.Columns.Add("Mesaj", 300);

                            while (reader.Read())
                            {
                                string gonderenAdi = reader["gonderen"].ToString();
                                string mesajMetni = reader["mesaj"].ToString();

                                
                                ListViewItem item = new ListViewItem(gonderenAdi);
                                item.SubItems.Add(mesajMetni);
                                gelenmesajlistview.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }


        private void gelenmesajlistview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
