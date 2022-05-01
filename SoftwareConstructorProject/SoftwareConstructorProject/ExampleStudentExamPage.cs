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
    public partial class ExampleStudentExamPage : Form
    {
        public ExampleStudentExamPage()
        {
            InitializeComponent();
        }

        private void ExampleStudentExamPage_Load(object sender, EventArgs e)
        {
            Sql_Connection baglanti = new Sql_Connection();
            baglanti.connection();
            Random rand = new Random();
            rand.Next();
            string randomValue = "select  * from Questions order by NEWID()";
            SqlCommand cmd = new SqlCommand(randomValue, baglanti.connection());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                RchTxtSorular.Text += reader["QuestionText"].ToString()+Environment.NewLine;

            }
        }
    }
}
