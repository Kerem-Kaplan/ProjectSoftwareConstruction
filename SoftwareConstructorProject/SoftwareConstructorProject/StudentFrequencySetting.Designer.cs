﻿
namespace SoftwareConstructorProject
{
    partial class StudentFrequencySetting
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
            this.LblilkDogru = new System.Windows.Forms.Label();
            this.LblikinciDogru = new System.Windows.Forms.Label();
            this.TxtSıklık = new System.Windows.Forms.TextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.LblBilgilendirme = new System.Windows.Forms.Label();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.TxtDogruSayisi = new System.Windows.Forms.TextBox();
            this.LblAralık = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblilkDogru
            // 
            this.LblilkDogru.AutoSize = true;
            this.LblilkDogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblilkDogru.Location = new System.Drawing.Point(284, 156);
            this.LblilkDogru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblilkDogru.Name = "LblilkDogru";
            this.LblilkDogru.Size = new System.Drawing.Size(52, 24);
            this.LblilkDogru.TabIndex = 0;
            this.LblilkDogru.Text = "Sıklık";
            // 
            // LblikinciDogru
            // 
            this.LblikinciDogru.AutoSize = true;
            this.LblikinciDogru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblikinciDogru.Location = new System.Drawing.Point(569, 155);
            this.LblikinciDogru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblikinciDogru.Name = "LblikinciDogru";
            this.LblikinciDogru.Size = new System.Drawing.Size(115, 24);
            this.LblikinciDogru.TabIndex = 4;
            this.LblikinciDogru.Text = "Doğru Sayısı";
            // 
            // TxtSıklık
            // 
            this.TxtSıklık.Location = new System.Drawing.Point(289, 206);
            this.TxtSıklık.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtSıklık.MaxLength = 3;
            this.TxtSıklık.Name = "TxtSıklık";
            this.TxtSıklık.Size = new System.Drawing.Size(132, 22);
            this.TxtSıklık.TabIndex = 6;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKaydet.Location = new System.Drawing.Point(289, 335);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(129, 57);
            this.BtnKaydet.TabIndex = 12;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // LblBilgilendirme
            // 
            this.LblBilgilendirme.AutoSize = true;
            this.LblBilgilendirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBilgilendirme.Location = new System.Drawing.Point(196, 44);
            this.LblBilgilendirme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBilgilendirme.Name = "LblBilgilendirme";
            this.LblBilgilendirme.Size = new System.Drawing.Size(546, 48);
            this.LblBilgilendirme.TabIndex = 13;
            this.LblBilgilendirme.Text = "SORULARIN ÇIKMA SIKLIĞINI DEĞİŞTİRMEK \r\nİÇİN AŞAĞIDAKİ KUTUCUKLARA İSTEDİĞİNİZ DE" +
    "ĞERİ GİRİNİZ";
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGeri.Location = new System.Drawing.Point(577, 335);
            this.BtnGeri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(129, 57);
            this.BtnGeri.TabIndex = 14;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // TxtDogruSayisi
            // 
            this.TxtDogruSayisi.Location = new System.Drawing.Point(573, 206);
            this.TxtDogruSayisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDogruSayisi.MaxLength = 1;
            this.TxtDogruSayisi.Name = "TxtDogruSayisi";
            this.TxtDogruSayisi.Size = new System.Drawing.Size(132, 22);
            this.TxtDogruSayisi.TabIndex = 19;
            // 
            // LblAralık
            // 
            this.LblAralık.AutoSize = true;
            this.LblAralık.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAralık.Location = new System.Drawing.Point(715, 208);
            this.LblAralık.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAralık.Name = "LblAralık";
            this.LblAralık.Size = new System.Drawing.Size(29, 17);
            this.LblAralık.TabIndex = 26;
            this.LblAralık.Text = "1-6";
            // 
            // StudentFrequencySetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 938);
            this.Controls.Add(this.LblAralık);
            this.Controls.Add(this.TxtDogruSayisi);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.LblBilgilendirme);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.TxtSıklık);
            this.Controls.Add(this.LblikinciDogru);
            this.Controls.Add(this.LblilkDogru);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StudentFrequencySetting";
            this.Text = "StuudentFrequencySetting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentFrequencySetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblilkDogru;
        private System.Windows.Forms.Label LblikinciDogru;
        private System.Windows.Forms.TextBox TxtSıklık;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label LblBilgilendirme;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.TextBox TxtDogruSayisi;
        private System.Windows.Forms.Label LblAralık;
    }
}