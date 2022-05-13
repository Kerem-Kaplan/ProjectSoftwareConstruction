
namespace SoftwareConstructorProject
{
    partial class AdminGetExaminers
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
            this.DtgSorumluBilgileri = new System.Windows.Forms.DataGridView();
            this.BtnSinavSorumluSil = new System.Windows.Forms.Button();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.BtnBilgiGetir = new System.Windows.Forms.Button();
            this.LblBilgilendirme = new System.Windows.Forms.Label();
            this.LblDikkat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgSorumluBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgSorumluBilgileri
            // 
            this.DtgSorumluBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgSorumluBilgileri.Location = new System.Drawing.Point(9, 196);
            this.DtgSorumluBilgileri.Margin = new System.Windows.Forms.Padding(2);
            this.DtgSorumluBilgileri.Name = "DtgSorumluBilgileri";
            this.DtgSorumluBilgileri.RowHeadersWidth = 51;
            this.DtgSorumluBilgileri.RowTemplate.Height = 24;
            this.DtgSorumluBilgileri.Size = new System.Drawing.Size(933, 373);
            this.DtgSorumluBilgileri.TabIndex = 0;
            // 
            // BtnSinavSorumluSil
            // 
            this.BtnSinavSorumluSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSinavSorumluSil.Location = new System.Drawing.Point(10, 152);
            this.BtnSinavSorumluSil.Name = "BtnSinavSorumluSil";
            this.BtnSinavSorumluSil.Size = new System.Drawing.Size(245, 38);
            this.BtnSinavSorumluSil.TabIndex = 2;
            this.BtnSinavSorumluSil.Text = "Seçili Sorumluyu Sil";
            this.BtnSinavSorumluSil.UseVisualStyleBackColor = true;
            this.BtnSinavSorumluSil.Click += new System.EventHandler(this.BtnSinavSorumluSil_Click);
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGeri.Location = new System.Drawing.Point(353, 152);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(245, 38);
            this.BtnGeri.TabIndex = 3;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // BtnBilgiGetir
            // 
            this.BtnBilgiGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBilgiGetir.Location = new System.Drawing.Point(697, 152);
            this.BtnBilgiGetir.Name = "BtnBilgiGetir";
            this.BtnBilgiGetir.Size = new System.Drawing.Size(245, 38);
            this.BtnBilgiGetir.TabIndex = 4;
            this.BtnBilgiGetir.Text = "Bilgileri Getir";
            this.BtnBilgiGetir.UseVisualStyleBackColor = true;
            this.BtnBilgiGetir.Click += new System.EventHandler(this.BtnBilgiGetir_Click);
            // 
            // LblBilgilendirme
            // 
            this.LblBilgilendirme.AutoSize = true;
            this.LblBilgilendirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBilgilendirme.Location = new System.Drawing.Point(162, 9);
            this.LblBilgilendirme.Name = "LblBilgilendirme";
            this.LblBilgilendirme.Size = new System.Drawing.Size(622, 96);
            this.LblBilgilendirme.TabIndex = 5;
            this.LblBilgilendirme.Text = "Sorumlu bilgilerini görmek için \'Bilgileri Getir\' butonuna basınız.\r\n\r\nSorumlu si" +
    "lmek istiyorsanız bilgileri getirdikten sonra sorumluyu seçiniz ve\r\nardından \'Se" +
    "çili Sorumluyu Sil\' butonuna basınız.";
            // 
            // LblDikkat
            // 
            this.LblDikkat.AutoSize = true;
            this.LblDikkat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDikkat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblDikkat.Location = new System.Drawing.Point(59, 47);
            this.LblDikkat.Name = "LblDikkat";
            this.LblDikkat.Size = new System.Drawing.Size(81, 24);
            this.LblDikkat.TabIndex = 6;
            this.LblDikkat.Text = "DİKKAT:";
            // 
            // AdminGetExaminers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(951, 574);
            this.Controls.Add(this.LblDikkat);
            this.Controls.Add(this.LblBilgilendirme);
            this.Controls.Add(this.BtnBilgiGetir);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.BtnSinavSorumluSil);
            this.Controls.Add(this.DtgSorumluBilgileri);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminGetExaminers";
            this.Text = "Sorumlu Bilgileri Sayfası";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DtgSorumluBilgileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgSorumluBilgileri;
        private System.Windows.Forms.Button BtnSinavSorumluSil;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Button BtnBilgiGetir;
        private System.Windows.Forms.Label LblBilgilendirme;
        private System.Windows.Forms.Label LblDikkat;
    }
}