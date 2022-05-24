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
    public partial class ExaminerLogin : Form
    {
        public ExaminerLogin()
        {
            InitializeComponent();
        }

        //tiklandiginda bilgiler dogru ise yonlendirilmek istenen sayfanın acılması islemi
        private void BtnSinavSorumlusuGiris_Click(object sender, EventArgs e)
        {
            examinerLogin();
        }

        //sifre yenileme ekanının acılma islemi
        private void BtnSinavSorumlusuSifreUnuttum_Click(object sender, EventArgs e)
        {
            ExaminerForgotPassword examinerForgotPassword = new ExaminerForgotPassword();
            examinerForgotPassword.Show();
            this.Hide();
        }

        //bir onceki sayfaya donme islemi
        private void BtnGeri_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        //giris yapılacagında bilgilerin kontrol edildigi kod blogu
        void examinerLogin()
        {
            Sql_Connection baglantı = new Sql_Connection();
            baglantı.connection();
            SqlCommand cmd = new SqlCommand("select * from Examiners where ExaminerMail=@mail and ExaminerPassword=@password", baglantı.connection());
            cmd.Parameters.AddWithValue("@mail", TxtSinavSorumlusuMail.Text);
            cmd.Parameters.AddWithValue("@password", TxtSınavSorumlusuSifre.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Giriş Başarılı", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ExaminerHomePage examinerHomePage = new ExaminerHomePage();
                examinerHomePage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
