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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            panel1.Visible = false;
            ogrencibilgipanel.Visible = false;
            ogretmenbilgipanel.Visible = false;
        }

        private void yoneticiadlabel_Click(object sender, EventArgs e)
        {

        }

        private void yoneticiadtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void yoneticisifrelabel_Click(object sender, EventArgs e)
        {

        }

        private void yoneticisifretetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string yoneticiNo = yoneticiadtext.Text;
            string yoneticisifre = yoneticisifretetxt.Text;

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234");

            try
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(*) FROM yonetici WHERE yoneticisicilno = @OgrenciNo AND yoneticisifre = @Sifre", conn);
                cmd.Parameters.AddWithValue("OgrenciNo", yoneticiNo);
                cmd.Parameters.AddWithValue("Sifre", yoneticisifre);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    
                    panel1.Visible = true;
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

        private void Form4_Load(object sender, EventArgs e)
        {
            yoneticisifretetxt.PasswordChar = '*';
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ogrencibilgibutton_Click(object sender, EventArgs e)
        {
            
            string connectionString = "Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234";
            string query = "SELECT * FROM ogrenci";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connectionString);

           
            DataTable dataTable = new DataTable();

           
            dataAdapter.Fill(dataTable);

           
            dataGridView1.DataSource = dataTable;
            ogrencibilgipanel.Visible = true;
          
            dataGridView1.Visible = true;
        }


        private void ogretmenbilgibutton_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234";
            string query = "SELECT * FROM ogretmen"; 
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connectionString);

            
            DataTable dataTable = new DataTable();

            // Verileri DataTable'e doldur
            dataAdapter.Fill(dataTable);

            // DataGridView'e DataTable'i bağla
            dataGridView2.DataSource = dataTable;
            ogretmenbilgipanel.Visible = true;
           
            dataGridView2.Visible = true;
        }

        private void ogrencibilgipanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ogretmenbilgipanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ogrenciAd = ogrenciadtextbox.Text;
            string ogrenciNo = ogrencinotextbox.Text;
            string ogrenciSifre = ogrencisifretextbox.Text;

            if (int.TryParse(ogrenciidtextbox.Text, out int ogrenciId))
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234");

                try
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO ogrenci (adsoyad, ogrencino,sifre, id) VALUES (@AdSoyad, @OgrenciNo, @Sifre, @OgrenciId)";
                    NpgsqlCommand cmd = new NpgsqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("AdSoyad", ogrenciAd);
                    cmd.Parameters.AddWithValue("OgrenciNo", ogrenciNo);
                    cmd.Parameters.AddWithValue("Sifre", ogrenciSifre);
                    cmd.Parameters.AddWithValue("OgrenciId", ogrenciId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Öğrenci başarıyla eklendi.");
                        
                        ogrencibilgibutton_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci eklenirken bir hata oluştu.");
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
            else
            {
                MessageBox.Show("Öğrenci ID'si geçerli bir tamsayı değil.");
            }
        }

        private void silmebuton_Click(object sender, EventArgs e)
        {
           
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int ogrenciId = (int)dataGridView1.Rows[selectedRowIndex].Cells["id"].Value;

                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234");

                try
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM ogrenci WHERE id = @OgrenciId";
                    NpgsqlCommand cmd = new NpgsqlCommand(deleteQuery, conn);
                    cmd.Parameters.AddWithValue("OgrenciId", ogrenciId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Öğrenci başarıyla silindi.");
                       
                        ogrencibilgibutton_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci silinirken bir hata oluştu.");
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
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir öğrenci seçin.");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int ogrenciId = (int)dataGridView1.Rows[selectedRowIndex].Cells["id"].Value;

               
                string updatedAd = ogrenciadtextbox.Text;
                string updatedNo = ogrencinotextbox.Text;
                string updatedSifre = ogrencisifretextbox.Text;

                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234");

                try
                {
                    conn.Open();
                    string updateQuery = "UPDATE ogrenci SET adsoyad = @Ad, ogrencino = @No, sifre = @Sifre WHERE id = @OgrenciId";
                    NpgsqlCommand cmd = new NpgsqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("Ad", updatedAd);
                    cmd.Parameters.AddWithValue("No", updatedNo);
                    cmd.Parameters.AddWithValue("Sifre", updatedSifre);
                    cmd.Parameters.AddWithValue("OgrenciId", ogrenciId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Öğrenci bilgileri başarıyla güncellendi.");
                       
                        ogrencibilgibutton_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci bilgileri güncellenirken bir hata oluştu.");
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
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz bir öğrenci seçin.");
            }
        }


        private void ogretmeneklebuton_Click(object sender, EventArgs e)
        {
            string ogretmenAd = ogretmenadtextbox.Text;
            string sicilNo = ogretmensicilnotextbox.Text;
            string ogretmenSifre = ogretmensifretextbox.Text;
            string verdigidersler = verdigiderslertextbox.Text;

            
            if (int.TryParse(ogretmenidtextbox.Text, out int Id))
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234");

                try
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO ogretmen (ogretmenad, ogretmensicilno, ogretmensifre, verdigidersler, ogretmenıd) VALUES (@AdSoyad, @SicilNo, @Sifre, @Verdigiders, @OgretmenId)";
                    NpgsqlCommand cmd = new NpgsqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("AdSoyad", ogretmenAd);
                    cmd.Parameters.AddWithValue("SicilNo", sicilNo);
                    cmd.Parameters.AddWithValue("Sifre", ogretmenSifre);
                    cmd.Parameters.AddWithValue("Verdigiders", verdigidersler);
                    cmd.Parameters.AddWithValue("OgretmenId", Id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Öğretmen başarıyla eklendi.");
                       
                        ogretmenbilgibutton_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Öğretmen eklenirken bir hata oluştu.");
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
            else
            {
                MessageBox.Show("Öğretmen ID'si geçerli bir tamsayı değil.");
            }
        }


        private void ogretmensilbuton_Click(object sender, EventArgs e)
        {
           
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView2.SelectedRows[0].Index;
                int ogretmenId = (int)dataGridView2.Rows[selectedRowIndex].Cells["ogretmenıd"].Value;

                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234");

                try
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM ogretmen WHERE ogretmenıd = @ogretmenId";
                    NpgsqlCommand cmd = new NpgsqlCommand(deleteQuery, conn);
                    cmd.Parameters.AddWithValue("OgretmenId", ogretmenId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Öğretmen başarıyla silindi.");
                      
                        ogretmenbilgibutton_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Öğretmen silinirken bir hata oluştu.");
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
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir öğretmen seçin.");
            }
        }

        private void ogretmenguncellebuton_Click(object sender, EventArgs e)
        {
           
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView2.SelectedRows[0].Index;
                int ogretmenId = (int)dataGridView2.Rows[selectedRowIndex].Cells["ogretmenıd"].Value;

              
                string updatedAd = ogretmenadtextbox.Text;
                string updatedNo = ogretmensicilnotextbox.Text;
                string updatedSifre = ogretmensifretextbox.Text;
                string updateverdigidersler = verdigiderslertextbox.Text;

                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234");

                try
                {
                    conn.Open();
                    string updateQuery = "UPDATE ogretmen SET ogretmenad = @Ad, ogretmensicilno = @No, ogretmensifre = @Sifre,verdigidersler=@Verdigiders WHERE ogretmenıd = @OgretmenId";
                    NpgsqlCommand cmd = new NpgsqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("Ad", updatedAd);
                    cmd.Parameters.AddWithValue("No", updatedNo);
                    cmd.Parameters.AddWithValue("Sifre", updatedSifre);
                    cmd.Parameters.AddWithValue("OgretmenId", ogretmenId);
                    cmd.Parameters.AddWithValue("Verdigiders", updateverdigidersler);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Öğretmen bilgileri başarıyla güncellendi.");
                       
                        ogretmenbilgibutton_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Öğretmen bilgileri güncellenirken bir hata oluştu.");
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
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz bir öğretmen seçin.");
            }
        }

        private void ogrencikaydet_Click(object sender, EventArgs e)
        {

        }

        private void ogrencinotextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ogrenciadtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ogrencisifretextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ogrenciidtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ogretmenadtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ogretmensicilnotextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ogretmenidtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ogretmensifretextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void verdigiderslertextbox_TextChanged(object sender, EventArgs e)
        {

        }


        private void dersecimbuton_Click(object sender, EventArgs e)
        {
           
            Form6 form6 = new Form6();

         
            form6.Show();
        }
    }
}
