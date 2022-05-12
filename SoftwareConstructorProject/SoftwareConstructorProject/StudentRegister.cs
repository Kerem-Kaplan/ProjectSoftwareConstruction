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
                MessageBox.Show("Geçerli isim girin");
            }

            else if (TxtOgrenciSoyIsim.Text == "")
            {
                MessageBox.Show("geçerli soyisim girin");
            }

            else if (TxtOgrenciMail.Text == "")
            {
                MessageBox.Show("gecerli mail gir");
            }
            else if (TxtOgrenciSifre.Text == "" || TxtSifreTekrar.Text == "")
            {
                MessageBox.Show("şifreyi bos gecmee");
            }
            else if (TxtGuvenlikNo.Text == "")
            {
                MessageBox.Show("güvenlik no girin");
            }

            else
            {
                if (TxtOgrenciSifre.Text != TxtSifreTekrar.Text)
                {
                    MessageBox.Show("Lütfen şifreleri aynı girin");
                }
                else
                {
                    MessageBox.Show("Şifreler aynı ");
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
