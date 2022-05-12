
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
            ((System.ComponentModel.ISupportInitialize)(this.DgwOgrenciBasari)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBasariYazdır
            // 
            this.BtnBasariYazdır.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBasariYazdır.Location = new System.Drawing.Point(106, 76);
            this.BtnBasariYazdır.Name = "BtnBasariYazdır";
            this.BtnBasariYazdır.Size = new System.Drawing.Size(112, 60);
            this.BtnBasariYazdır.TabIndex = 0;
            this.BtnBasariYazdır.Text = "Yazdır";
            this.BtnBasariYazdır.UseVisualStyleBackColor = true;
            this.BtnBasariYazdır.Click += new System.EventHandler(this.BtnBasariYazdır_Click);
            // 
            // BtnBasariGoruntule
            // 
            this.BtnBasariGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBasariGoruntule.Location = new System.Drawing.Point(389, 76);
            this.BtnBasariGoruntule.Name = "BtnBasariGoruntule";
            this.BtnBasariGoruntule.Size = new System.Drawing.Size(201, 60);
            this.BtnBasariGoruntule.TabIndex = 1;
            this.BtnBasariGoruntule.Text = "Başarı Görüntüle";
            this.BtnBasariGoruntule.UseVisualStyleBackColor = true;
            this.BtnBasariGoruntule.Click += new System.EventHandler(this.BtnBasariGoruntule_Click);
            // 
            // DgwOgrenciBasari
            // 
            this.DgwOgrenciBasari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwOgrenciBasari.Location = new System.Drawing.Point(106, 142);
            this.DgwOgrenciBasari.Name = "DgwOgrenciBasari";
            this.DgwOgrenciBasari.RowTemplate.Height = 24;
            this.DgwOgrenciBasari.Size = new System.Drawing.Size(484, 309);
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
            // StudentAnalysisReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 554);
            this.Controls.Add(this.DgwOgrenciBasari);
            this.Controls.Add(this.BtnBasariGoruntule);
            this.Controls.Add(this.BtnBasariYazdır);
            this.Name = "StudentAnalysisReport";
            this.Text = "StudentAnalysisReport";
            ((System.ComponentModel.ISupportInitialize)(this.DgwOgrenciBasari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnBasariYazdır;
        private System.Windows.Forms.Button BtnBasariGoruntule;
        private System.Windows.Forms.DataGridView DgwOgrenciBasari;
        private System.Drawing.Printing.PrintDocument pdYazici;
        private System.Windows.Forms.PrintPreviewDialog ppdDialog;
    }
}