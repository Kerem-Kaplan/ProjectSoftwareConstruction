
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
            ((System.ComponentModel.ISupportInitialize)(this.DtgOgrenciBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgOgrenciBilgileri
            // 
            this.DtgOgrenciBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgOgrenciBilgileri.Location = new System.Drawing.Point(12, 154);
            this.DtgOgrenciBilgileri.Name = "DtgOgrenciBilgileri";
            this.DtgOgrenciBilgileri.Size = new System.Drawing.Size(1007, 334);
            this.DtgOgrenciBilgileri.TabIndex = 0;
            // 
            // BtnOgrenciSil
            // 
            this.BtnOgrenciSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOgrenciSil.Location = new System.Drawing.Point(12, 110);
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
            this.BtnKayıtGetir.Location = new System.Drawing.Point(774, 110);
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
            this.BtnGeri.Location = new System.Drawing.Point(392, 110);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(245, 38);
            this.BtnGeri.TabIndex = 3;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // AdminGetStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 511);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.BtnKayıtGetir);
            this.Controls.Add(this.BtnOgrenciSil);
            this.Controls.Add(this.DtgOgrenciBilgileri);
            this.Name = "AdminGetStudents";
            this.Text = "AdminGetStudents";
            ((System.ComponentModel.ISupportInitialize)(this.DtgOgrenciBilgileri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgOgrenciBilgileri;
        private System.Windows.Forms.Button BtnOgrenciSil;
        private System.Windows.Forms.Button BtnKayıtGetir;
        private System.Windows.Forms.Button BtnGeri;
    }
}