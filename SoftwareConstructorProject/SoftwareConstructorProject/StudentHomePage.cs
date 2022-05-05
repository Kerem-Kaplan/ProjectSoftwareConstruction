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
    public partial class StudentHomePage : Form
    {
        public StudentHomePage()
        {
            InitializeComponent();
        }

        private void BtnSinavSistemiGiris_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tamam tuşuna bastıktan sonra her soru için 10 dakikanız bulunmaktadır");
            StudentExamPage studentExamPage = new StudentExamPage();
            studentExamPage.Show();
            this.Hide();
        }
    }
}
