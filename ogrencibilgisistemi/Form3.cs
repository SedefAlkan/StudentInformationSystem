using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace yazlab3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel3.Visible = false;
            panel2.Visible = false;
        }

        private void ogretmenadlabel_Click(object sender, EventArgs e)
        {

        }

        private void oretmenadtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void ogretmensifrelabel_Click(object sender, EventArgs e)
        {

        }

        private void ogretmensifretext_TextChanged(object sender, EventArgs e)
        {

        }

        private void ogretmengirisbuton_Click(object sender, EventArgs e)
        {
            string ogretmenNo = oretmenadtext.Text;
            string ogretmensifre = ogretmensifretext.Text;

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234");

            try
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(*) FROM ogretmen WHERE ogretmensicilno = @OgrenciNo AND ogretmensifre = @Sifre", conn);
                cmd.Parameters.AddWithValue("OgrenciNo", ogretmenNo);
                cmd.Parameters.AddWithValue("Sifre", ogretmensifre);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    
                    panel2.Visible = true;

                   
                    ComboBoxDersleriDoldur(ogretmenNo);
                }
                else
                {
                    MessageBox.Show("Geçersiz kullanıcı adı veya şifre.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ComboBoxDersleriDoldur(string ogretmenNo)
        {
           
            comboBox1.Items.Clear();

           
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234"))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT verdigidersler FROM ogretmen WHERE ogretmensicilno = @OgretmenNo", conn))
                {
                    cmd.Parameters.AddWithValue("OgretmenNo", ogretmenNo);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ders = reader["verdigidersler"].ToString();
                            comboBox1.Items.Add(ders);
                        }
                    }
                }
            }
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            ogretmensifretext.PasswordChar = '*';
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234");

            try
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT adsoyad FROM ogrenci", conn);
                NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string ogrenciAdSoyad = reader["adsoyad"].ToString();
                    mesajcombobox.Items.Add(ogrenciAdSoyad);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dersisecenogrencilabel_Click(object sender, EventArgs e)
        {

        }
        private void SecilenDersinOnaylanmisOgrencileriniGetir(string secilenDers, string ogretmenNo, string ogretmenSifre)
        {
            listBox1.Items.Clear();

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234");

            try
            {
                conn.Open();
                string ogretmenAdi = GetOgretmenAdi(ogretmenNo, ogretmenSifre, conn);

                if (string.IsNullOrEmpty(ogretmenAdi))
                {
                    MessageBox.Show("Öğretmen bilgileri doğrulanamadı.");
                    return;
                }

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT ogrenciadsoyad FROM dersecim WHERE secilendersler = @SecilenDers AND onaylanmadurumu = true AND secilenogretmen = @OgretmenAd", conn);
                cmd.Parameters.AddWithValue("SecilenDers", secilenDers);
                cmd.Parameters.AddWithValue("OgretmenAd", ogretmenAdi);

                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string ogrenciAdi = reader["ogrenciadsoyad"].ToString();
                    listBox1.Items.Add(ogrenciAdi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ogretmenNo = oretmenadtext.Text;
            string ogretmenSifre = ogretmensifretext.Text;
            string secilenDers = comboBox1.SelectedItem.ToString();
            SecilenDersinOgrencileriniGetir(secilenDers,ogretmenNo,ogretmenSifre); // Onaylanmamış öğrencileri almak için
            SecilenDersinOnaylanmisOgrencileriniGetir(secilenDers,ogretmenNo,ogretmenSifre); // Onaylanmış öğrencileri almak için
        }

        private void SecilenDersinOgrencileriniGetir(string secilenDers, string ogretmenNo, string ogretmenSifre)
        {
            checkedListBox1.Items.Clear();

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234");

            try
            {
                conn.Open();
                string ogretmenAdi = GetOgretmenAdi(ogretmenNo, ogretmenSifre, conn);

                if (string.IsNullOrEmpty(ogretmenAdi))
                {
                    MessageBox.Show("Öğretmen bilgileri doğrulanamadı.");
                    return;
                }

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT DISTINCT ogrenciadsoyad FROM dersecim WHERE secilendersler = @SecilenDers AND onaylanmadurumu IS NULL AND secilenogretmen = @OgretmenAd", conn);
                cmd.Parameters.AddWithValue("SecilenDers", secilenDers);
                cmd.Parameters.AddWithValue("OgretmenAd", ogretmenAdi);

                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string ogrenciAdi = reader["ogrenciadsoyad"].ToString();
                    checkedListBox1.Items.Add(ogrenciAdi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }





        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void secimonaylabuton_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234");

            try
            {
                conn.Open();

               
                string ogretmenNo = oretmenadtext.Text;
                string ogretmenSifre = ogretmensifretext.Text;

               
                string ogretmenAdi = GetOgretmenAdi(ogretmenNo, ogretmenSifre, conn);

                if (string.IsNullOrEmpty(ogretmenAdi))
                {
                    MessageBox.Show("Geçersiz öğretmen sicil no veya şifre.");
                    return;
                }

                // Seçilen ders
                string secilenDers = comboBox1.SelectedItem.ToString();

                // Seçilen dersin onaylanmamış öğrencilerini al
                List<string> onaylanmamisOgrenciler = new List<string>();

                foreach (string ogrenci in checkedListBox1.CheckedItems)
                {
                    onaylanmamisOgrenciler.Add(ogrenci);
                }

                foreach (string ogrenciAdi in onaylanmamisOgrenciler)
                {
                    
                    bool onayDurumu = IsDersOnaylandi(secilenDers, ogrenciAdi, ogretmenAdi, conn);

                    if (!onayDurumu)
                    {
                        
                        using (NpgsqlCommand cmd = new NpgsqlCommand("UPDATE dersecim SET onaylanmadurumu = true WHERE secilendersler = @SecilenDers AND ogrenciadsoyad = @OgrenciAdi AND secilenogretmen = @OgretmenAdi", conn))
                        {
                            cmd.Parameters.AddWithValue("SecilenDers", secilenDers);
                            cmd.Parameters.AddWithValue("OgrenciAdi", ogrenciAdi);
                            cmd.Parameters.AddWithValue("OgretmenAdi", ogretmenAdi);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                       
                        MessageBox.Show("Bu ders zaten onaylandı.");
                    }

                   
                    checkedListBox1.Items.Remove(ogrenciAdi);

                    
                    listBox1.Items.Add(ogrenciAdi);
                }

                MessageBox.Show("Öğrencilerin onay durumu güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private string GetOgretmenAdi(string ogretmenNo, string ogretmenSifre, NpgsqlConnection conn)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT ogretmenad FROM ogretmen WHERE ogretmensicilno = @OgretmenNo AND ogretmensifre = @Sifre", conn))
            {
                cmd.Parameters.AddWithValue("OgretmenNo", ogretmenNo);
                cmd.Parameters.AddWithValue("Sifre", ogretmenSifre);
                object result = cmd.ExecuteScalar();

                return result != null ? result.ToString() : string.Empty;
            }
        }


        private bool IsDersOnaylandi(string secilenDers, string ogrenciAdi, string ogretmenAdi, NpgsqlConnection conn)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT onaylanmadurumu FROM dersecim WHERE secilendersler = @SecilenDers AND ogrenciadsoyad = @OgrenciAdi AND secilenogretmen = @OgretmenAdi", conn))
            {
                cmd.Parameters.AddWithValue("SecilenDers", secilenDers);
                cmd.Parameters.AddWithValue("OgrenciAdi", ogrenciAdi);
                cmd.Parameters.AddWithValue("OgretmenAdi", ogretmenAdi);
                object result = cmd.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                {
                    return false; // Ders onaylanmamış olarak kabul edilir
                }
                return (bool)result; // Ders onaylanmış olarak kabul edilir
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secilenDers = comboBox1.SelectedItem.ToString();

            string ogrenciAdi = listBox1.SelectedItem.ToString();

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234");

            try
            {
                conn.Open();

               
                using (NpgsqlCommand cmd = new NpgsqlCommand("UPDATE dersecim SET onaylanmadurumu = null WHERE secilendersler = @SecilenDers AND ogrenciadsoyad = @OgrenciAdi", conn))
                {
                    cmd.Parameters.AddWithValue("SecilenDers", secilenDers);
                    cmd.Parameters.AddWithValue("OgrenciAdi", ogrenciAdi);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        
                        listBox1.Items.Remove(ogrenciAdi);

                       
                        checkedListBox1.Items.Add(ogrenciAdi);
                    }
                    else
                    {
                        MessageBox.Show("Öğrencinin onay durumu zaten güncellendi veya seçili bir öğrenci yok.");
                    }
                }

                MessageBox.Show("Öğrencinin onay durumu güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dersecimbutton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

        }

        private void mesajlarbuton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = true;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void mesajcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mesajtextbox_TextChanged(object sender, EventArgs e)
        {

        }



        private string GetOgretmenAdi(string ogretmenNo, string ogretmenSifre)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234"))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT ogretmenad FROM ogretmen WHERE ogretmensicilno = @OgretmenNo AND ogretmensifre = @Sifre", conn))
                {
                    cmd.Parameters.AddWithValue("OgretmenNo", ogretmenNo);
                    cmd.Parameters.AddWithValue("Sifre", ogretmenSifre);
                    object result = cmd.ExecuteScalar();

                    return result != null ? result.ToString() : string.Empty;
                }
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gelenkutusulistview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void gonderbuton_Click(object sender, EventArgs e)
        {
            
            string aliciAdSoyad = mesajcombobox.SelectedItem.ToString();

            string gonderenAd = GetOgretmenAdi(oretmenadtext.Text, ogretmensifretext.Text);

            
            string mesajIcerik = mesajtextbox.Text;

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234");

            try
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO mesaj (gonderen, alici, mesaj) VALUES (@Gonderen, @Alici, @Icerik)", conn))
                {
                    cmd.Parameters.AddWithValue("Gonderen", gonderenAd);
                    cmd.Parameters.AddWithValue("Alici", aliciAdSoyad);
                    cmd.Parameters.AddWithValue("Icerik", mesajIcerik);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Mesaj gönderildi.");
                mesajtextbox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void gelenkutusubuton_Click(object sender, EventArgs e)
        {

            
            string ogretmenNo = oretmenadtext.Text;
            string ogretmenSifre = ogretmensifretext.Text;
            string ogretmenAdi = GetOgretmenAdi(ogretmenNo, ogretmenSifre);
            
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234"))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT gonderen, mesaj FROM mesaj WHERE alici = @Alici";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("Alici", ogretmenAdi);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                           
                            gelenkutusulistview.Items.Clear();

                           
                            gelenkutusulistview.View = View.Details;

                           
                            gelenkutusulistview.Columns.Add("Gönderen", 150);
                            gelenkutusulistview.Columns.Add("Mesaj", 300);

                            while (reader.Read())
                            {
                                string gonderenAdi = reader["gonderen"].ToString();
                                string mesajMetni = reader["mesaj"].ToString();

                                ListViewItem item = new ListViewItem(gonderenAdi);
                                item.SubItems.Add(mesajMetni);
                                gelenkutusulistview.Items.Add(item);
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
    }
}



