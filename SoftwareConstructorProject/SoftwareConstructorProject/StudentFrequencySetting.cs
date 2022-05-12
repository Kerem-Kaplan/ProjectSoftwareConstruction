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
    public partial class StudentFrequencySetting : Form
    {
        public StudentFrequencySetting()
        {
            InitializeComponent();
        }
        public int[] id = new int[10];

        Sql_Connection baglanti = new Sql_Connection();

        readonly string ChangeFrequency = "update Frequencyy set Frequencyy=@frequency where TotalCorrect=@totalCorrect";

        readonly string GetFrequency = "select * from Frequencyy where TotalCorrect=@totalCorrect";

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TxtDogruSayisi.Text) >= 1 || Convert.ToInt32(TxtDogruSayisi.Text) <= 6 || Convert.ToInt32(TxtSıklık.Text) > 0)
            {
                baglanti.connection();

                SqlCommand getFrequency = new SqlCommand(GetFrequency, baglanti.connection());
                getFrequency.Parameters.AddWithValue("@totalCorrect", TxtDogruSayisi.Text);
                SqlDataReader readergetFrequency = getFrequency.ExecuteReader();
                if (readergetFrequency.Read())
                {
                    SqlCommand changeFrequency = new SqlCommand(ChangeFrequency, baglanti.connection());

                    changeFrequency.Parameters.AddWithValue("@totalCorrect", TxtDogruSayisi.Text);
                    changeFrequency.Parameters.AddWithValue("@frequency", TxtSıklık.Text);
                    changeFrequency.ExecuteNonQuery();

                }
                else
                {
                    MessageBox.Show("Yanlıs");
                }
            }

            //SqlCommand getFrequency = new SqlCommand(GetFrequency, baglanti.connection());
            //getFrequency.Parameters.AddWithValue("@totalCorrect", 1);
            //SqlDataReader readergetFrequency;
            //readergetFrequency = getFrequency.ExecuteReader();

            if (1 == 1)
            {
























                //if (Convert.ToInt32(readergetFrequency["TotalCorrect"].ToString()) == 1)
                //{
                //    changeFrequency.Parameters.AddWithValue("@frequency", TxtilkDogru.Text);

                //}



                //if (Convert.ToInt32(readergetFrequency["TotalCorrect"].ToString()) == 2)
                //{
                //    changeFrequency.Parameters.AddWithValue("@frequency", TxtikinciDogru.Text);

                //}

                //if (Convert.ToInt32(readergetFrequency["TotalCorrect"].ToString()) == 3)
                //{
                //    changeFrequency.Parameters.AddWithValue("@frequency", TxtucuncuDogru.Text);

                //}

                //if (Convert.ToInt32(readergetFrequency["TotalCorrect"].ToString()) == 4)
                //{
                //    changeFrequency.Parameters.AddWithValue("@frequency", TxtdorduncuDogru.Text);

                //}
                //if (Convert.ToInt32(readergetFrequency["TotalCorrect"].ToString()) == 5)
                //{
                //    changeFrequency.Parameters.AddWithValue("@frequency", TxtbesinciDogru.Text);

                //}
                //changeFrequency.Parameters.AddWithValue("@totalCorrect", 6);
                //if (Convert.ToInt32(readergetFrequency["TotalCorrect"].ToString()) == 6)
                //{
                //    changeFrequency.Parameters.AddWithValue("@frequency", TxtaltinciDogru.Text);
                //    changeFrequency.ExecuteNonQuery();
                //}


            }

        }

        private void TxtilkDogru_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtikinciDogru_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtucuncuDogru_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtdorduncuDogru_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtbesinciDogru_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtaltinciDogru_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void StudentFrequencySetting_Load(object sender, EventArgs e)
        {

        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            StudentHomePage studentHomePage = new StudentHomePage();
            studentHomePage.id[0] = id[0];
            studentHomePage.Show();
            this.Hide();
        }
    }
}

