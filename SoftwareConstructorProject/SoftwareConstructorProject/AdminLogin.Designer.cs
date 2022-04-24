
namespace SoftwareConstructorProject
{
    partial class AdminLogin
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
            this.components = new System.ComponentModel.Container();
            this.LblAdminGirisSayfasi = new System.Windows.Forms.Label();
            this.LblAdminMail = new System.Windows.Forms.Label();
            this.LblAdminSifre = new System.Windows.Forms.Label();
            this.LblAdminUyari = new System.Windows.Forms.Label();
            this.TxtAdminMail = new System.Windows.Forms.TextBox();
            this.TxtAdminSifre = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnAdminGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAdminGirisSayfasi
            // 
            this.LblAdminGirisSayfasi.AutoSize = true;
            this.LblAdminGirisSayfasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdminGirisSayfasi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblAdminGirisSayfasi.Location = new System.Drawing.Point(180, 30);
            this.LblAdminGirisSayfasi.Name = "LblAdminGirisSayfasi";
            this.LblAdminGirisSayfasi.Size = new System.Drawing.Size(362, 24);
            this.LblAdminGirisSayfasi.TabIndex = 0;
            this.LblAdminGirisSayfasi.Text = "ADMİN GİRİŞ SAYFASINA HOŞGELDİNİZ";
            // 
            // LblAdminMail
            // 
            this.LblAdminMail.AutoSize = true;
            this.LblAdminMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdminMail.ForeColor = System.Drawing.Color.Maroon;
            this.LblAdminMail.Location = new System.Drawing.Point(103, 188);
            this.LblAdminMail.Name = "LblAdminMail";
            this.LblAdminMail.Size = new System.Drawing.Size(108, 24);
            this.LblAdminMail.TabIndex = 1;
            this.LblAdminMail.Text = "Mail Adresi:";
            // 
            // LblAdminSifre
            // 
            this.LblAdminSifre.AutoSize = true;
            this.LblAdminSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdminSifre.ForeColor = System.Drawing.Color.Maroon;
            this.LblAdminSifre.Location = new System.Drawing.Point(103, 253);
            this.LblAdminSifre.Name = "LblAdminSifre";
            this.LblAdminSifre.Size = new System.Drawing.Size(52, 24);
            this.LblAdminSifre.TabIndex = 2;
            this.LblAdminSifre.Text = "Şifre:";
            // 
            // LblAdminUyari
            // 
            this.LblAdminUyari.AutoSize = true;
            this.LblAdminUyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAdminUyari.Location = new System.Drawing.Point(151, 111);
            this.LblAdminUyari.Name = "LblAdminUyari";
            this.LblAdminUyari.Size = new System.Drawing.Size(432, 24);
            this.LblAdminUyari.TabIndex = 3;
            this.LblAdminUyari.Text = "Lütfen Aşağıdaki Bilgileri Eksiksiz Doldurunuz";
            // 
            // TxtAdminMail
            // 
            this.TxtAdminMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdminMail.Location = new System.Drawing.Point(217, 191);
            this.TxtAdminMail.Name = "TxtAdminMail";
            this.TxtAdminMail.Size = new System.Drawing.Size(205, 21);
            this.TxtAdminMail.TabIndex = 4;
            this.TxtAdminMail.Tag = "";
            // 
            // TxtAdminSifre
            // 
            this.TxtAdminSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdminSifre.Location = new System.Drawing.Point(217, 253);
            this.TxtAdminSifre.Name = "TxtAdminSifre";
            this.TxtAdminSifre.Size = new System.Drawing.Size(205, 21);
            this.TxtAdminSifre.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BtnAdminGiris
            // 
            this.BtnAdminGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnAdminGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdminGiris.Location = new System.Drawing.Point(217, 303);
            this.BtnAdminGiris.Name = "BtnAdminGiris";
            this.BtnAdminGiris.Size = new System.Drawing.Size(205, 67);
            this.BtnAdminGiris.TabIndex = 7;
            this.BtnAdminGiris.Text = "Giriş Yap";
            this.BtnAdminGiris.UseVisualStyleBackColor = false;
            this.BtnAdminGiris.Click += new System.EventHandler(this.BtnAdminGiris_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAdminGiris);
            this.Controls.Add(this.TxtAdminSifre);
            this.Controls.Add(this.TxtAdminMail);
            this.Controls.Add(this.LblAdminUyari);
            this.Controls.Add(this.LblAdminSifre);
            this.Controls.Add(this.LblAdminMail);
            this.Controls.Add(this.LblAdminGirisSayfasi);
            this.Name = "AdminLogin";
            this.Text = "Admin Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAdminGirisSayfasi;
        private System.Windows.Forms.Label LblAdminMail;
        private System.Windows.Forms.Label LblAdminSifre;
        private System.Windows.Forms.Label LblAdminUyari;
        private System.Windows.Forms.TextBox TxtAdminMail;
        private System.Windows.Forms.TextBox TxtAdminSifre;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button BtnAdminGiris;
    }
}