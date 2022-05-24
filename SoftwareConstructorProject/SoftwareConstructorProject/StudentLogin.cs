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

    public partial class StudentLogin : Form
    {
        public int[] id = new int[10];
        public StudentLogin()
        {
            InitializeComponent();
        }

        SqlDataReader reader;


        //ogrencinin sifresini unutmasi durumunda sifre yenileme ekranina yonlendirme islemi
        private void BtnOgrenciSİfreUnuttum_Click(object sender, EventArgs e)
        {
            StudentForgotPassword studentForgotPassword = new StudentForgotPassword();
            studentForgotPassword.Show();
            this.Hide();
        }

        //bir onceki sayfaya yonlendirme islemi
        private void BtnGeri_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        //ogrencinin anasayfasina yonlendirilmesi icin mail ve sifre bilgilerinin kontrolu ve
        //anasayfaya yonlendirme islemi
        private void BtnOgrenciGiris_Click(object sender, EventArgs e)
        {
            Sql_Connection baglanti = new Sql_Connection();
            baglanti.connection();
            SqlCommand cmd = new SqlCommand("select StudentID from Students where StudentMail=@mail and StudentPassword=@password ", baglanti.connection()); ;
            cmd.Parameters.AddWithValue("@mail", TxtOgrenciMail.Text);
            cmd.Parameters.AddWithValue("@password", TxtOgrenciSifre.Text);

            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id[0] = Convert.ToInt32(reader["StudentID"].ToString());
                MessageBox.Show("Giriş Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StudentHomePage studentHomePage = new StudentHomePage();
                studentHomePage.id[0] = id[0];
                studentHomePage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız Lütfen Tekrar Deneyiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reader.Close();
        }
    }
}
