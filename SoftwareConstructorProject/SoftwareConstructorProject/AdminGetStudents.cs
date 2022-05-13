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

        //sisteme kayitli olan ogrenci bilgilerinin getirilmesi
        private void BtnKayıtGetir_Click(object sender, EventArgs e)
        {
            kayitGetir();
        }

        //secilen satira gore ogrencinin silinmesi
        private void BtnOgrenciSil_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow drow in DtgOgrenciBilgileri.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                kayitSil(id);
            }
            kayitGetir();
            MessageBox.Show("Kayıt Silinmiştir", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //ogrencilerin kaydini getirmesi icin gereken kod blogu
        private void kayitGetir()
        {
            Sql_Connection baglantı = new Sql_Connection();
            baglantı.connection();
            string ogrKayit = "select * from Students";
            SqlCommand cmd = new SqlCommand(ogrKayit, baglantı.connection());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            DtgOgrenciBilgileri.DataSource = dataTable;
            baglantı.connection().Close();
        }

        //silinecek olan ogrenci icin gerekli olan kod blogu
        void kayitSil(int id)
        {
            Sql_Connection baglanti = new Sql_Connection();
            baglanti.connection();
            string kayitSil = "delete from Students where StudentID=@id";
            SqlCommand cmd = new SqlCommand(kayitSil, baglanti.connection());
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            baglanti.connection().Close();
        }

        //bir onceki sayfaya donme islemi
        private void BtnGeri_Click(object sender, EventArgs e)
        {
            AdminHomePage adminHomePage = new AdminHomePage();
            adminHomePage.Show();
            this.Hide();
        }
    }
}
