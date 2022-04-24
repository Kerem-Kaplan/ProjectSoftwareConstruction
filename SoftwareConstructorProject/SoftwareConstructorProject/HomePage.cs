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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void BtnAdminGiris_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();

        }

        private void BtnSinavSorumluGiris_Click(object sender, EventArgs e)
        {
            ExaminerLogin examinerLogin = new ExaminerLogin();
            examinerLogin.Show();
            this.Hide();
        }

        private void BtnOgrenciGiris_Click(object sender, EventArgs e)
        {
            StudentLogin studentLogin = new StudentLogin();
            studentLogin.Show();
            this.Hide();
        }

        private void BtnSinavSorumlusuKayit_Click(object sender, EventArgs e)
        {
            ExaminerRegister examinerRegister = new ExaminerRegister();
            examinerRegister.Show();
            this.Hide();
        }

        private void BtnOgrenciKayıt_Click(object sender, EventArgs e)
        {
            StudentRegister studentRegister = new StudentRegister();
            studentRegister.Show();
            this.Hide();
        }
    }
}
