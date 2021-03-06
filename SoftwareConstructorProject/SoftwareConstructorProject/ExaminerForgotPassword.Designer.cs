
namespace SoftwareConstructorProject
{
    partial class ExaminerForgotPassword
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
            this.BtnSifreYenile = new System.Windows.Forms.Button();
            this.TxtSorumluSifreTekrar = new System.Windows.Forms.TextBox();
            this.TxtSorumluSifre = new System.Windows.Forms.TextBox();
            this.TxtSorumluMail = new System.Windows.Forms.TextBox();
            this.TxtSorumluGuvNo = new System.Windows.Forms.TextBox();
            this.LblOgrBilgiGir = new System.Windows.Forms.Label();
            this.LblSorumluGuvNo = new System.Windows.Forms.Label();
            this.LblSifreUnuttumSifreTekrar = new System.Windows.Forms.Label();
            this.LblSifreUnuttumSifre = new System.Windows.Forms.Label();
            this.LblSifreUnuttumMail = new System.Windows.Forms.Label();
            this.LblSinavSorumlusuSifreUnuttum = new System.Windows.Forms.Label();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSifreYenile
            // 
            this.BtnSifreYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSifreYenile.ForeColor = System.Drawing.Color.Black;
            this.BtnSifreYenile.Location = new System.Drawing.Point(250, 360);
            this.BtnSifreYenile.Name = "BtnSifreYenile";
            this.BtnSifreYenile.Size = new System.Drawing.Size(87, 60);
            this.BtnSifreYenile.TabIndex = 22;
            this.BtnSifreYenile.Text = "Şifreyi Yenile";
            this.BtnSifreYenile.UseVisualStyleBackColor = true;
            this.BtnSifreYenile.Click += new System.EventHandler(this.BtnSifreYenile_Click);
            // 
            // TxtSorumluSifreTekrar
            // 
            this.TxtSorumluSifreTekrar.Location = new System.Drawing.Point(250, 256);
            this.TxtSorumluSifreTekrar.Name = "TxtSorumluSifreTekrar";
            this.TxtSorumluSifreTekrar.PasswordChar = '*';
            this.TxtSorumluSifreTekrar.Size = new System.Drawing.Size(184, 20);
            this.TxtSorumluSifreTekrar.TabIndex = 21;
            // 
            // TxtSorumluSifre
            // 
            this.TxtSorumluSifre.Location = new System.Drawing.Point(250, 199);
            this.TxtSorumluSifre.Name = "TxtSorumluSifre";
            this.TxtSorumluSifre.PasswordChar = '*';
            this.TxtSorumluSifre.Size = new System.Drawing.Size(184, 20);
            this.TxtSorumluSifre.TabIndex = 20;
            // 
            // TxtSorumluMail
            // 
            this.TxtSorumluMail.Location = new System.Drawing.Point(250, 143);
            this.TxtSorumluMail.Name = "TxtSorumluMail";
            this.TxtSorumluMail.Size = new System.Drawing.Size(184, 20);
            this.TxtSorumluMail.TabIndex = 19;
            // 
            // TxtSorumluGuvNo
            // 
            this.TxtSorumluGuvNo.Location = new System.Drawing.Point(250, 321);
            this.TxtSorumluGuvNo.Name = "TxtSorumluGuvNo";
            this.TxtSorumluGuvNo.PasswordChar = '*';
            this.TxtSorumluGuvNo.Size = new System.Drawing.Size(184, 20);
            this.TxtSorumluGuvNo.TabIndex = 18;
            // 
            // LblOgrBilgiGir
            // 
            this.LblOgrBilgiGir.AutoSize = true;
            this.LblOgrBilgiGir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOgrBilgiGir.Location = new System.Drawing.Point(159, 77);
            this.LblOgrBilgiGir.Name = "LblOgrBilgiGir";
            this.LblOgrBilgiGir.Size = new System.Drawing.Size(475, 24);
            this.LblOgrBilgiGir.TabIndex = 17;
            this.LblOgrBilgiGir.Text = "Şifrenizi yenilemek için aşağıdaki bilgileri eksiksiz giriniz.";
            // 
            // LblSorumluGuvNo
            // 
            this.LblSorumluGuvNo.AutoSize = true;
            this.LblSorumluGuvNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSorumluGuvNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblSorumluGuvNo.Location = new System.Drawing.Point(71, 316);
            this.LblSorumluGuvNo.Name = "LblSorumluGuvNo";
            this.LblSorumluGuvNo.Size = new System.Drawing.Size(173, 24);
            this.LblSorumluGuvNo.TabIndex = 16;
            this.LblSorumluGuvNo.Text = "Güvenlik Numarası:";
            // 
            // LblSifreUnuttumSifreTekrar
            // 
            this.LblSifreUnuttumSifreTekrar.AutoSize = true;
            this.LblSifreUnuttumSifreTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSifreUnuttumSifreTekrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblSifreUnuttumSifreTekrar.Location = new System.Drawing.Point(71, 256);
            this.LblSifreUnuttumSifreTekrar.Name = "LblSifreUnuttumSifreTekrar";
            this.LblSifreUnuttumSifreTekrar.Size = new System.Drawing.Size(111, 24);
            this.LblSifreUnuttumSifreTekrar.TabIndex = 15;
            this.LblSifreUnuttumSifreTekrar.Text = "Şifre Tekrar:";
            // 
            // LblSifreUnuttumSifre
            // 
            this.LblSifreUnuttumSifre.AutoSize = true;
            this.LblSifreUnuttumSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSifreUnuttumSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblSifreUnuttumSifre.Location = new System.Drawing.Point(71, 199);
            this.LblSifreUnuttumSifre.Name = "LblSifreUnuttumSifre";
            this.LblSifreUnuttumSifre.Size = new System.Drawing.Size(52, 24);
            this.LblSifreUnuttumSifre.TabIndex = 14;
            this.LblSifreUnuttumSifre.Text = "Şifre:";
            // 
            // LblSifreUnuttumMail
            // 
            this.LblSifreUnuttumMail.AutoSize = true;
            this.LblSifreUnuttumMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSifreUnuttumMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblSifreUnuttumMail.Location = new System.Drawing.Point(71, 143);
            this.LblSifreUnuttumMail.Name = "LblSifreUnuttumMail";
            this.LblSifreUnuttumMail.Size = new System.Drawing.Size(108, 24);
            this.LblSifreUnuttumMail.TabIndex = 13;
            this.LblSifreUnuttumMail.Text = "Mail Adresi:";
            // 
            // LblSinavSorumlusuSifreUnuttum
            // 
            this.LblSinavSorumlusuSifreUnuttum.AutoSize = true;
            this.LblSinavSorumlusuSifreUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSinavSorumlusuSifreUnuttum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblSinavSorumlusuSifreUnuttum.Location = new System.Drawing.Point(76, 28);
            this.LblSinavSorumlusuSifreUnuttum.Name = "LblSinavSorumlusuSifreUnuttum";
            this.LblSinavSorumlusuSifreUnuttum.Size = new System.Drawing.Size(636, 24);
            this.LblSinavSorumlusuSifreUnuttum.TabIndex = 12;
            this.LblSinavSorumlusuSifreUnuttum.Text = "SINAV SORUMLUSU İÇİN ŞİFREMİ UNUTTUM EKRANINA HOŞGELDİNİZ\r\n";
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGeri.ForeColor = System.Drawing.Color.Black;
            this.BtnGeri.Location = new System.Drawing.Point(347, 360);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(87, 60);
            this.BtnGeri.TabIndex = 23;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // ExaminerForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(778, 457);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.BtnSifreYenile);
            this.Controls.Add(this.TxtSorumluSifreTekrar);
            this.Controls.Add(this.TxtSorumluSifre);
            this.Controls.Add(this.TxtSorumluMail);
            this.Controls.Add(this.TxtSorumluGuvNo);
            this.Controls.Add(this.LblOgrBilgiGir);
            this.Controls.Add(this.LblSorumluGuvNo);
            this.Controls.Add(this.LblSifreUnuttumSifreTekrar);
            this.Controls.Add(this.LblSifreUnuttumSifre);
            this.Controls.Add(this.LblSifreUnuttumMail);
            this.Controls.Add(this.LblSinavSorumlusuSifreUnuttum);
            this.Name = "ExaminerForgotPassword";
            this.Text = "Sorumlu Şifremi Unuttum Sayfası";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSifreYenile;
        private System.Windows.Forms.TextBox TxtSorumluSifreTekrar;
        private System.Windows.Forms.TextBox TxtSorumluSifre;
        private System.Windows.Forms.TextBox TxtSorumluMail;
        private System.Windows.Forms.TextBox TxtSorumluGuvNo;
        private System.Windows.Forms.Label LblOgrBilgiGir;
        private System.Windows.Forms.Label LblSorumluGuvNo;
        private System.Windows.Forms.Label LblSifreUnuttumSifreTekrar;
        private System.Windows.Forms.Label LblSifreUnuttumSifre;
        private System.Windows.Forms.Label LblSifreUnuttumMail;
        private System.Windows.Forms.Label LblSinavSorumlusuSifreUnuttum;
        private System.Windows.Forms.Button BtnGeri;
    }
}