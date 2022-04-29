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

        private void BtnSifreYenile_Click(object sender, EventArgs e)
        {
            resetExaminerPassword();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            ExaminerLogin examinerLogin = new ExaminerLogin();
            examinerLogin.Show();
            this.Hide();
        }

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
                SqlDataReader reader2 = cmd2.ExecuteReader();
                if (reader2.Read())
                {
                    MessageBox.Show("Şifreniz yenilendi=>", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reader2.Close();
                }
                ExaminerLogin examiner = new ExaminerLogin();
                examiner.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("düzgün gir aslan");
            }
        }
    }
}
