using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareConstructorProject
{
    public partial class StudentUntimelyExamPage : Form
    {
        public int[] id = new int[10];
        int[] trueAnswer = new int[15];

        public StudentUntimelyExamPage()
        {
            InitializeComponent();
        }

        readonly Sql_Connection baglanti = new Sql_Connection();
        readonly Random rand = new Random();

        readonly string randomValue = "select top 1 * from Questions  order by NEWID() ";

        SqlDataReader reader;
        SqlCommand randomvalue;

        //butonlarin pasif yapilma islemi
        private void StudentUntimelyExamPage_Load(object sender, EventArgs e)
        {
            BtnSonraki.Text = "Başla";
            BtnSoruA.Enabled = false;
            BtnSoruB.Enabled = false;
            BtnSoruC.Enabled = false;
            BtnSoruD.Enabled = false;
            BtnSinavBitir.Enabled = false;

        }

        int i, j;
        //sorularin goruntulenmesi icin gereken islemler ve bir sonraki soruya geçmek icin 
        //gereken islemler
        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnSonraki.Text = "Sonraki";
            BtnSoruA.Enabled = true;
            BtnSoruB.Enabled = true;
            BtnSoruC.Enabled = true;
            BtnSoruD.Enabled = true;
            BtnSinavBitir.Enabled = true;

            BtnSoruA.BackColor = Color.Honeydew;
            BtnSoruB.BackColor = Color.Honeydew;
            BtnSoruC.BackColor = Color.Honeydew;
            BtnSoruD.BackColor = Color.Honeydew;
            i++;
            baglanti.connection();
            rand.Next();

            randomvalue = new SqlCommand(randomValue, baglanti.connection());
            randomvalue.Parameters.AddWithValue("@id", id[0]);
            reader = randomvalue.ExecuteReader();

            if (reader.Read())
            {
                TxtSoru.Text = reader[0].ToString();

                TxtSoru.Text += reader["QuestionText"].ToString();
                PctSoru.ImageLocation = reader["QuestionImage"].ToString();

                BtnSoruA.Text = reader["OptionA"].ToString();
                PctSoruA.ImageLocation = reader["ImageOptionA"].ToString();

                BtnSoruB.Text = reader["OptionB"].ToString();
                PctSoruB.ImageLocation = reader["ImageOptionB"].ToString();

                BtnSoruC.Text = reader["OptionC"].ToString();
                PctSoruC.ImageLocation = reader["ImageOptionC"].ToString();

                BtnSoruD.Text = reader["OptionD"].ToString();
                PctSoruD.ImageLocation = reader["ImageOptionD"].ToString();

            }

            if (i == 10)
            {
                BtnSonraki.Enabled = false;
            }
            baglanti.connection().Close();
        }

        //sinavi bitirme islemi
        private void BtnSinavBitir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SINAV SONUCUNUZ İÇİN TAMAM BUTONUNA BASINIZ", "SINAVINIZ BİTMİŞTİR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //string _yuzdelik = yuzdelik.ToString("0.##");


            MessageBox.Show("10 SORU İÇERİSİNDEN BAŞARI YÜZDENİZ: %" + Convert.ToString(10 * j), "BAŞARI YÜZDENİZ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            StudentHomePage studentHomePage = new StudentHomePage();
            studentHomePage.id[0] = id[0];
            studentHomePage.Show();
            this.Hide();
        }

        //veritabanindan cekilen cevabin A olup olmadigi kontrolu
        private void BtnSoruA_Click(object sender, EventArgs e)
        {
            randomvalue.Parameters.AddWithValue("@id", id[0]);
            if (reader["CorrectAnswer"].ToString() == "A")
            {
                trueAnswer[j] = Convert.ToInt32(reader[0].ToString());
                j++;
                BtnSoruA.BackColor = Color.Green;

            }
            else
            {
                BtnSoruA.BackColor = Color.Red;

            }
            BtnSoruA.Enabled = false;
            BtnSoruB.Enabled = false;
            BtnSoruC.Enabled = false;
            BtnSoruD.Enabled = false;
        }

        //veritabanindan cekilen cevabin B olup olmadigi kontrolu
        private void BtnSoruB_Click(object sender, EventArgs e)
        {
            randomvalue.Parameters.AddWithValue("@id", id[0]);
            if (reader["CorrectAnswer"].ToString() == "B")
            {
                trueAnswer[j] = Convert.ToInt32(reader[0].ToString());
                j++;
                BtnSoruB.BackColor = Color.Green;

            }
            else
            {
                BtnSoruB.BackColor = Color.Red;

            }
            BtnSoruA.Enabled = false;
            BtnSoruB.Enabled = false;
            BtnSoruC.Enabled = false;
            BtnSoruD.Enabled = false;
        }

        //veritabanindan cekilen cevabin C olup olmadigi kontrolu
        private void BtnSoruC_Click(object sender, EventArgs e)
        {
            randomvalue.Parameters.AddWithValue("@id", id[0]);
            if (reader["CorrectAnswer"].ToString() == "C")
            {
                trueAnswer[j] = Convert.ToInt32(reader[0].ToString());
                j++;
                BtnSoruC.BackColor = Color.Green;

            }
            else
            {
                BtnSoruC.BackColor = Color.Red;

            }
            BtnSoruA.Enabled = false;
            BtnSoruB.Enabled = false;
            BtnSoruC.Enabled = false;
            BtnSoruD.Enabled = false;
        }

        //veritabanindan cekilen cevabin D olup olmadigi kontrolu
        private void BtnSoruD_Click(object sender, EventArgs e)
        {
            randomvalue.Parameters.AddWithValue("@id", id[0]);
            if (reader["CorrectAnswer"].ToString() == "D")
            {
                trueAnswer[j] = Convert.ToInt32(reader[0].ToString());
                j++;
                BtnSoruD.BackColor = Color.Green;

            }
            else
            {
                BtnSoruD.BackColor = Color.Red;

            }
            BtnSoruA.Enabled = false;
            BtnSoruB.Enabled = false;
            BtnSoruC.Enabled = false;
            BtnSoruD.Enabled = false;
        }
    }
}
