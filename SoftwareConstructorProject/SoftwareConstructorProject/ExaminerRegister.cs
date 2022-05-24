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
    public partial class ExaminerRegister : Form
    {
        public ExaminerRegister()
        {
            InitializeComponent();
        }

        //sisteme yeni bir sorumlunun kayit islemi ve veritabanina kayit yapilmasi
        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            Sql_Connection baglanti = new Sql_Connection();
            baglanti.connection();
            SqlCommand cmd = new SqlCommand("insert into Examiners(ExaminerName,ExaminerSurname,ExaminerMail,ExaminerPassword,ExaminerSecurityNumber)" +
                            "values (@name,@surname,@mail,@password,@number)", baglanti.connection());
            cmd.Parameters.AddWithValue("@name", TxtSinavSorumluIsim.Text);
            cmd.Parameters.AddWithValue("@surname", TxtSinavSorumluSoyIsim.Text);
            cmd.Parameters.AddWithValue("@mail", TxtSinavSorumluMail.Text);
            cmd.Parameters.AddWithValue("password", TxtSinavSorumluSifre.Text);
            cmd.Parameters.AddWithValue("@number", TxtGuvenlikNo.Text);

            if (TxtSinavSorumluIsim.Text == "")
            {
                MessageBox.Show("Lütfen Geçerli Bir İsim Giriniz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (TxtSinavSorumluSoyIsim.Text == "")
            {
                MessageBox.Show("Lütfen Geçerli Soyisim Giriniz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (TxtSinavSorumluMail.Text == "")
            {
                MessageBox.Show("Lütfen Geçerli Bir Mail Adresi Giriniz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (TxtSinavSorumluSifre.Text == "" || TxtSifreTekrar.Text == "")
            {

                MessageBox.Show("Lütfen Şifre Giriniz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (TxtGuvenlikNo.Text == "")
            {
                MessageBox.Show("Lütfen Güvenlik Numarası Giriniz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (TxtSinavSorumluSifre.Text != TxtSifreTekrar.Text)
                {
                    MessageBox.Show("Lütfen Şifreleri Aynı Giriniz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Kayıt Başarılı", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd.ExecuteNonQuery();
                    baglanti.connection().Close();
                    ExaminerLogin examinerLogin = new ExaminerLogin();
                    examinerLogin.Show();
                    this.Hide();
                }

            }



        }

        //sorumlu bir hesaba sahipse sorumlu icin giris ekranına ynlendirme islemi
        private void BtnHesapSahipligi_Click(object sender, EventArgs e)
        {
            ExaminerLogin examinerLogin = new ExaminerLogin();
            examinerLogin.Show();
            this.Hide();
        }

        //textboX'a girilecek degerlerin yalnızca sayi olmasini saglamak icin gereken islem
        private void TxtGuvenlikNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //bir onceki sayfaya donme islemi
        private void BtnGeri_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }
    }
}
