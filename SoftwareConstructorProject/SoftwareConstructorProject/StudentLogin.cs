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
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
        }

        private void TxtOgrenciGiris_Click(object sender, EventArgs e)
        {
            Sql_Connection baglanti = new Sql_Connection();
            baglanti.connection();
            SqlCommand cmd = new SqlCommand("select * from Students where StudentMail=@mail and StudentPassword=@password", baglanti.connection());
            cmd.Parameters.AddWithValue("@mail", TxtOgrenciMail.Text);
            cmd.Parameters.AddWithValue("@password", TxtOgrenciSifre.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("basarılı");
            }
            else
            {
                MessageBox.Show("yanlış kardeş"); 
            }
        }
    }
}
