
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
            ((System.ComponentModel.ISupportInitialize)(this.DtgSorumluBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgSorumluBilgileri
            // 
            this.DtgSorumluBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgSorumluBilgileri.Location = new System.Drawing.Point(12, 241);
            this.DtgSorumluBilgileri.Name = "DtgSorumluBilgileri";
            this.DtgSorumluBilgileri.RowHeadersWidth = 51;
            this.DtgSorumluBilgileri.RowTemplate.Height = 24;
            this.DtgSorumluBilgileri.Size = new System.Drawing.Size(1244, 459);
            this.DtgSorumluBilgileri.TabIndex = 0;
            // 
            // BtnSinavSorumluSil
            // 
            this.BtnSinavSorumluSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSinavSorumluSil.Location = new System.Drawing.Point(13, 187);
            this.BtnSinavSorumluSil.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSinavSorumluSil.Name = "BtnSinavSorumluSil";
            this.BtnSinavSorumluSil.Size = new System.Drawing.Size(327, 47);
            this.BtnSinavSorumluSil.TabIndex = 2;
            this.BtnSinavSorumluSil.Text = "Seçili Sorumluyu Sil";
            this.BtnSinavSorumluSil.UseVisualStyleBackColor = true;
            this.BtnSinavSorumluSil.Click += new System.EventHandler(this.BtnSinavSorumluSil_Click);
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGeri.Location = new System.Drawing.Point(471, 187);
            this.BtnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(327, 47);
            this.BtnGeri.TabIndex = 3;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // BtnBilgiGetir
            // 
            this.BtnBilgiGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBilgiGetir.Location = new System.Drawing.Point(929, 187);
            this.BtnBilgiGetir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBilgiGetir.Name = "BtnBilgiGetir";
            this.BtnBilgiGetir.Size = new System.Drawing.Size(327, 47);
            this.BtnBilgiGetir.TabIndex = 4;
            this.BtnBilgiGetir.Text = "Bilgileri Getir";
            this.BtnBilgiGetir.UseVisualStyleBackColor = true;
            this.BtnBilgiGetir.Click += new System.EventHandler(this.BtnBilgiGetir_Click);
            // 
            // AdminGetExaminers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 707);
            this.Controls.Add(this.BtnBilgiGetir);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.BtnSinavSorumluSil);
            this.Controls.Add(this.DtgSorumluBilgileri);
            this.Name = "AdminGetExaminers";
            this.Text = "AdminGetExaminers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DtgSorumluBilgileri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgSorumluBilgileri;
        private System.Windows.Forms.Button BtnSinavSorumluSil;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Button BtnBilgiGetir;
    }
}