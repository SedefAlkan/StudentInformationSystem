using iTextSharp.text.pdf.parser;
using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace yazlab3
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            panel1.Visible = false;
            derssecimpanel.Visible = false;
            alınanderspanel.Visible = false;
        }

        private void ogrencinotext_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ogrencinolabel_Click(object sender, EventArgs e)
        {
            
        }

        private void sifrelabel_Click(object sender, EventArgs e)
        {
            
        }

        private void sifretext_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void girisbuton_Click(object sender, EventArgs e)
        {
            
            string ogrenciNo = ogrencinotext.Text;
            string sifre = sifretext.Text;
            string ogrenciAdi = GetStudentNameFromDatabase(ogrenciNo); 

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234");

            try
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(*) FROM ogrenci WHERE ogrencino = @OgrenciNo AND sifre = @Sifre", conn);
                cmd.Parameters.AddWithValue("OgrenciNo", ogrenciNo);
                cmd.Parameters.AddWithValue("Sifre", sifre);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    
                    panel1.Visible = true;

                   
                    KaydetGecisTablosuna();
                }
                else
                {
                    MessageBox.Show("Geçersiz öğrenci numarası veya şifre.");
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


       
        private string GetStudentNameFromDatabase(string ogrenciNo)
        {
            string ogrenciAdi = "";
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234");

            try
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT adsoyad FROM ogrenci WHERE ogrencino = @OgrenciNo", conn);
                cmd.Parameters.AddWithValue("OgrenciNo", ogrenciNo);
                ogrenciAdi = cmd.ExecuteScalar() as string;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return ogrenciAdi;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void transkriptlabel_Click(object sender, EventArgs e)
        {
            
        }

        private void transkriptbuton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Dosyaları|*.pdf";
            openFileDialog.Title = "PDF Dosyası Seç";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string secilenDosyaYolu = openFileDialog.FileName;

                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234");
                string ogrenciAdi = GetStudentNameFromDatabase(ogrencinotext.Text); // Öğrencinin adını al

                try
                {
                    conn.Open();
                    NpgsqlTransaction transaction = conn.BeginTransaction();

                   
                    using (PdfReader pdfOkuyucu = new PdfReader(secilenDosyaYolu))
                    {
                        int sayfaSayisi = pdfOkuyucu.NumberOfPages;

                        for (int sayfaNo = 1; sayfaNo <= sayfaSayisi; sayfaNo++)
                        {
                            string sayfaMetni = PdfTextExtractor.GetTextFromPage(pdfOkuyucu, sayfaNo);

                           
                            string[] lines = sayfaMetni.Split('\n');

                            foreach (string line in lines)
                            {
                                string dersAdi = ExtractCourseName(line);
                                string harfNotu = ExtractGrade(line);

                                if (!string.IsNullOrEmpty(dersAdi) && !string.IsNullOrEmpty(harfNotu))
                                {
                                   
                                    AddCourseWithGrade(ogrenciAdi, dersAdi, harfNotu, conn);
                                }
                            }
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Ders isimleri ve harf notları başarıyla eklenmiştir.");
                    derssecimpanel.Visible = true;
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
        }


       
        private string ExtractCourseName(string line)
        {
            string[] harfNotlari = new string[] { "AA", "BA", "BB", "CB", "CC", "DC", "DD", "FD", "FF" };
            string pattern = @"([A-Z]{3,4}\d{3})\s(.+)";
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(pattern);
            System.Text.RegularExpressions.Match match = regex.Match(line);

            if (match.Success)
            {
                string dersKodu = match.Groups[1].Value;
                string dersAdi = match.Groups[2].Value.Trim();

                
                if (dersKodu.Length == 6)
                {
                    int zIndex = dersAdi.IndexOf("Z");
                    if (zIndex >= 0)
                    {
                        dersAdi = dersAdi.Substring(0, zIndex).Trim();
                    }

                    return dersAdi;
                }
            }

            return null;
        }

       
        private string ExtractGrade(string line)
        {
            string[] harfNotlari = new string[] { "AA", "BA", "BB", "CB", "CC", "DC", "DD", "FD", "FF", "G" };

            foreach (string harfNotu in harfNotlari)
            {
                int startIndex = line.IndexOf(harfNotu);
                if (startIndex >= 0)
                {
                    int endIndex = startIndex + harfNotu.Length;
                    while (startIndex > 0 && line[startIndex - 1] == ' ')
                    {
                        startIndex--;
                    }
                    while (endIndex < line.Length && line[endIndex] == ' ')
                    {
                        endIndex++;
                    }

                    return line.Substring(startIndex, endIndex - startIndex).Trim();
                }
            }

            return null;
        }

        
        private void AddCourseWithGrade(string ogrenciAdi, string courseName, string grade, NpgsqlConnection conn)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO dersler (dersialanogrenci, dersadi, dersharfnotu) VALUES (@OgrenciAdi, @CourseName, @Grade)", conn))
            {
                cmd.Parameters.AddWithValue("OgrenciAdi", ogrenciAdi);
                cmd.Parameters.AddWithValue("CourseName", courseName);
                cmd.Parameters.AddWithValue("Grade", grade);
                cmd.ExecuteNonQuery();
            }
        }
        private void AddStudentToGecisTable(string ogrenciAdi, NpgsqlConnection conn)
        {
            using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO gecis (ogrenciad, eklenmetarihi) VALUES (@OgrenciAdi, NOW())", conn))
            {
                cmd.Parameters.AddWithValue("OgrenciAdi", ogrenciAdi);
                cmd.ExecuteNonQuery();
            }
        }
        private void KaydetGecisTablosuna()
        {
            string ogrenciAdi = GetStudentNameFromDatabase(ogrencinotext.Text); // Öğrencinin adını al

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234");

            try
            {
                conn.Open();

                
                AddStudentToGecisTable(ogrenciAdi, conn);

                // MessageBox.Show("Öğrenci 'gecis' tablosuna başarıyla eklendi.");
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


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void derssecimpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void alınandersbutton_Click(object sender, EventArgs e)
        {
            
            string ogrenciAdi = GetStudentNameFromDatabase(ogrencinotext.Text);
            DataTable derslerTable = GetCoursesForStudent(ogrenciAdi);

          
            dataGridViewAlinanDersler.DataSource = derslerTable;
            alınanderspanel.Visible = true;
        }

      
        private DataTable GetCoursesForStudent(string ogrenciAdi)
        {
            DataTable derslerTable = new DataTable();
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=yazlab; User Id=postgres; Password=1234"))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT dersadi, dersharfnotu FROM dersler WHERE dersialanogrenci = @OgrenciAdi";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("OgrenciAdi", ogrenciAdi);
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        da.Fill(derslerTable);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            return derslerTable;
        }


        private void derssecimbutton_Click(object sender, EventArgs e)
        {
            Form5 ac = new Form5();
            ac.ShowDialog();

        }

        private void alınanderspanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewAlinanDersler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sifretext.PasswordChar = '*';
        }
    }
}