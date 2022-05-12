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

        //soru ekleme sayfasinin acılacagı islem bolumu
        private void BtnSoruEkle_Click(object sender, EventArgs e)
        {
            ExaminerAddQuestion examinerAddQuestion = new ExaminerAddQuestion();
            examinerAddQuestion.Show();
            this.Hide();
        }

        //cıkıs yapma ve login ekranına geri donme islemi
        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            ExaminerLogin examinerLogin = new ExaminerLogin();
            examinerLogin.Show();
            this.Hide();
        }
    }
}
