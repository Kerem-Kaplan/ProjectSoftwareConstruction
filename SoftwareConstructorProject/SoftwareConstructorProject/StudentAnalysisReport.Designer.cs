
namespace SoftwareConstructorProject
{
    partial class StudentAnalysisReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentAnalysisReport));
            this.BtnBasariYazdır = new System.Windows.Forms.Button();
            this.BtnBasariGoruntule = new System.Windows.Forms.Button();
            this.DgwOgrenciBasari = new System.Windows.Forms.DataGridView();
            this.pdYazici = new System.Drawing.Printing.PrintDocument();
            this.ppdDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.LblBilgilendirme = new System.Windows.Forms.Label();
            this.BtnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgwOgrenciBasari)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBasariYazdır
            // 
            this.BtnBasariYazdır.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBasariYazdır.Location = new System.Drawing.Point(92, 102);
            this.BtnBasariYazdır.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBasariYazdır.Name = "BtnBasariYazdır";
            this.BtnBasariYazdır.Size = new System.Drawing.Size(84, 67);
            this.BtnBasariYazdır.TabIndex = 0;
            this.BtnBasariYazdır.Text = "Yazdır";
            this.BtnBasariYazdır.UseVisualStyleBackColor = true;
            this.BtnBasariYazdır.Click += new System.EventHandler(this.BtnBasariYazdır_Click);
            // 
            // BtnBasariGoruntule
            // 
            this.BtnBasariGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBasariGoruntule.Location = new System.Drawing.Point(343, 102);
            this.BtnBasariGoruntule.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBasariGoruntule.Name = "BtnBasariGoruntule";
            this.BtnBasariGoruntule.Size = new System.Drawing.Size(112, 67);
            this.BtnBasariGoruntule.TabIndex = 1;
            this.BtnBasariGoruntule.Text = "Başarı Görüntüle";
            this.BtnBasariGoruntule.UseVisualStyleBackColor = true;
            this.BtnBasariGoruntule.Click += new System.EventHandler(this.BtnBasariGoruntule_Click);
            // 
            // DgwOgrenciBasari
            // 
            this.DgwOgrenciBasari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgwOgrenciBasari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwOgrenciBasari.Location = new System.Drawing.Point(92, 173);
            this.DgwOgrenciBasari.Margin = new System.Windows.Forms.Padding(2);
            this.DgwOgrenciBasari.Name = "DgwOgrenciBasari";
            this.DgwOgrenciBasari.RowTemplate.Height = 24;
            this.DgwOgrenciBasari.Size = new System.Drawing.Size(363, 251);
            this.DgwOgrenciBasari.TabIndex = 2;
            // 
            // pdYazici
            // 
            this.pdYazici.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.pdYazici_BeginPrint);
            this.pdYazici.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdYazici_PrintPage);
            // 
            // ppdDialog
            // 
            this.ppdDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdDialog.Document = this.pdYazici;
            this.ppdDialog.Enabled = true;
            this.ppdDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdDialog.Icon")));
            this.ppdDialog.Name = "ppdDialog";
            this.ppdDialog.Visible = false;
            // 
            // LblBilgilendirme
            // 
            this.LblBilgilendirme.AutoSize = true;
            this.LblBilgilendirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBilgilendirme.Location = new System.Drawing.Point(115, 48);
            this.LblBilgilendirme.Name = "LblBilgilendirme";
            this.LblBilgilendirme.Size = new System.Drawing.Size(340, 24);
            this.LblBilgilendirme.TabIndex = 3;
            this.LblBilgilendirme.Text = "YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİNİZ";
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGeri.Location = new System.Drawing.Point(225, 102);
            this.BtnGeri.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(84, 67);
            this.BtnGeri.TabIndex = 4;
            this.BtnGeri.Text = "Geri";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // StudentAnalysisReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.LblBilgilendirme);
            this.Controls.Add(this.DgwOgrenciBasari);
            this.Controls.Add(this.BtnBasariGoruntule);
            this.Controls.Add(this.BtnBasariYazdır);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentAnalysisReport";
            this.Text = "Öğrenci Rapor Sayfası";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DgwOgrenciBasari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBasariYazdır;
        private System.Windows.Forms.Button BtnBasariGoruntule;
        private System.Windows.Forms.DataGridView DgwOgrenciBasari;
        private System.Drawing.Printing.PrintDocument pdYazici;
        private System.Windows.Forms.PrintPreviewDialog ppdDialog;
        private System.Windows.Forms.Label LblBilgilendirme;
        private System.Windows.Forms.Button BtnGeri;
    }
}