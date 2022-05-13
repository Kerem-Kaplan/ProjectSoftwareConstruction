
namespace SoftwareConstructorProject
{
    partial class ExaminerHomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblExaminerHomePage = new System.Windows.Forms.Label();
            this.LblIslemSec = new System.Windows.Forms.Label();
            this.BtnSoruEkle = new System.Windows.Forms.Button();
            this.BtnCıkıs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblExaminerHomePage
            // 
            this.LblExaminerHomePage.AutoSize = true;
            this.LblExaminerHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExaminerHomePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblExaminerHomePage.Location = new System.Drawing.Point(145, 31);
            this.LblExaminerHomePage.Name = "LblExaminerHomePage";
            this.LblExaminerHomePage.Size = new System.Drawing.Size(473, 24);
            this.LblExaminerHomePage.TabIndex = 0;
            this.LblExaminerHomePage.Text = "SINAV SORUMLUSU ANA SAYFASINA HOŞGELDİNİZ\r\n";
            // 
            // LblIslemSec
            // 
            this.LblIslemSec.AutoSize = true;
            this.LblIslemSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIslemSec.Location = new System.Drawing.Point(189, 68);
            this.LblIslemSec.Name = "LblIslemSec";
            this.LblIslemSec.Size = new System.Drawing.Size(389, 72);
            this.LblIslemSec.TabIndex = 1;
            this.LblIslemSec.Text = "Soru eklemek istiyorsanız \"Soru Ekle\"\r\nİşlem yapmak istemiyorsanız \"Çıkış\" butonu" +
    "na\r\n                        Basınız\r\n";
            // 
            // BtnSoruEkle
            // 
            this.BtnSoruEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSoruEkle.Location = new System.Drawing.Point(148, 185);
            this.BtnSoruEkle.Name = "BtnSoruEkle";
            this.BtnSoruEkle.Size = new System.Drawing.Size(114, 51);
            this.BtnSoruEkle.TabIndex = 2;
            this.BtnSoruEkle.Text = "Soru Ekle";
            this.BtnSoruEkle.UseVisualStyleBackColor = true;
            this.BtnSoruEkle.Click += new System.EventHandler(this.BtnSoruEkle_Click);
            // 
            // BtnCıkıs
            // 
            this.BtnCıkıs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCıkıs.Location = new System.Drawing.Point(386, 185);
            this.BtnCıkıs.Name = "BtnCıkıs";
            this.BtnCıkıs.Size = new System.Drawing.Size(114, 51);
            this.BtnCıkıs.TabIndex = 3;
            this.BtnCıkıs.Text = "Çıkış";
            this.BtnCıkıs.UseVisualStyleBackColor = false;
            this.BtnCıkıs.Click += new System.EventHandler(this.BtnCıkıs_Click);
            // 
            // ExaminerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCıkıs);
            this.Controls.Add(this.BtnSoruEkle);
            this.Controls.Add(this.LblIslemSec);
            this.Controls.Add(this.LblExaminerHomePage);
            this.Name = "ExaminerHomePage";
            this.Text = "Sorumlu Ana Sayfası";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblExaminerHomePage;
        private System.Windows.Forms.Label LblIslemSec;
        private System.Windows.Forms.Button BtnSoruEkle;
        private System.Windows.Forms.Button BtnCıkıs;
    }
}