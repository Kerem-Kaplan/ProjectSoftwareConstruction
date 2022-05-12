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
        public int[] id = new int[10];
        public StudentExamPage()
        {
            InitializeComponent();
        }

        readonly Sql_Connection baglanti = new Sql_Connection();
        readonly Random rand = new Random();

        readonly string randomValue = "select top 1 * from Questions  order by NEWID() ";

        //readonly string getDBOCorrectAnswer = "select * from CorrectAnswer";

        readonly string insertDBOCorrectAnswer = "insert into CorrectAnswer (StudentID,QuestionID,TotalCorrect,FirstCorrectDate,Frequency) values (@studentID,@questionID,@totalCorrect,@date,@fre)";

        readonly string GetCorrectAnswer = "select  * from CorrectAnswer inner join Questions on CorrectAnswer.QuestionID=Questions.QuestionID where CorrectAnswer.StudentID=@id";

        readonly string GetFrequency = "select * from Frequencyy where TotalCorrect=@totalCorrect";

        SqlDataReader reader;
        SqlDataReader readerCorrectAnswer;
        SqlDataReader readergetFrequency;
        SqlCommand getCorrectAnswer;
        SqlCommand randomvalue;

        private void StudentExamPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
            BtnSonraki.Text = "Başla";
            BtnSoruA.Enabled = false;
            BtnSoruB.Enabled = false;
            BtnSoruC.Enabled = false;
            BtnSoruD.Enabled = false;
            BtnSinavBitir.Enabled = false;
            BtnDevam.Enabled = false;

        }


        int i;
        public void BtnSonraki_Click(object sender, EventArgs e)
        {

            BtnSonraki.Text = "Sonraki";
            BtnSoruA.Enabled = true;
            BtnSoruB.Enabled = true;
            BtnSoruC.Enabled = true;
            BtnSoruD.Enabled = true;
            BtnSinavBitir.Enabled = true;

            BtnSoruA.BackColor = Color.Aquamarine;
            BtnSoruB.BackColor = Color.Aquamarine;
            BtnSoruC.BackColor = Color.Aquamarine;
            BtnSoruD.BackColor = Color.Aquamarine;
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
            getCorrectAnswer = new SqlCommand(GetCorrectAnswer, baglanti.connection());
            getCorrectAnswer.Parameters.AddWithValue("@id", id[0]);
            readerCorrectAnswer = getCorrectAnswer.ExecuteReader();

            if (i == 10)
            {
                BtnSonraki.Enabled = false;
                BtnDevam.Enabled = true;
            }
            baglanti.connection().Close();
        }

        private void BtnSinavBitir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sınav gönderildi");
            StudentHomePage studentHomePage = new StudentHomePage();
            studentHomePage.id[0] = id[0];
            studentHomePage.Show();
            this.Hide();
        }

        private void BtnSoruA_Click(object sender, EventArgs e)
        {

            randomvalue.Parameters.AddWithValue("@id", id[0]);
            SqlCommand insertCorrectAnswer = new SqlCommand(insertDBOCorrectAnswer, baglanti.connection());
            if (reader["CorrectAnswer"].ToString() == "A")
            {
                BtnSoruA.BackColor = Color.Green;
                baglanti.connection();

                MessageBox.Show(Convert.ToString(id[0]));
                insertCorrectAnswer.Parameters.AddWithValue("@studentID", id[0]);
                insertCorrectAnswer.Parameters.AddWithValue("@questionID", reader["QuestionID"]);
                insertCorrectAnswer.Parameters.AddWithValue("@totalCorrect", 1);
                insertCorrectAnswer.Parameters.AddWithValue("@date", DateTime.Now);
                insertCorrectAnswer.Parameters.AddWithValue("@fre", 1);

                insertCorrectAnswer.ExecuteNonQuery();
                baglanti.connection().Close();
            }
            if (reader["CorrectAnswer"].ToString() != "A")
            {
                BtnSoruA.BackColor = Color.Red;
            }


            if (readerCorrectAnswer.Read() && readerCorrectAnswer["CorrectAnswer"].ToString() == "A")
            {
                getCorrectAnswer.Parameters.AddWithValue("@id", id[0]);
                BtnSoruA.BackColor = Color.Green;
                baglanti.connection();

                if (readerCorrectAnswer.Read())
                {
                    string UpdateCorrectAnswer = "update CorrectAnswer set TotalCorrect=@totalCorrect,Frequency=@frequency where StudentID=@sid and QuestionID=@qid";
                    SqlCommand updateCorrectAnswer = new SqlCommand(UpdateCorrectAnswer, baglanti.connection());
                    updateCorrectAnswer.Parameters.AddWithValue("@sid", id[0]);
                    updateCorrectAnswer.Parameters.AddWithValue("@qid", readerCorrectAnswer["QuestionID"]);

                    SqlCommand getFrequency = new SqlCommand(GetFrequency, baglanti.connection());
                    getFrequency.Parameters.AddWithValue("@totalCorrect", readerCorrectAnswer["TotalCorrect"]);
                    readergetFrequency = getFrequency.ExecuteReader();

                    if ((readerCorrectAnswer["TotalCorrect"].ToString()) == "1")
                    {
                        updateCorrectAnswer.Parameters.AddWithValue("@totalCorrect", 2);
                        updateCorrectAnswer.Parameters.AddWithValue("@frequency", 7);
                        updateCorrectAnswer.ExecuteNonQuery();
                    }
                    if ((readerCorrectAnswer["TotalCorrect"].ToString()) == "2")
                    {
                        updateCorrectAnswer.Parameters.AddWithValue("@totalCorrect", 3);
                        updateCorrectAnswer.Parameters.AddWithValue("@frequency", 30);
                        updateCorrectAnswer.ExecuteNonQuery();
                    }
                    if ((readerCorrectAnswer["TotalCorrect"].ToString()) == "3")
                    {
                        updateCorrectAnswer.Parameters.AddWithValue("@totalCorrect", 4);
                        updateCorrectAnswer.Parameters.AddWithValue("@frequency", 90);
                        updateCorrectAnswer.ExecuteNonQuery();
                    }
                    if ((readerCorrectAnswer["TotalCorrect"].ToString()) == "4")
                    {
                        updateCorrectAnswer.Parameters.AddWithValue("@totalCorrect", 5);
                        updateCorrectAnswer.Parameters.AddWithValue("@frequency", 180);
                        updateCorrectAnswer.ExecuteNonQuery();
                    }
                    if ((readerCorrectAnswer["TotalCorrect"].ToString()) == "5")
                    {
                        updateCorrectAnswer.Parameters.AddWithValue("@totalCorrect", 6);
                        updateCorrectAnswer.Parameters.AddWithValue("@frequency", 365);
                        updateCorrectAnswer.ExecuteNonQuery();
                    }


                }
            }
            if ((readerCorrectAnswer["TotalCorrect"].ToString()) == "6")
            {
                string CompletedQuestions = "insert into CompletedQuestions(StudentID,QuestionID) values(@studentID,@questionID)";
                SqlCommand completedQuestions = new SqlCommand(CompletedQuestions, baglanti.connection());
                completedQuestions.Parameters.AddWithValue("@studentID", id[0]);
                completedQuestions.Parameters.AddWithValue("@questionID", readerCorrectAnswer["QuestionID"]);
                completedQuestions.ExecuteNonQuery();
            }

            else
            {
                BtnSoruA.BackColor = Color.Red;
            }



            BtnSoruA.Enabled = false;
            BtnSoruB.Enabled = false;
            BtnSoruC.Enabled = false;
            BtnSoruD.Enabled = false;
            baglanti.connection().Close();
        }

        private void BtnSoruB_Click(object sender, EventArgs e)
        {

            randomvalue.Parameters.AddWithValue("@id", id[0]);
            SqlCommand insertCorrectAnswer = new SqlCommand(insertDBOCorrectAnswer, baglanti.connection());
            if (reader["CorrectAnswer"].ToString() == "B")
            {
                BtnSoruB.BackColor = Color.Green;
                baglanti.connection();

                //SqlCommand getCorrectAnswer = new SqlCommand(getDBOCorrectAnswer, baglanti.connection());
                //SqlDataReader readerCorrectAnswer = getCorrectAnswer.ExecuteReader();


                MessageBox.Show(Convert.ToString(id[0]));
                insertCorrectAnswer.Parameters.AddWithValue("@studentID", id[0]);
                insertCorrectAnswer.Parameters.AddWithValue("@questionID", reader["QuestionID"]);
                insertCorrectAnswer.Parameters.AddWithValue("@totalCorrect", 1);
                insertCorrectAnswer.Parameters.AddWithValue("@date", DateTime.Now);
                insertCorrectAnswer.Parameters.AddWithValue("@fre", 1);



                insertCorrectAnswer.ExecuteNonQuery();
                baglanti.connection().Close();
            }


            if (readerCorrectAnswer.Read() && readerCorrectAnswer["CorrectAnswer"].ToString() == "B")
            {
                getCorrectAnswer.Parameters.AddWithValue("@id", id[0]);
                BtnSoruB.BackColor = Color.Green;
                baglanti.connection();

                if (readerCorrectAnswer.Read())
                {
                    string UpdateCorrectAnswer = "update CorrectAnswer set TotalCorrect=@totalCorrect,Frequency=@frequency where StudentID=@sid and QuestionID=@qid";
                    SqlCommand updateCorrectAnswer = new SqlCommand(UpdateCorrectAnswer, baglanti.connection());
                    updateCorrectAnswer.Parameters.AddWithValue("@sid", id[0]);
                    updateCorrectAnswer.Parameters.AddWithValue("@qid", readerCorrectAnswer["QuestionID"]);

                    SqlCommand getFrequency = new SqlCommand(GetFrequency, baglanti.connection());
                    getFrequency.Parameters.AddWithValue("@totalCorrect", readerCorrectAnswer["TotalCorrect"]);
                    readergetFrequency = getFrequency.ExecuteReader();

                    if ((readerCorrectAnswer["TotalCorrect"].ToString()) == "1")
                    {
                        updateCorrectAnswer.Parameters.AddWithValue("@totalCorrect", 2);
                        updateCorrectAnswer.Parameters.AddWithValue("@frequency", 7);
                        updateCorrectAnswer.ExecuteNonQuery();
                    }
                    if ((readerCorrectAnswer["TotalCorrect"].ToString()) == "2")
                    {
                        updateCorrectAnswer.Parameters.AddWithValue("@totalCorrect", 3);
                        updateCorrectAnswer.Parameters.AddWithValue("@frequency", 30);
                        updateCorrectAnswer.ExecuteNonQuery();
                    }
                    if ((readerCorrectAnswer["TotalCorrect"].ToString()) == "3")
                    {
                        updateCorrectAnswer.Parameters.AddWithValue("@totalCorrect", 4);
                        updateCorrectAnswer.Parameters.AddWithValue("@frequency", 90);
                        updateCorrectAnswer.ExecuteNonQuery();
                    }
                    if ((readerCorrectAnswer["TotalCorrect"].ToString()) == "4")
                    {
                        updateCorrectAnswer.Parameters.AddWithValue("@totalCorrect", 5);
                        updateCorrectAnswer.Parameters.AddWithValue("@frequency", 180);
                        updateCorrectAnswer.ExecuteNonQuery();
                    }
                    if ((readerCorrectAnswer["TotalCorrect"].ToString()) == "5")
                    {
                        updateCorrectAnswer.Parameters.AddWithValue("@totalCorrect", 6);
                        updateCorrectAnswer.Parameters.AddWithValue("@frequency", 365);
                        updateCorrectAnswer.ExecuteNonQuery();
                    }


                }
            }



            if (reader["CorrectAnswer"].ToString() != "B")
            {
                BtnSoruB.BackColor = Color.Red;
            }
            BtnSoruA.Enabled = false;
            BtnSoruB.Enabled = false;
            BtnSoruC.Enabled = false;
            BtnSoruD.Enabled = false;
            baglanti.connection().Close();
        }

        private void BtnSoruC_Click(object sender, EventArgs e)
        {

            randomvalue.Parameters.AddWithValue("@id", id[0]);
            SqlCommand insertCorrectAnswer = new SqlCommand(insertDBOCorrectAnswer, baglanti.connection());
            if (reader["CorrectAnswer"].ToString() == "C")
            {
                BtnSoruC.BackColor = Color.Green;
                baglanti.connection();

                //SqlCommand getCorrectAnswer = new SqlCommand(getDBOCorrectAnswer, baglanti.connection());
                //SqlDataReader readerCorrectAnswer = getCorrectAnswer.ExecuteReader();


                MessageBox.Show(Convert.ToString(id[0]));
                insertCorrectAnswer.Parameters.AddWithValue("@studentID", id[0]);
                insertCorrectAnswer.Parameters.AddWithValue("@questionID", reader["QuestionID"]);
                insertCorrectAnswer.Parameters.AddWithValue("@totalCorrect", 1);
                insertCorrectAnswer.Parameters.AddWithValue("@date", DateTime.Now);
                insertCorrectAnswer.Parameters.AddWithValue("@fre", 1);


                insertCorrectAnswer.ExecuteNonQuery();
                baglanti.connection().Close();
            }


            if (readerCorrectAnswer.Read() && readerCorrectAnswer["CorrectAnswer"].ToString() == "C")
            {
                getCorrectAnswer.Parameters.AddWithValue("@id", id[0]);
                BtnSoruC.BackColor = Color.Green;
                baglanti.connection();

                if (readerCorrectAnswer.Read())
                {
                    string UpdateCorrectAnswer = "update CorrectAnswer set TotalCorrect=@totalCorrect,Frequency=@frequency where StudentID=@sid and QuestionID=@qid";
                    SqlCommand updateCorrectAnswer = new SqlCommand(UpdateCorrectAnswer, baglanti.connection());
                    updateCorrectAnswer.Parameters.AddWithValue("@sid", id[0]);
                    updateCorrectAnswer.Parameters.AddWithValue("@qid", readerCorrectAnswer["QuestionID"]);

                    SqlCommand getFrequency = new SqlCommand(GetFrequency, baglanti.connection());
                    getFrequency.Parameters.AddWithValue("@totalCorrect", readerCorrectAnswer["TotalCorrect"]);
                    SqlDataReader readergetFrequency = getFrequency.ExecuteReader();

                    if ((readerCorrectAnswer["TotalCorrect"].ToString()) == "1")
                    {
                        updateCorrectAnswer.Parameters.AddWithValue("@totalCorrect", 2);
                        updateCorrectAnswer.Parameters.AddWithValue("@frequency", 7);
                        updateCorrectAnswer.ExecuteNonQuery();
                    }
                    if ((readerCorrectAnswer["TotalCorrect"].ToString()) == "2")
                    {
                        updateCorrectAnswer.Parameters.AddWithValue("@totalCorrect", 3);
                        updateCorrectAnswer.Parameters.AddWithValue("@frequency", 30);
                        updateCorrectAnswer.ExecuteNonQuery();
                    }
                    if ((readerCorrectAnswer["TotalCorrect"].ToString()) == "3")
                    {
                        updateCorrectAnswer.Parameters.AddWithValue("@totalCorrect", 4);
                        updateCorrectAnswer.Parameters.AddWithValue("@frequency", 90);
                        updateCorrectAnswer.ExecuteNonQuery();
                    }
                    if ((readerCorrectAnswer["TotalCorrect"].ToString()) == "4")
                    {
                        updateCorrectAnswer.Parameters.AddWithValue("@totalCorrect", 5);
                        updateCorrectAnswer.Parameters.AddWithValue("@frequency", 180);
                        updateCorrectAnswer.ExecuteNonQuery();
                    }
                    if ((readerCorrectAnswer["TotalCorrect"].ToString()) == "5")
                    {
                        updateCorrectAnswer.Parameters.AddWithValue("@totalCorrect", 6);
                        updateCorrectAnswer.Parameters.AddWithValue("@frequency", 365);
                        updateCorrectAnswer.ExecuteNonQuery();
                    }


                }
            }
            if (reader["CorrectAnswer"].ToString() != "C")
            {
                BtnSoruC.BackColor = Color.Red;
            }
            BtnSoruA.Enabled = false;
            BtnSoruB.Enabled = false;
            BtnSoruC.Enabled = false;
            BtnSoruD.Enabled = false;
            baglanti.connection().Close();
        }

        private void BtnSoruD_Click(object sender, EventArgs e)
        {

            randomvalue.Parameters.AddWithValue("@id", id[0]);
            SqlCommand insertCorrectAnswer = new SqlCommand(insertDBOCorrectAnswer, baglanti.connection());
            if (reader["CorrectAnswer"].ToString() == "D")
            {
                BtnSoruD.BackColor = Color.Green;
                baglanti.connection();

                //SqlCommand getCorrectAnswer = new SqlCommand(getDBOCorrectAnswer, baglanti.connection());
                //SqlDataReader readerCorrectAnswer = getCorrectAnswer.ExecuteReader();




                MessageBox.Show(Convert.ToString(id[0]));
                insertCorrectAnswer.Parameters.AddWithValue("@studentID", id[0]);
                insertCorrectAnswer.Parameters.AddWithValue("@questionID", reader["QuestionID"]);
                insertCorrectAnswer.Parameters.AddWithValue("@totalCorrect", 1);
                insertCorrectAnswer.Parameters.AddWithValue("@date", DateTime.Now);
                insertCorrectAnswer.Parameters.AddWithValue("@fre", 1);


                insertCorrectAnswer.ExecuteNonQuery();
                baglanti.connection().Close();
            }

            if (readerCorrectAnswer.Read() && readerCorrectAnswer["CorrectAnswer"].ToString() == "D")
            {
                getCorrectAnswer.Parameters.AddWithValue("@id", id[0]);
                BtnSoruD.BackColor = Color.Green;
                baglanti.connection();

                if (readerCorrectAnswer.Read())
                {
                    string UpdateCorrectAnswer = "update CorrectAnswer set TotalCorrect=@totalCorrect,Frequency=@frequency where StudentID=@sid and QuestionID=@qid";
                    SqlCommand updateCorrectAnswer = new SqlCommand(UpdateCorrectAnswer, baglanti.connection());
                    updateCorrectAnswer.Parameters.AddWithValue("@sid", id[0]);
                    updateCorrectAnswer.Parameters.AddWithValue("@qid", readerCorrectAnswer["QuestionID"]);

                    SqlCommand getFrequency = new SqlCommand(GetFrequency, baglanti.connection());
                    getFrequency.Parameters.AddWithValue("@totalCorrect", readerCorrectAnswer["TotalCorrect"]);
                    SqlDataReader readergetFrequency = getFrequency.ExecuteReader();

                    if ((readerCorrectAnswer["TotalCorrect"].ToString()) == "1")
                    {
                        updateCorrectAnswer.Parameters.AddWithValue("@totalCorrect", 2);
                        updateCorrectAnswer.Parameters.AddWithValue("@frequency", 7);
                        updateCorrectAnswer.ExecuteNonQuery();
                    }
                    if ((readerCorrectAnswer["TotalCorrect"].ToString()) == "2")
                    {
                        updateCorrectAnswer.Parameters.AddWithValue("@totalCorrect", 3);
                        updateCorrectAnswer.Parameters.AddWithValue("@frequency", 30);
                        updateCorrectAnswer.ExecuteNonQuery();
                    }
                    if ((readerCorrectAnswer["TotalCorrect"].ToString()) == "3")
                    {
                        updateCorrectAnswer.Parameters.AddWithValue("@totalCorrect", 4);
                        updateCorrectAnswer.Parameters.AddWithValue("@frequency", 90);
                        updateCorrectAnswer.ExecuteNonQuery();
                    }
                    if ((readerCorrectAnswer["TotalCorrect"].ToString()) == "4")
                    {
                        updateCorrectAnswer.Parameters.AddWithValue("@totalCorrect", 5);
                        updateCorrectAnswer.Parameters.AddWithValue("@frequency", 180);
                        updateCorrectAnswer.ExecuteNonQuery();
                    }
                    if ((readerCorrectAnswer["TotalCorrect"].ToString()) == "5")
                    {
                        updateCorrectAnswer.Parameters.AddWithValue("@totalCorrect", 6);
                        updateCorrectAnswer.Parameters.AddWithValue("@frequency", 365);
                        updateCorrectAnswer.ExecuteNonQuery();
                    }


                }
            }

            if (reader["CorrectAnswer"].ToString() != "D")
            {
                BtnSoruD.BackColor = Color.Red;
            }
            BtnSoruA.Enabled = false;
            BtnSoruB.Enabled = false;
            BtnSoruC.Enabled = false;
            BtnSoruD.Enabled = false;
            baglanti.connection().Close();
        }

        private void BtnDevam_Click(object sender, EventArgs e)
        {
            BtnSoruA.Enabled = true;
            BtnSoruB.Enabled = true;
            BtnSoruC.Enabled = true;
            BtnSoruD.Enabled = true;

            BtnSoruA.BackColor = Color.Aquamarine;
            BtnSoruB.BackColor = Color.Aquamarine;
            BtnSoruC.BackColor = Color.Aquamarine;
            BtnSoruD.BackColor = Color.Aquamarine;
            if (readerCorrectAnswer.Read())
            {
                TxtSoru.Text = readerCorrectAnswer["QuestionID"].ToString();

                TxtSoru.Text += readerCorrectAnswer["QuestionText"].ToString();
                PctSoru.ImageLocation = readerCorrectAnswer["QuestionImage"].ToString();

                BtnSoruA.Text = readerCorrectAnswer["OptionA"].ToString();
                PctSoruA.ImageLocation = readerCorrectAnswer["ImageOptionA"].ToString();

                BtnSoruB.Text = readerCorrectAnswer["OptionB"].ToString();
                PctSoruB.ImageLocation = readerCorrectAnswer["ImageOptionB"].ToString();

                BtnSoruC.Text = readerCorrectAnswer["OptionC"].ToString();
                PctSoruC.ImageLocation = readerCorrectAnswer["ImageOptionC"].ToString();

                BtnSoruD.Text = readerCorrectAnswer["OptionD"].ToString();
                PctSoruD.ImageLocation = readerCorrectAnswer["ImageOptionD"].ToString();
            }
            if (i == 20)
                BtnDevam.Enabled = false;

        }

        int saniye = 0;
        int dakika = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }

            LblSaniye.Text = saniye.ToString();
            LblDakika.Text = dakika.ToString();

            if (dakika == 20 && saniye == 0)
            {
                timer1.Stop();
                MessageBox.Show("Sınav Bitmiştir Tamam Butonuna basın ve Anasayfaya Gidin");
                StudentHomePage studentHomePage = new StudentHomePage();
                studentHomePage.id[0] = id[0];
                studentHomePage.Show();
                this.Hide();
            }
        }
    }
}
