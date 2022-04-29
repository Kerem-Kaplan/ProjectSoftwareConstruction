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
    public partial class AdminGetStudents : Form
    {
        public AdminGetStudents()
        {
            InitializeComponent();
        }

        private void BtnKayıtGetir_Click(object sender, EventArgs e)
        {
            kayitgetir();
        }

        private void BtnOgrenciSil_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow drow in DtgOgrenciBilgileri.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                kayitsil(id);
            }
            kayitgetir();

        }

        private void kayitgetir()
        {
            Sql_Connection baglantı = new Sql_Connection();
            baglantı.connection();
            string ogrkayit = "select * from Students";
            SqlCommand cmd = new SqlCommand(ogrkayit, baglantı.connection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            DtgOgrenciBilgileri.DataSource = dataTable;
            baglantı.connection().Close();
        }

         void kayitsil(int id)
        {
            Sql_Connection baglanti = new Sql_Connection();
            baglanti.connection();
            string kayitsil = "delete from Students where StudentID=@id";
            SqlCommand cmd = new SqlCommand(kayitsil, baglanti.connection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            baglanti.connection().Close();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            AdminHomePage adminHomePage = new AdminHomePage();
            adminHomePage.Show();
            this.Hide();
        }
    }
}
