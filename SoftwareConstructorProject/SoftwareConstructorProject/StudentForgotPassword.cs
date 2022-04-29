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
    public partial class StudentForgotPassword : Form
    {
        public StudentForgotPassword()
        {
            InitializeComponent();
        }

        private void BtnSifreYenile_Click(object sender, EventArgs e)
        {
            resetStudentpassword();
        }

        void resetStudentpassword()
        {
            Sql_Connection baglanti = new Sql_Connection();
            baglanti.connection();
            SqlCommand cmd = new SqlCommand("select * from Students where StudentMail=@mail and StudentSecurityNumber=@number", baglanti.connection());
            cmd.Parameters.AddWithValue("@mail", TxtOgrMail.Text);
            cmd.Parameters.AddWithValue("@number", TxtOgrGuvNo.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() && (TxtOgrSifre.Text == TxtOgrSifreTekrar.Text) && TxtOgrSifre != null && TxtOgrSifreTekrar != null)
            {

                reader.Close();
                SqlCommand cmd2 = new SqlCommand("update Students set StudentPassword=@password where StudentSecurityNumber=@number", baglanti.connection());
                cmd2.Parameters.AddWithValue("@password", TxtOgrSifre.Text);
                cmd2.Parameters.AddWithValue("@number", TxtOgrGuvNo.Text);
                cmd2.ExecuteNonQuery();
                SqlDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.Read())
                {
                    MessageBox.Show("Şifre yenilendi");
                    reader2.Close();
                }

                StudentLogin studentLogin = new StudentLogin();
                studentLogin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Düzgün gir");
            }
        }
    }
}
