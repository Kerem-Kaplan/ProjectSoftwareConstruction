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
        public int[] id = new int[10];
        public StudentHomePage()
        {
            InitializeComponent();
        }

        //ogerncinin sureye dayali sinav ekranina yonlendirme islemi
        private void BtnSinavSistemiGiris_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tamam Butonuna Bastıktan Sonra Toplam Süreniz 20 Dakika", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            StudentExamPage studentExamPage = new StudentExamPage();
            studentExamPage.id[0] = id[0];
            studentExamPage.Show();
            this.Hide();

        }

        //ogrencinin sıklık ayarlama ekranına yonlendirilme islemi
        private void BtnAyarlar_Click(object sender, EventArgs e)
        {
            StudentFrequencySetting studentFrequencySetting = new StudentFrequencySetting();
            studentFrequencySetting.Show();
            studentFrequencySetting.id[0] = id[0];
            this.Hide();
        }

        

        //ogrencinin sureye dayali olmayan sinav ekranina yönlendirilmesi
        private void BtnZamansizSinav_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tamam Butonuna Bastıktan Sonra Sınava Başlayabilirsiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            StudentUntimelyExamPage studentUntimelyExamPage = new StudentUntimelyExamPage();
            studentUntimelyExamPage.id[0] = id[0];
            studentUntimelyExamPage.Show();
            this.Hide();
        }

        //ogrencinin kendisi hakkinda rapor almasi icin rapor sayfasina yonlendirilme islemi
        private void BtnAnalizRaporu_Click(object sender, EventArgs e)
        {
            StudentAnalysisReport studentAnalysisReport = new StudentAnalysisReport();
            studentAnalysisReport.id[0] = id[0];
            studentAnalysisReport.Show();
            this.Hide();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            StudentLogin studentLogin = new StudentLogin();
            studentLogin.Show();
            this.Hide();
        }
    }
}
