
namespace SoftwareConstructorProject
{
    partial class AdminGetStudents
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
            this.DtgOgrenciBilgileri = new System.Windows.Forms.DataGridView();
            this.BtnOgrenciSil = new System.Windows.Forms.Button();
            this.BtnKayıtGetir = new System.Windows.Forms.Button();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.LblDikkat = new System.Windows.Forms.Label();
            this.LblBilgilendirme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgOgrenciBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgOgrenciBilgileri
            // 
            this.DtgOgrenciBilgileri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgOgrenciBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgOgrenciBilgileri.Location = new System.Drawing.Point(12, 199);
            this.DtgOgrenciBilgileri.Name = "DtgOgrenciBilgileri";
            this.DtgOgrenciBilgileri.Size = new System.Drawing.Size(1007, 334);
            this.DtgOgrenciBilgileri.TabIndex = 0;
            // 
            // BtnOgrenciSil
            // 
            this.BtnOgrenciSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOgrenciSil.Location = new System.Drawing.Point(12, 155);
            this.BtnOgrenciSil.Name = "BtnOgrenciSil";
            this.BtnOgrenciSil.Size = new System.Drawing.Size(245, 38);
            this.BtnOgrenciSil.TabIndex = 1;
            this.BtnOgrenciSil.Text = "Seçili Öğrenciyi Sil";
            this.BtnOgrenciSil.UseVisualStyleBackColor = true;
            this.BtnOgrenciSil.Click += new System.EventHandler(this.BtnOgrenciSil_Click);
            // 
            // BtnKayıtGetir
            // 
            this.BtnKayıtGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKayıtGetir.Location = new System.Drawing.Point(774, 155);
            this.BtnKayıtGetir.Name = "BtnKayıtGetir";
            this.BtnKayıtGetir.Size = new System.Drawing.Size(245, 38);
            this.BtnKayıtGetir.TabIndex = 2;
            this.BtnKayıtGetir.Text = "Bilgileri Getir";
            this.BtnKayıtGetir.UseVisualStyleBackColor = true;
            this.BtnKayıtGetir.Click += new System.EventHandler(this.BtnKayıtGetir_Click);
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGeri.Location = new System.Drawing.Point(392, 155);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(245, 38);
            this.BtnGeri.TabIndex = 3;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // LblDikkat
            // 
            this.LblDikkat.AutoSize = true;
            this.LblDikkat.BackColor = System.Drawing.Color.Black;
            this.LblDikkat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDikkat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblDikkat.Location = new System.Drawing.Point(104, 49);
            this.LblDikkat.Name = "LblDikkat";
            this.LblDikkat.Size = new System.Drawing.Size(81, 24);
            this.LblDikkat.TabIndex = 4;
            this.LblDikkat.Text = "DİKKAT:";
            // 
            // LblBilgilendirme
            // 
            this.LblBilgilendirme.AutoSize = true;
            this.LblBilgilendirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBilgilendirme.Location = new System.Drawing.Point(220, 9);
            this.LblBilgilendirme.Name = "LblBilgilendirme";
            this.LblBilgilendirme.Size = new System.Drawing.Size(557, 96);
            this.LblBilgilendirme.TabIndex = 5;
            this.LblBilgilendirme.Text = "Öğrenci bilgileri için \'Bilgileri Getir\' butonuna basınız.\r\n\r\nÖğrenci silmek için" +
    " bilgileri getirdikten sonra öğrenciyi seçiniz ve  \r\n\'Seçili Öğrenciyi Sil\' buto" +
    "nuna basınız.";
            // 
            // AdminGetStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1031, 570);
            this.Controls.Add(this.LblBilgilendirme);
            this.Controls.Add(this.LblDikkat);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.BtnKayıtGetir);
            this.Controls.Add(this.BtnOgrenciSil);
            this.Controls.Add(this.DtgOgrenciBilgileri);
            this.Name = "AdminGetStudents";
            this.Text = "Öğrenci Bilgileri Sayfası";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DtgOgrenciBilgileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgOgrenciBilgileri;
        private System.Windows.Forms.Button BtnOgrenciSil;
        private System.Windows.Forms.Button BtnKayıtGetir;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Label LblDikkat;
        private System.Windows.Forms.Label LblBilgilendirme;
    }
}