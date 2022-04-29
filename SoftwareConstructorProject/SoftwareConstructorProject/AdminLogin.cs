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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void BtnAdminGiris_Click(object sender, EventArgs e)
        {
            adminLogin();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        void adminLogin()
        {
            Sql_Connection baglantı = new Sql_Connection();
            SqlCommand cmd = new SqlCommand("select * from Admins where AdminMail=@mail and AdminPassword=@password", baglantı.connection());
            cmd.Parameters.AddWithValue("@mail", TxtAdminMail.Text);
            cmd.Parameters.AddWithValue("@password", TxtAdminSifre.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("basarılı");
                AdminHomePage adminHomePage = new AdminHomePage();
                adminHomePage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen düzgün gir");
            }
        }
    }
}
