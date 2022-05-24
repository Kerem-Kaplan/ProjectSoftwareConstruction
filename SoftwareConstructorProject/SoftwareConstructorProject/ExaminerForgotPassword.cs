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
    public partial class ExaminerForgotPassword : Form
    {
        public ExaminerForgotPassword()
        {
            InitializeComponent();
        }

        //yenilenmek istenen sifrenin kime ait oldugunun kontrolu ve yeni sifrenin veritabanına
        //yansıtıldıgı bolum
        private void BtnSifreYenile_Click(object sender, EventArgs e)
        {
            resetExaminerPassword();
        }

        //islemden vazgecildiginde bir onceki sayfaya yonlendirme islemi 
        private void BtnGeri_Click(object sender, EventArgs e)
        {
            ExaminerLogin examinerLogin = new ExaminerLogin();
            examinerLogin.Show();
            this.Hide();
        }

        //yenilenecek olan sifrenin kime ait oldugunu ve sifrenin veritabanına kaydedilmesi icin
        //gerekli olan kod blogu
        void resetExaminerPassword()
        {
            Sql_Connection baglantı = new Sql_Connection();
            baglantı.connection();
            SqlCommand cmd = new SqlCommand("select * from Examiners where ExaminerMail=@mail and ExaminerSecurityNumber=@number", baglantı.connection());
            cmd.Parameters.AddWithValue("@mail", TxtSorumluMail.Text);
            cmd.Parameters.AddWithValue("@number", TxtSorumluGuvNo.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() && (TxtSorumluSifre.Text == TxtSorumluSifreTekrar.Text) && TxtSorumluSifre != null && TxtSorumluSifreTekrar != null)
            {
                reader.Close();
                SqlCommand cmd2 = new SqlCommand("update Examiners set ExaminerPassword=@password where ExaminerSecurityNumber=@number", baglantı.connection());
                cmd2.Parameters.AddWithValue("@password", TxtSorumluSifre.Text);
                cmd2.Parameters.AddWithValue("@number", TxtSorumluGuvNo.Text);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Şifreniz yenilendi", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ExaminerLogin examiner = new ExaminerLogin();
                examiner.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen Bilgileri Doğru ve Eksiksiz Giriniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
