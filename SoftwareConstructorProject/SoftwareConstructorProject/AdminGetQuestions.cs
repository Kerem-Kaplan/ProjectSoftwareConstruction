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
    public partial class AdminGetQuestions : Form
    {
        public AdminGetQuestions()
        {
            InitializeComponent();
        }

        //sistemwe kayitli olan sorularin getirilmesi
        private void BtnSoruBilgiGetir_Click(object sender, EventArgs e)
        {
            kayitGetir();
        }

        //secili satira göre istenilen sorunun silinmesi
        private void BtnSoruSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in DtgSorular.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                kayitSil(id);
            }
            kayitGetir();
            MessageBox.Show("Kayıt Silinmiştir");

        }

        //bir onceki sayfaya donme islemi
        private void BtnGeri_Click(object sender, EventArgs e)
        {
            AdminHomePage adminHomePage = new AdminHomePage();
            adminHomePage.Show();
            this.Hide();
        }

        //sisteme kayitli soruların getirilmesi icin gereken kod blogu
        private void kayitGetir()
        {
            Sql_Connection baglanti = new Sql_Connection();
            baglanti.connection();
            string srmKayit = "select * from Questions";
            SqlCommand cmd = new SqlCommand(srmKayit, baglanti.connection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            DtgSorular.DataSource = dataTable;
            baglanti.connection().Close();
        }

        //istenilen sorunun silinmesi icin gereken kod blogu
        private void kayitSil(int id)
        {
            Sql_Connection baglanti = new Sql_Connection();
            baglanti.connection();
            string kayitSil = "delete from Questions where QuestionID=@id";
            SqlCommand cmd = new SqlCommand(kayitSil, baglanti.connection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            baglanti.connection().Close();

        }
    }
}
