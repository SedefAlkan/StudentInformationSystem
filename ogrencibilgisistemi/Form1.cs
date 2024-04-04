using Npgsql;

namespace yazlab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=yazlab; user ID=postgres; password=1234");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"C:\Users\ASUS\OneDrive\Masaüstü\Student.png");

            
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            
            pictureBox1.Image = img;

            Image img1 = Image.FromFile(@"C:\Users\ASUS\OneDrive\Masaüstü\teacher.png");

           
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

           
            pictureBox2.Image = img1;


            Image img2 = Image.FromFile(@"C:\Users\ASUS\OneDrive\Masaüstü\yönetici1.png");

           
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

           
            pictureBox3.Image = img2;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}