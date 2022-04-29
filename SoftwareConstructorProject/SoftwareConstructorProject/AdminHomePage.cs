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

        private void BtnOgrenciBilgileri_Click(object sender, EventArgs e)
        {
            AdminGetStudents adminGetStudents = new AdminGetStudents();
            adminGetStudents.Show();
            this.Hide();
        }
    }
}
