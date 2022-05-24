
namespace SoftwareConstructorProject
{
    partial class AdminGetQuestions
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
            this.BtnGeri = new System.Windows.Forms.Button();
            this.BtnSoruSil = new System.Windows.Forms.Button();
            this.BtnSoruBilgiGetir = new System.Windows.Forms.Button();
            this.DtgSorular = new System.Windows.Forms.DataGridView();
            this.LblDikkat = new System.Windows.Forms.Label();
            this.LblBilgilendirme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgSorular)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGeri.Location = new System.Drawing.Point(660, 196);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(245, 38);
            this.BtnGeri.TabIndex = 3;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // BtnSoruSil
            // 
            this.BtnSoruSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSoruSil.Location = new System.Drawing.Point(8, 196);
            this.BtnSoruSil.Name = "BtnSoruSil";
            this.BtnSoruSil.Size = new System.Drawing.Size(326, 38);
            this.BtnSoruSil.TabIndex = 4;
            this.BtnSoruSil.Text = "Seçili Soruyu Sil";
            this.BtnSoruSil.UseVisualStyleBackColor = true;
            this.BtnSoruSil.Click += new System.EventHandler(this.BtnSoruSil_Click);
            // 
            // BtnSoruBilgiGetir
            // 
            this.BtnSoruBilgiGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSoruBilgiGetir.Location = new System.Drawing.Point(1166, 196);
            this.BtnSoruBilgiGetir.Name = "BtnSoruBilgiGetir";
            this.BtnSoruBilgiGetir.Size = new System.Drawing.Size(245, 38);
            this.BtnSoruBilgiGetir.TabIndex = 5;
            this.BtnSoruBilgiGetir.Text = "Soruları Getir";
            this.BtnSoruBilgiGetir.UseVisualStyleBackColor = true;
            this.BtnSoruBilgiGetir.Click += new System.EventHandler(this.BtnSoruBilgiGetir_Click);
            // 
            // DtgSorular
            // 
            this.DtgSorular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgSorular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgSorular.Location = new System.Drawing.Point(11, 239);
            this.DtgSorular.Margin = new System.Windows.Forms.Padding(2);
            this.DtgSorular.Name = "DtgSorular";
            this.DtgSorular.RowHeadersWidth = 51;
            this.DtgSorular.RowTemplate.Height = 24;
            this.DtgSorular.Size = new System.Drawing.Size(1405, 444);
            this.DtgSorular.TabIndex = 6;
            // 
            // LblDikkat
            // 
            this.LblDikkat.AutoSize = true;
            this.LblDikkat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDikkat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblDikkat.Location = new System.Drawing.Point(222, 75);
            this.LblDikkat.Name = "LblDikkat";
            this.LblDikkat.Size = new System.Drawing.Size(81, 24);
            this.LblDikkat.TabIndex = 7;
            this.LblDikkat.Text = "DİKKAT:";
            // 
            // LblBilgilendirme
            // 
            this.LblBilgilendirme.AutoSize = true;
            this.LblBilgilendirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBilgilendirme.Location = new System.Drawing.Point(323, 38);
            this.LblBilgilendirme.Name = "LblBilgilendirme";
            this.LblBilgilendirme.Size = new System.Drawing.Size(499, 96);
            this.LblBilgilendirme.TabIndex = 8;
            this.LblBilgilendirme.Text = "Soruları görüntülemek için \'Soruları Getir\' butouna basınız.\r\n\r\nSoru silmek için " +
    "bilgileri getirdikten sonra soruyu seçiniz ve\r\nardından \'Seçili Soruyu Sil\' buto" +
    "nuna basınız.";
            // 
            // AdminGetQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1424, 694);
            this.Controls.Add(this.LblBilgilendirme);
            this.Controls.Add(this.LblDikkat);
            this.Controls.Add(this.DtgSorular);
            this.Controls.Add(this.BtnSoruBilgiGetir);
            this.Controls.Add(this.BtnSoruSil);
            this.Controls.Add(this.BtnGeri);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminGetQuestions";
            this.Text = "Sorular Sayfası";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DtgSorular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Button BtnSoruSil;
        private System.Windows.Forms.Button BtnSoruBilgiGetir;
        private System.Windows.Forms.DataGridView DtgSorular;
        private System.Windows.Forms.Label LblDikkat;
        private System.Windows.Forms.Label LblBilgilendirme;
    }
}