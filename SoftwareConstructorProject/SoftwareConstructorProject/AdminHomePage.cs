using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareConstructorProject
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        //ogrenci bilgilerinin goruntulenebilecegi ve islem yapılabilecegi sayfaya yonlendirme islemi
        private void BtnOgrenciBilgileri_Click(object sender, EventArgs e)
        {
            AdminGetStudents adminGetStudents = new AdminGetStudents();
            adminGetStudents.Show();
            this.Hide();
        }

        //sorumlu bilgilerinin goruntulenebilecegi ve islem yapılabilecegi sayfaya yonlendirme islemi
        private void BtnSorumluBilgileri_Click(object sender, EventArgs e)
        {
            AdminGetExaminers adminGetExaminers = new AdminGetExaminers();
            adminGetExaminers.Show();
            this.Hide();
        }

        //soruların goruntulenecegi ve islem yapılacagı sayfaya yonlendirme islemi
        private void BtnSorulariGetir_Click(object sender, EventArgs e)
        {
            AdminGetQuestions adminGetQuestions = new AdminGetQuestions();
            adminGetQuestions.Show();
            this.Hide();
        }

        //cikis yapma islemi
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }
    }
}
