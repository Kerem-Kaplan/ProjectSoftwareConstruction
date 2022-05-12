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
    public partial class ExaminerAddQuestion : Form
    {
        public ExaminerAddQuestion()
        {
            InitializeComponent();
        }

        //veritabanına soru , sıklar,dogru cevap ve resim ekleme islmelerinin yapıldıgı ve
        //kontrol edildigi kod blogu
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Sql_Connection baglantı = new Sql_Connection();
            baglantı.connection();
            SqlCommand cmd = new SqlCommand("insert into Questions(QuestionText,QuestionImage,OptionA,ImageOptionA,OptionB,ImageOptionB,OptionC,ImageOptionC,OptionD,ImageOptionD,QuestionStatus,CorrectAnswer)" +
                "values(@questiontext,@questionimage,@optionA,@imageoptionA,@optionB,@imageoptionB,@optionC,@imageoptionC,@optionD,@imageoptionD,@status,@answer)", baglantı.connection());

            cmd.Parameters.AddWithValue("@questiontext", TxtSoru.Text);
            if (PctSoru.Image != null)
            {
                cmd.Parameters.AddWithValue("@questionimage", openFileDialog1.FileName);
            }
            else
            {
                openFileDialog1.FileName = null;
                cmd.Parameters.AddWithValue("@questionimage", openFileDialog1.FileName);
            }

            cmd.Parameters.AddWithValue("@optionA", TxtSecenekA.Text);
            if (PctSecenekA.Image != null)
            {
                cmd.Parameters.AddWithValue("@imageoptionA", openFileDialog2.FileName);
            }
            else
            {
                openFileDialog2.FileName = null;
                cmd.Parameters.AddWithValue("@imageoptionA", openFileDialog2.FileName);
            }

            cmd.Parameters.AddWithValue("@optionB", TxtSecenekB.Text);
            if (PctSecenekB.Image != null)
            {
                cmd.Parameters.AddWithValue("@imageoptionB", openFileDialog3.FileName);
            }
            else
            {
                openFileDialog3.FileName = null;
                cmd.Parameters.AddWithValue("@imageoptionB", openFileDialog3.FileName);
            }

            cmd.Parameters.AddWithValue("@optionC", TxtSecenekC.Text);
            if (PctSecenekC.Image != null)
            {
                cmd.Parameters.AddWithValue("@imageoptionC", openFileDialog4.FileName);
            }
            else
            {
                openFileDialog4.FileName = null;
                cmd.Parameters.AddWithValue("@imageoptionC", openFileDialog4.FileName);
            }

            cmd.Parameters.AddWithValue("@optionD", TxtSecenekD.Text);
            if (PctSecenekD.Image != null)
            {
                cmd.Parameters.AddWithValue("@imageoptionD", openFileDialog5.FileName);
            }
            else
            {
                openFileDialog5.FileName = null;
                cmd.Parameters.AddWithValue("@imageoptionD", openFileDialog5.FileName);
            }

            cmd.Parameters.AddWithValue("@status", false);


            if (CmbDogruCevap.SelectedItem != null)
            {

                if (CmbDogruCevap.SelectedItem.ToString() == "A")
                {
                    cmd.Parameters.AddWithValue("@answer", CmbDogruCevap.SelectedItem.ToString());
                }

                else if (CmbDogruCevap.SelectedItem.ToString() == "B")
                {
                    cmd.Parameters.AddWithValue("@answer", CmbDogruCevap.SelectedItem.ToString());
                }

                else if (CmbDogruCevap.SelectedItem.ToString() == "C")
                {
                    cmd.Parameters.AddWithValue("@answer", CmbDogruCevap.SelectedItem.ToString());
                }
                else if (CmbDogruCevap.SelectedItem.ToString() == "D")
                {
                    cmd.Parameters.AddWithValue("@answer", CmbDogruCevap.SelectedItem.ToString());
                }
                cmd.ExecuteNonQuery();

                MessageBox.Show("Eklendi");
                ExaminerHomePage examinerHomePage = new ExaminerHomePage();
                examinerHomePage.Show();
                this.Hide();
                baglantı.connection().Close();
            }

            else
            {
                MessageBox.Show("Düzgün Gir");
            }

        }

        //soru icin resim ekleme islemi
        private void BtnSoruResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            PctSoru.ImageLocation = openFileDialog1.FileName;
        }

        //A sıkkı icin resim ekleme islemi
        private void BtnSecenekAResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            PctSecenekA.ImageLocation = openFileDialog2.FileName;
        }

        //B sıkkı icin resim ekleme islemi
        private void BtnSecenekBResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
            PctSecenekB.ImageLocation = openFileDialog3.FileName;
        }

        //C sıkkı icin resim ekleme islemi
        private void BtnSecenekCResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog4.ShowDialog();
            PctSecenekC.ImageLocation = openFileDialog4.FileName;
        }

        //D sıkkı icin resim ekleme islemi
        private void BtnSecenekDResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog5.ShowDialog();
            PctSecenekD.ImageLocation = openFileDialog5.FileName;
        }


    }
}
