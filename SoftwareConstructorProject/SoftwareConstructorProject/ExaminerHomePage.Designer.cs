
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblExaminerHomePage
            // 
            this.LblExaminerHomePage.AutoSize = true;
            this.LblExaminerHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExaminerHomePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblExaminerHomePage.Location = new System.Drawing.Point(193, 38);
            this.LblExaminerHomePage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblExaminerHomePage.Name = "LblExaminerHomePage";
            this.LblExaminerHomePage.Size = new System.Drawing.Size(599, 29);
            this.LblExaminerHomePage.TabIndex = 0;
            this.LblExaminerHomePage.Text = "SINAV SORUMLUSU ANA SAYFASINA HOŞGELDİNİZ\r\n";
            // 
            // LblIslemSec
            // 
            this.LblIslemSec.AutoSize = true;
            this.LblIslemSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIslemSec.Location = new System.Drawing.Point(300, 85);
            this.LblIslemSec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIslemSec.Name = "LblIslemSec";
            this.LblIslemSec.Size = new System.Drawing.Size(498, 87);
            this.LblIslemSec.TabIndex = 1;
            this.LblIslemSec.Text = "Soru eklemek istiyorsanız \"Soru Ekle\"\r\nİşlem yapmak istemiyorsanız \"Çıkış\" butonu" +
    "na\r\n                        Basınız\r\n";
            // 
            // BtnSoruEkle
            // 
            this.BtnSoruEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSoruEkle.Location = new System.Drawing.Point(198, 228);
            this.BtnSoruEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSoruEkle.Name = "BtnSoruEkle";
            this.BtnSoruEkle.Size = new System.Drawing.Size(152, 63);
            this.BtnSoruEkle.TabIndex = 2;
            this.BtnSoruEkle.Text = "Soru Ekle";
            this.BtnSoruEkle.UseVisualStyleBackColor = true;
            this.BtnSoruEkle.Click += new System.EventHandler(this.BtnSoruEkle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(640, 228);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExaminerHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnSoruEkle);
            this.Controls.Add(this.LblIslemSec);
            this.Controls.Add(this.LblExaminerHomePage);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ExaminerHomePage";
            this.Text = "ExaminerHomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblExaminerHomePage;
        private System.Windows.Forms.Label LblIslemSec;
        private System.Windows.Forms.Button BtnSoruEkle;
        private System.Windows.Forms.Button button1;
    }
}