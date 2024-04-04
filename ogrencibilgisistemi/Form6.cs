using System;
using System.Data;
using System.Windows.Forms;
using Npgsql; 

namespace yazlab3
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                
                using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234"))
                {
                    conn.Open();

                   
                    string ogrenciSql = "SELECT adsoyad FROM ogrenci";

                  
                    NpgsqlDataAdapter ogrenciAdapter = new NpgsqlDataAdapter(ogrenciSql, conn);

                    
                    DataTable ogrenciDataTable = new DataTable();
                    ogrenciAdapter.Fill(ogrenciDataTable);

                    
                    string dersecimSql = "SELECT ogrenciadsoyad FROM dersecim";
                    string dersecimSql1 = "SELECT * FROM dersecim";
                   
                    NpgsqlDataAdapter dersecimAdapter = new NpgsqlDataAdapter(dersecimSql1, conn);

                   
                    DataTable dersecimDataTable = new DataTable();
                    dersecimAdapter.Fill(dersecimDataTable);
                    dataGridView1.DataSource = dersecimDataTable;

                    
                    var ogrenciAdlar = ogrenciDataTable.AsEnumerable()
                        .Select(row => row.Field<string>("adsoyad"))
                        .ToList();

                   
                    var dersecimAdlar = dersecimDataTable.AsEnumerable()
                        .Select(row => row.Field<string>("ogrenciadsoyad"))
                        .ToList();

                    
                    var farkAdlar = ogrenciAdlar.Except(dersecimAdlar).ToList();

                    listBox1.Items.AddRange(farkAdlar.ToArray());

                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void rastgelebuton_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234"))
                {
                    conn.Open();

                    Random random = new Random();
                    int rastgeleOgrenciIndex = random.Next(listBox1.Items.Count);
                    string rastgeleOgrenci = listBox1.Items[rastgeleOgrenciIndex].ToString();

                  
                    List<string> ogrencininAldigiDersler = OgrencininAldigiDersleriGetir(conn, rastgeleOgrenci);

                    // Her öğrenciye 4 ders seçtir
                    for (int i = 0; i < 4; i++)
                    {
                        // Rastgele bir öğretmen seç
                        string rastgeleOgretmen = RastgeleOgretmenSec(conn);

                        // Rastgele öğretmenin verdiği dersi seç
                        string rastgeleDers = RastgeleDersSec(conn, rastgeleOgretmen);

                        // Öğrencinin daha önce aldığı dersler arasında olup olmadığını kontrol et
                        while (ogrencininAldigiDersler.Contains(rastgeleDers))
                        {
                            // Eğer ders daha önce alındıysa farklı bir ders seç
                            rastgeleDers = RastgeleDersSec(conn, rastgeleOgretmen);
                        }

                      
                        string insertSql = "INSERT INTO dersecim (ogrenciadsoyad, secilendersler, secilenogretmen) VALUES (@ogrenci, @ders, @ogretmen)";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(insertSql, conn))
                        {
                            cmd.Parameters.AddWithValue("ogrenci", rastgeleOgrenci);
                            cmd.Parameters.AddWithValue("ders", rastgeleDers);
                            cmd.Parameters.AddWithValue("ogretmen", rastgeleOgretmen);

                            cmd.ExecuteNonQuery();
                        }

                        
                        ogrencininAldigiDersler.Add(rastgeleDers);
                    }

                    listBox1.Items.RemoveAt(rastgeleOgrenciIndex);

                    MessageBox.Show("Rastgele ders atamaları başarıyla eklendi.");

                   
                    Form6_Load(sender, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private List<string> OgrencininAldigiDersleriGetir(NpgsqlConnection conn, string ogrenciAd)
        {
            string dersSql = "SELECT secilendersler FROM dersecim WHERE ogrenciadsoyad = @ogrenciAd";
            using (NpgsqlCommand cmd = new NpgsqlCommand(dersSql, conn))
            {
                cmd.Parameters.AddWithValue("ogrenciAd", ogrenciAd);
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    List<string> dersler = new List<string>();
                    while (reader.Read())
                    {
                        dersler.Add(reader["secilendersler"].ToString());
                    }
                    return dersler;
                }
            }
        }



        private string RastgeleOgretmenSec(NpgsqlConnection conn)
        {
            string ogretmenSql = "SELECT ogretmenad FROM ogretmen ORDER BY RANDOM() LIMIT 1";

            using (NpgsqlCommand cmd = new NpgsqlCommand(ogretmenSql, conn))
            {
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }
            }

            return "Varsayılan Ogretmen"; 
        }

        private string RastgeleDersSec(NpgsqlConnection conn, string ogretmenAd)
        {
            string dersSql = "SELECT verdigidersler FROM ogretmen WHERE ogretmenad = @ogretmenAd ORDER BY RANDOM() LIMIT 1";

            using (NpgsqlCommand cmd = new NpgsqlCommand(dersSql, conn))
            {
                cmd.Parameters.AddWithValue("ogretmenAd", ogretmenAd);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }
            }

            return "Varsayılan Ders"; // Hata durumunda varsayılan bir değer
        }


    }
}
