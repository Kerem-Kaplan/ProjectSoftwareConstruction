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

    public partial class StudentExamPage : Form
    {

        public StudentExamPage()
        {
            InitializeComponent();
        }

        readonly Sql_Connection baglanti = new Sql_Connection();
        readonly Random rand = new Random();
        readonly string randomValue = "select top 1 * from Questions order by NEWID()";
        readonly string randomStudents = "select * from Students";

        private void StudentExamPage_Load(object sender, EventArgs e)
        {
            baglanti.connection();
            rand.Next();


            SqlCommand randomvalue = new SqlCommand(randomValue, baglanti.connection());
            SqlDataReader reader = randomvalue.ExecuteReader();
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
            baglanti.connection().Close();
        }


        int i;

        public void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnSoruA.BackColor = Color.Aquamarine;
            BtnSoruB.BackColor = Color.Aquamarine;
            BtnSoruC.BackColor = Color.Aquamarine;
            BtnSoruD.BackColor = Color.Aquamarine;
            i++;
            baglanti.connection();
            rand.Next();

            SqlCommand randomvalue = new SqlCommand(randomValue, baglanti.connection());
            SqlDataReader reader = randomvalue.ExecuteReader();
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

            if (i == 9)
            {
                BtnSonraki.Enabled = false;
            }
            baglanti.connection().Close();
        }

        private void BtnSinavBitir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sınav gönderildi");
            StudentHomePage studentHomePage = new StudentHomePage();
            studentHomePage.Show();
            this.Hide();

        }

        private void BtnSoruA_Click(object sender, EventArgs e)
        {
            baglanti.connection();
            SqlCommand controlA = new SqlCommand(randomValue, baglanti.connection());
            SqlDataReader readA = controlA.ExecuteReader();
            if (readA["OptionA"].ToString() == "A")
            {
                MessageBox.Show("Basarılı");
            }
        }

        private void BtnSoruB_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSoruC_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSoruD_Click(object sender, EventArgs e)
        {
            
        }
    }
}
