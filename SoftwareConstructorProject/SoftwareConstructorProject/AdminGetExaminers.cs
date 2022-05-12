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
    public partial class AdminGetExaminers : Form
    {
        public AdminGetExaminers()
        {
            InitializeComponent();
        }

        //sisteme kayitli sinav sorumlularinin getirilmesi
        private void BtnBilgiGetir_Click(object sender, EventArgs e)
        {
            kayitGetir();
        }

        //Bir onceki sayfaya donme
        private void BtnGeri_Click(object sender, EventArgs e)
        {
            AdminHomePage adminHomePage = new AdminHomePage();
            adminHomePage.Show();
            this.Hide();
        }

        //Istenilen sinav sorumlusunun silinmesi 
        private void BtnSinavSorumluSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in DtgSorumluBilgileri.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                kayitSil(id);
            }
            kayitGetir();
            MessageBox.Show("Kayıt Silinmiştir");
        }

        //sinav sorumlusu getirmek icin gereken kod blogu
        private void kayitGetir()
        {
            Sql_Connection baglanti = new Sql_Connection();
            baglanti.connection();
            string srmKayit = "select * from Examiners";
            SqlCommand cmd = new SqlCommand(srmKayit, baglanti.connection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            DtgSorumluBilgileri.DataSource = dataTable;
            baglanti.connection().Close();
        }

        //sinav sorumlusunu silmek icin gereken kod blogu
        private void kayitSil(int id)
        {
            Sql_Connection baglanti = new Sql_Connection();
            baglanti.connection();
            string kayitSil = "delete from Examiners where ExaminerID=@id";
            SqlCommand cmd = new SqlCommand(kayitSil, baglanti.connection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            baglanti.connection().Close();
        }
    }
}
