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

        private void BtnSinavSorumlusuGiris_Click(object sender, EventArgs e)
        {
            Sql_Connection baglantı = new Sql_Connection();
            baglantı.connection();
            SqlCommand cmd = new SqlCommand("select * from Examiners where ExaminerMail=@mail and ExaminerPassword=@password", baglantı.connection());
            cmd.Parameters.AddWithValue("@mail", TxtSinavSorumlusuMail.Text);
            cmd.Parameters.AddWithValue("@password", TxtSınavSorumlusuSifre.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("basarılı");
            }
            

        }

        private void BtnSinavSorumlusuSifreUnuttum_Click(object sender, EventArgs e)
        {
            ExaminerForgotPassword examinerForgotPassword = new ExaminerForgotPassword();
            examinerForgotPassword.Show();
            this.Hide();
        }
    }
}
