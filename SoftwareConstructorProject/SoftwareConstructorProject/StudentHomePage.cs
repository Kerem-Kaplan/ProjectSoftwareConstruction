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

        private void BtnSinavSistemiGiris_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(id[0]));
            MessageBox.Show("Tamam tuşuna bastıktan sonra her soru için 10 dakikanız bulunmaktadır");
            StudentExamPage studentExamPage = new StudentExamPage();
            studentExamPage.id[0] = id[0];
            studentExamPage.Show();
            this.Hide();

        }

        private void BtnAyarlar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(id[0]));
            StudentFrequencySetting studentFrequencySetting = new StudentFrequencySetting();
            studentFrequencySetting.Show();
            studentFrequencySetting.id[0] = id[0];
            this.Hide();
        }

        private void StudentHomePage_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(id[0]));
        }

        private void BtnZamansizSinav_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(id[0]));
            MessageBox.Show("Tamam tuşuna bastıktan sonra sınava başlayabilirsiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            StudentUntimelyExamPage studentUntimelyExamPage = new StudentUntimelyExamPage();
            studentUntimelyExamPage.id[0] = id[0];
            studentUntimelyExamPage.Show();
            this.Hide();
        }

        private void BtnAnalizRaporu_Click(object sender, EventArgs e)
        {
            StudentAnalysisReport studentAnalysisReport = new StudentAnalysisReport();
            studentAnalysisReport.id[0] = id[0];
            studentAnalysisReport.Show();
            this.Hide();
        }
    }
}
