﻿using System;
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
        public int[] id = new int[10];
        public StudentLogin()
        {
            InitializeComponent();
        }

        SqlDataReader reader;

        public void TxtOgrenciGiris_Click(object sender, EventArgs e)
        {
            Sql_Connection baglanti = new Sql_Connection();
            baglanti.connection();
            SqlCommand cmd = new SqlCommand("select StudentID from Students where StudentMail=@mail and StudentPassword=@password ", baglanti.connection()); ;
            cmd.Parameters.AddWithValue("@mail", TxtOgrenciMail.Text);
            cmd.Parameters.AddWithValue("@password", TxtOgrenciSifre.Text);

            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                LblID.Text = reader["StudentID"].ToString();
                id[0] = Convert.ToInt32(reader["StudentID"].ToString());
                MessageBox.Show(Convert.ToString(id[0]));
                MessageBox.Show("basarılı");
                StudentHomePage studentHomePage = new StudentHomePage();
                studentHomePage.id[0] = id[0];
                studentHomePage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("yanlış kardeş");
            }

            reader.Close();
        }

        private void BtnOgrenciSİfreUnuttum_Click(object sender, EventArgs e)
        {
            StudentForgotPassword studentForgotPassword = new StudentForgotPassword();
            studentForgotPassword.Show();
            this.Hide();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }


    }
}
