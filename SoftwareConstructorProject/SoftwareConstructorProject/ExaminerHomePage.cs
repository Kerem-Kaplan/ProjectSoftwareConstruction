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
    public partial class ExaminerHomePage : Form
    {
        public ExaminerHomePage()
        {
            InitializeComponent();
        }

        private void BtnSoruEkle_Click(object sender, EventArgs e)
        {
            ExaminerAddQuestion examinerAddQuestion = new ExaminerAddQuestion();
            examinerAddQuestion.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExaminerLogin examinerLogin = new ExaminerLogin();
            examinerLogin.Show();
            this.Hide();
        }
    }
}
