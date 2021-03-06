
namespace SoftwareConstructorProject
{
    partial class StudentLogin
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
            this.LblOgrenciGirisSayfasi = new System.Windows.Forms.Label();
            this.LblOgrenciUyari = new System.Windows.Forms.Label();
            this.LblOgrenciMail = new System.Windows.Forms.Label();
            this.LblOgrenciSifre = new System.Windows.Forms.Label();
            this.TxtOgrenciMail = new System.Windows.Forms.TextBox();
            this.TxtOgrenciSifre = new System.Windows.Forms.TextBox();
            this.BtnOgrenciGiris = new System.Windows.Forms.Button();
            this.BtnOgrenciSİfreUnuttum = new System.Windows.Forms.Button();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblOgrenciGirisSayfasi
            // 
            this.LblOgrenciGirisSayfasi.AutoSize = true;
            this.LblOgrenciGirisSayfasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOgrenciGirisSayfasi.Location = new System.Drawing.Point(188, 32);
            this.LblOgrenciGirisSayfasi.Name = "LblOgrenciGirisSayfasi";
            this.LblOgrenciGirisSayfasi.Size = new System.Drawing.Size(388, 24);
            this.LblOgrenciGirisSayfasi.TabIndex = 0;
            this.LblOgrenciGirisSayfasi.Text = "ÖĞRENCİ GİRİŞ SAYFASINA HOŞGELDİNİZ";
            // 
            // LblOgrenciUyari
            // 
            this.LblOgrenciUyari.AutoSize = true;
            this.LblOgrenciUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOgrenciUyari.Location = new System.Drawing.Point(170, 99);
            this.LblOgrenciUyari.Name = "LblOgrenciUyari";
            this.LblOgrenciUyari.Size = new System.Drawing.Size(432, 24);
            this.LblOgrenciUyari.TabIndex = 5;
            this.LblOgrenciUyari.Text = "Lütfen Aşağıdaki Bilgileri Eksiksiz Doldurunuz";
            // 
            // LblOgrenciMail
            // 
            this.LblOgrenciMail.AutoSize = true;
            this.LblOgrenciMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOgrenciMail.Location = new System.Drawing.Point(99, 183);
            this.LblOgrenciMail.Name = "LblOgrenciMail";
            this.LblOgrenciMail.Size = new System.Drawing.Size(108, 24);
            this.LblOgrenciMail.TabIndex = 6;
            this.LblOgrenciMail.Text = "Mail Adresi:";
            // 
            // LblOgrenciSifre
            // 
            this.LblOgrenciSifre.AutoSize = true;
            this.LblOgrenciSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOgrenciSifre.Location = new System.Drawing.Point(99, 246);
            this.LblOgrenciSifre.Name = "LblOgrenciSifre";
            this.LblOgrenciSifre.Size = new System.Drawing.Size(52, 24);
            this.LblOgrenciSifre.TabIndex = 7;
            this.LblOgrenciSifre.Text = "Şifre:";
            // 
            // TxtOgrenciMail
            // 
            this.TxtOgrenciMail.Location = new System.Drawing.Point(213, 188);
            this.TxtOgrenciMail.Name = "TxtOgrenciMail";
            this.TxtOgrenciMail.Size = new System.Drawing.Size(200, 20);
            this.TxtOgrenciMail.TabIndex = 8;
            // 
            // TxtOgrenciSifre
            // 
            this.TxtOgrenciSifre.Location = new System.Drawing.Point(213, 246);
            this.TxtOgrenciSifre.MaxLength = 16;
            this.TxtOgrenciSifre.Name = "TxtOgrenciSifre";
            this.TxtOgrenciSifre.PasswordChar = '*';
            this.TxtOgrenciSifre.Size = new System.Drawing.Size(200, 20);
            this.TxtOgrenciSifre.TabIndex = 9;
            // 
            // BtnOgrenciGiris
            // 
            this.BtnOgrenciGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnOgrenciGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOgrenciGiris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnOgrenciGiris.Location = new System.Drawing.Point(213, 290);
            this.BtnOgrenciGiris.Name = "BtnOgrenciGiris";
            this.BtnOgrenciGiris.Size = new System.Drawing.Size(75, 60);
            this.BtnOgrenciGiris.TabIndex = 10;
            this.BtnOgrenciGiris.Text = "Giriş Yap";
            this.BtnOgrenciGiris.UseVisualStyleBackColor = false;
            this.BtnOgrenciGiris.Click += new System.EventHandler(this.BtnOgrenciGiris_Click);
            // 
            // BtnOgrenciSİfreUnuttum
            // 
            this.BtnOgrenciSİfreUnuttum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnOgrenciSİfreUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOgrenciSİfreUnuttum.Location = new System.Drawing.Point(313, 290);
            this.BtnOgrenciSİfreUnuttum.Name = "BtnOgrenciSİfreUnuttum";
            this.BtnOgrenciSİfreUnuttum.Size = new System.Drawing.Size(100, 60);
            this.BtnOgrenciSİfreUnuttum.TabIndex = 11;
            this.BtnOgrenciSİfreUnuttum.Text = "Şifremi Unuttum";
            this.BtnOgrenciSİfreUnuttum.UseVisualStyleBackColor = false;
            this.BtnOgrenciSİfreUnuttum.Click += new System.EventHandler(this.BtnOgrenciSİfreUnuttum_Click);
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGeri.Location = new System.Drawing.Point(251, 356);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(100, 60);
            this.BtnGeri.TabIndex = 12;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // StudentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.BtnOgrenciSİfreUnuttum);
            this.Controls.Add(this.BtnOgrenciGiris);
            this.Controls.Add(this.TxtOgrenciSifre);
            this.Controls.Add(this.TxtOgrenciMail);
            this.Controls.Add(this.LblOgrenciSifre);
            this.Controls.Add(this.LblOgrenciMail);
            this.Controls.Add(this.LblOgrenciUyari);
            this.Controls.Add(this.LblOgrenciGirisSayfasi);
            this.Name = "StudentLogin";
            this.Text = "Öğrenci Giriş Sayfası";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblOgrenciGirisSayfasi;
        private System.Windows.Forms.Label LblOgrenciUyari;
        private System.Windows.Forms.Label LblOgrenciMail;
        private System.Windows.Forms.Label LblOgrenciSifre;
        private System.Windows.Forms.TextBox TxtOgrenciSifre;
        private System.Windows.Forms.Button BtnOgrenciGiris;
        private System.Windows.Forms.Button BtnOgrenciSİfreUnuttum;
        private System.Windows.Forms.Button BtnGeri;
        public System.Windows.Forms.TextBox TxtOgrenciMail;
    }
}