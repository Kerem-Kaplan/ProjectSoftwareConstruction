
namespace SoftwareConstructorProject
{
    partial class HomePage
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
            this.LblHosgeldiniz = new System.Windows.Forms.Label();
            this.BtnAdminGiris = new System.Windows.Forms.Button();
            this.BtnSinavSorumluGiris = new System.Windows.Forms.Button();
            this.BtnOgrenciGiris = new System.Windows.Forms.Button();
            this.LblGirisSecenek = new System.Windows.Forms.Label();
            this.LblKayıtSecenek = new System.Windows.Forms.Label();
            this.BtnOgrenciKayıt = new System.Windows.Forms.Button();
            this.BtnSinavSorumlusuKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblHosgeldiniz
            // 
            this.LblHosgeldiniz.AutoSize = true;
            this.LblHosgeldiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHosgeldiniz.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LblHosgeldiniz.Location = new System.Drawing.Point(225, 24);
            this.LblHosgeldiniz.Name = "LblHosgeldiniz";
            this.LblHosgeldiniz.Size = new System.Drawing.Size(338, 25);
            this.LblHosgeldiniz.TabIndex = 0;
            this.LblHosgeldiniz.Text = "SINAV SİSTEMİNE HOŞGELDİNİZ";
            // 
            // BtnAdminGiris
            // 
            this.BtnAdminGiris.BackColor = System.Drawing.Color.Sienna;
            this.BtnAdminGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdminGiris.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAdminGiris.Location = new System.Drawing.Point(109, 187);
            this.BtnAdminGiris.Name = "BtnAdminGiris";
            this.BtnAdminGiris.Size = new System.Drawing.Size(146, 49);
            this.BtnAdminGiris.TabIndex = 1;
            this.BtnAdminGiris.Text = "Admin Girişi";
            this.BtnAdminGiris.UseVisualStyleBackColor = false;
            this.BtnAdminGiris.Click += new System.EventHandler(this.BtnAdminGiris_Click);
            // 
            // BtnSinavSorumluGiris
            // 
            this.BtnSinavSorumluGiris.BackColor = System.Drawing.Color.Coral;
            this.BtnSinavSorumluGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSinavSorumluGiris.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSinavSorumluGiris.Location = new System.Drawing.Point(109, 274);
            this.BtnSinavSorumluGiris.Name = "BtnSinavSorumluGiris";
            this.BtnSinavSorumluGiris.Size = new System.Drawing.Size(146, 80);
            this.BtnSinavSorumluGiris.TabIndex = 2;
            this.BtnSinavSorumluGiris.Text = "Sınav Sorumlusu Girişi\r\n";
            this.BtnSinavSorumluGiris.UseVisualStyleBackColor = false;
            this.BtnSinavSorumluGiris.Click += new System.EventHandler(this.BtnSinavSorumluGiris_Click);
            // 
            // BtnOgrenciGiris
            // 
            this.BtnOgrenciGiris.BackColor = System.Drawing.Color.Peru;
            this.BtnOgrenciGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOgrenciGiris.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnOgrenciGiris.Location = new System.Drawing.Point(109, 391);
            this.BtnOgrenciGiris.Name = "BtnOgrenciGiris";
            this.BtnOgrenciGiris.Size = new System.Drawing.Size(146, 56);
            this.BtnOgrenciGiris.TabIndex = 3;
            this.BtnOgrenciGiris.Text = "Öğrenci Girişi";
            this.BtnOgrenciGiris.UseVisualStyleBackColor = false;
            this.BtnOgrenciGiris.Click += new System.EventHandler(this.BtnOgrenciGiris_Click);
            // 
            // LblGirisSecenek
            // 
            this.LblGirisSecenek.AutoSize = true;
            this.LblGirisSecenek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGirisSecenek.Location = new System.Drawing.Point(55, 121);
            this.LblGirisSecenek.Name = "LblGirisSecenek";
            this.LblGirisSecenek.Size = new System.Drawing.Size(288, 48);
            this.LblGirisSecenek.TabIndex = 4;
            this.LblGirisSecenek.Text = "Eğer hesabınız varsa yapmak \r\nistediğiniz girişi seçiniz";
            // 
            // LblKayıtSecenek
            // 
            this.LblKayıtSecenek.AutoSize = true;
            this.LblKayıtSecenek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKayıtSecenek.Location = new System.Drawing.Point(524, 121);
            this.LblKayıtSecenek.Name = "LblKayıtSecenek";
            this.LblKayıtSecenek.Size = new System.Drawing.Size(285, 48);
            this.LblKayıtSecenek.TabIndex = 5;
            this.LblKayıtSecenek.Text = "Eğer hesabınız yoksa kayıt \r\nolmak istediğiniz girişi seçiniz\r\n";
            // 
            // BtnOgrenciKayıt
            // 
            this.BtnOgrenciKayıt.BackColor = System.Drawing.Color.Peru;
            this.BtnOgrenciKayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOgrenciKayıt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnOgrenciKayıt.Location = new System.Drawing.Point(580, 334);
            this.BtnOgrenciKayıt.Name = "BtnOgrenciKayıt";
            this.BtnOgrenciKayıt.Size = new System.Drawing.Size(146, 56);
            this.BtnOgrenciKayıt.TabIndex = 8;
            this.BtnOgrenciKayıt.Text = "Öğrenci Kayıt\r\n";
            this.BtnOgrenciKayıt.UseVisualStyleBackColor = false;
            this.BtnOgrenciKayıt.Click += new System.EventHandler(this.BtnOgrenciKayıt_Click);
            // 
            // BtnSinavSorumlusuKayit
            // 
            this.BtnSinavSorumlusuKayit.BackColor = System.Drawing.Color.Coral;
            this.BtnSinavSorumlusuKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSinavSorumlusuKayit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSinavSorumlusuKayit.Location = new System.Drawing.Point(580, 217);
            this.BtnSinavSorumlusuKayit.Name = "BtnSinavSorumlusuKayit";
            this.BtnSinavSorumlusuKayit.Size = new System.Drawing.Size(146, 80);
            this.BtnSinavSorumlusuKayit.TabIndex = 7;
            this.BtnSinavSorumlusuKayit.Text = "Sınav Sorumlusu Kayıt\r\n\r\n";
            this.BtnSinavSorumlusuKayit.UseVisualStyleBackColor = false;
            this.BtnSinavSorumlusuKayit.Click += new System.EventHandler(this.BtnSinavSorumlusuKayit_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(858, 537);
            this.Controls.Add(this.BtnOgrenciKayıt);
            this.Controls.Add(this.BtnSinavSorumlusuKayit);
            this.Controls.Add(this.LblKayıtSecenek);
            this.Controls.Add(this.LblGirisSecenek);
            this.Controls.Add(this.BtnOgrenciGiris);
            this.Controls.Add(this.BtnSinavSorumluGiris);
            this.Controls.Add(this.BtnAdminGiris);
            this.Controls.Add(this.LblHosgeldiniz);
            this.Name = "HomePage";
            this.Text = "AnaSayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHosgeldiniz;
        private System.Windows.Forms.Button BtnAdminGiris;
        private System.Windows.Forms.Button BtnSinavSorumluGiris;
        private System.Windows.Forms.Button BtnOgrenciGiris;
        private System.Windows.Forms.Label LblGirisSecenek;
        private System.Windows.Forms.Label LblKayıtSecenek;
        private System.Windows.Forms.Button BtnOgrenciKayıt;
        private System.Windows.Forms.Button BtnSinavSorumlusuKayit;
    }
}

