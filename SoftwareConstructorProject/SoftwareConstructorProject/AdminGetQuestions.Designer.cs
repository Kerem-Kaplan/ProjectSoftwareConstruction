
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
            ((System.ComponentModel.ISupportInitialize)(this.DtgSorular)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGeri.Location = new System.Drawing.Point(882, 140);
            this.BtnGeri.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(327, 47);
            this.BtnGeri.TabIndex = 3;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // BtnSoruSil
            // 
            this.BtnSoruSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSoruSil.Location = new System.Drawing.Point(13, 140);
            this.BtnSoruSil.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSoruSil.Name = "BtnSoruSil";
            this.BtnSoruSil.Size = new System.Drawing.Size(435, 47);
            this.BtnSoruSil.TabIndex = 4;
            this.BtnSoruSil.Text = "Seçili Soruyu Sil";
            this.BtnSoruSil.UseVisualStyleBackColor = true;
            this.BtnSoruSil.Click += new System.EventHandler(this.BtnSoruSil_Click);
            // 
            // BtnSoruBilgiGetir
            // 
            this.BtnSoruBilgiGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSoruBilgiGetir.Location = new System.Drawing.Point(1558, 140);
            this.BtnSoruBilgiGetir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSoruBilgiGetir.Name = "BtnSoruBilgiGetir";
            this.BtnSoruBilgiGetir.Size = new System.Drawing.Size(327, 47);
            this.BtnSoruBilgiGetir.TabIndex = 5;
            this.BtnSoruBilgiGetir.Text = "Bilgileri Getir";
            this.BtnSoruBilgiGetir.UseVisualStyleBackColor = true;
            this.BtnSoruBilgiGetir.Click += new System.EventHandler(this.BtnSoruBilgiGetir_Click);
            // 
            // DtgSorular
            // 
            this.DtgSorular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgSorular.Location = new System.Drawing.Point(13, 194);
            this.DtgSorular.Name = "DtgSorular";
            this.DtgSorular.RowHeadersWidth = 51;
            this.DtgSorular.RowTemplate.Height = 24;
            this.DtgSorular.Size = new System.Drawing.Size(1873, 547);
            this.DtgSorular.TabIndex = 6;
            // 
            // AdminGetQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 745);
            this.Controls.Add(this.DtgSorular);
            this.Controls.Add(this.BtnSoruBilgiGetir);
            this.Controls.Add(this.BtnSoruSil);
            this.Controls.Add(this.BtnGeri);
            this.Name = "AdminGetQuestions";
            this.Text = "AdminGetQuestions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DtgSorular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Button BtnSoruSil;
        private System.Windows.Forms.Button BtnSoruBilgiGetir;
        private System.Windows.Forms.DataGridView DtgSorular;
    }
}