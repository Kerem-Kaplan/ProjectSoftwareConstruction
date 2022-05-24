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
    public partial class StudentRegister : Form
    {
        public StudentRegister()
        {
            InitializeComponent();
        }

        //ogrenci eger bir hesaba sahipse ogrenci icin giris ekranina yonlendirilme islemi
        private void BtnHesapSahipligi_Click(object sender, EventArgs e)
        {
            StudentLogin studentLogin = new StudentLogin();
            studentLogin.Show();
            this.Hide();
        }

        //ogrenci bilgilerinin alinip veritabanina kayit yapilma islemi
        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            Sql_Connection baglanti = new Sql_Connection();
            baglanti.connection();
            SqlCommand cmd = new SqlCommand("insert into Students(StudentName,StudentSurname,StudentMail,StudentPassword,StudentSecurityNumber)" +
                "values(@name,@surname,@mail,@password,@number)", baglanti.connection());
            cmd.Parameters.AddWithValue("@name", TxtOgrenciIsim.Text);
            cmd.Parameters.AddWithValue("@surname", TxtOgrenciSoyIsim.Text);
            cmd.Parameters.AddWithValue("@mail", TxtOgrenciMail.Text);
            cmd.Parameters.AddWithValue("@password", TxtOgrenciSifre.Text);
            cmd.Parameters.AddWithValue("@number", TxtGuvenlikNo.Text);

            if (TxtOgrenciIsim.Text == "")
            {
                MessageBox.Show("Lütfen Geçerli Bir İsim Giriniz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (TxtOgrenciSoyIsim.Text == "")
            {
                MessageBox.Show("Lütfen Geçerli Soyisim Giriniz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (TxtOgrenciMail.Text == "")
            {
                MessageBox.Show("Lütfen Geçerli Bir Mail Adresi Giriniz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (TxtOgrenciSifre.Text == "" || TxtSifreTekrar.Text == "")
            {
                MessageBox.Show("Lütfen Şifre Giriniz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (TxtGuvenlikNo.Text == "")
            {
                MessageBox.Show("Lütfen Güvenlik Numarası Giriniz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                if (TxtOgrenciSifre.Text != TxtSifreTekrar.Text)
                {
                    MessageBox.Show("Lütfen Şifreleri Aynı Giriniz", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Kayıt Başarılı", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd.ExecuteNonQuery();
                    baglanti.connection().Close();
                    StudentLogin studentLogin = new StudentLogin();
                    studentLogin.Show();
                    this.Hide();
                }
            }

        }

        //guvenlik numarasinin yalnizca sayi girilmesi kısıtlamasi
        private void TxtGuvenlikNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //onceki sayfaya yonlendirme islemi
        private void BtnGeri_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }
    }
}
