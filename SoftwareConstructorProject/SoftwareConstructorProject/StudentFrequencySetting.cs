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

        //ogrenci istedigi dogru sayisina gore o sorunun gelme sıklıgını ayarlama islemi
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
                    MessageBox.Show("Sıklık Güncellendi", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    changeFrequency.ExecuteNonQuery();

                }
                else
                {
                    MessageBox.Show("Lütfen Değerleri Doğru Giriniz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void StudentFrequencySetting_Load(object sender, EventArgs e)
        {

        }

        //bir onceki sayfaya yonlendirme islemi
        private void BtnGeri_Click(object sender, EventArgs e)
        {
            StudentHomePage studentHomePage = new StudentHomePage();
            studentHomePage.id[0] = id[0];
            studentHomePage.Show();
            this.Hide();
        }
    }
}

