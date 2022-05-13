
namespace SoftwareConstructorProject
{
    partial class StudentHomePage
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
            this.BtnSinavSistemiGiris = new System.Windows.Forms.Button();
            this.BtnAyarlar = new System.Windows.Forms.Button();
            this.BtnZamansizSinav = new System.Windows.Forms.Button();
            this.BtnAnalizRaporu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSinavSistemiGiris
            // 
            this.BtnSinavSistemiGiris.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnSinavSistemiGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSinavSistemiGiris.Location = new System.Drawing.Point(170, 84);
            this.BtnSinavSistemiGiris.Name = "BtnSinavSistemiGiris";
            this.BtnSinavSistemiGiris.Size = new System.Drawing.Size(133, 84);
            this.BtnSinavSistemiGiris.TabIndex = 0;
            this.BtnSinavSistemiGiris.Text = "Sınava Girmek İçin Tıklayınız";
            this.BtnSinavSistemiGiris.UseVisualStyleBackColor = false;
            this.BtnSinavSistemiGiris.Click += new System.EventHandler(this.BtnSinavSistemiGiris_Click);
            // 
            // BtnAyarlar
            // 
            this.BtnAyarlar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnAyarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAyarlar.Location = new System.Drawing.Point(170, 251);
            this.BtnAyarlar.Name = "BtnAyarlar";
            this.BtnAyarlar.Size = new System.Drawing.Size(133, 84);
            this.BtnAyarlar.TabIndex = 1;
            this.BtnAyarlar.Text = "Ayarlar";
            this.BtnAyarlar.UseVisualStyleBackColor = false;
            this.BtnAyarlar.Click += new System.EventHandler(this.BtnAyarlar_Click);
            // 
            // BtnZamansizSinav
            // 
            this.BtnZamansizSinav.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnZamansizSinav.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZamansizSinav.Location = new System.Drawing.Point(775, 61);
            this.BtnZamansizSinav.Name = "BtnZamansizSinav";
            this.BtnZamansizSinav.Size = new System.Drawing.Size(133, 131);
            this.BtnZamansizSinav.TabIndex = 2;
            this.BtnZamansizSinav.Text = "Zaman Bazlı Olmayan \r\nSınava Girmek İçin Tıklayınız";
            this.BtnZamansizSinav.UseVisualStyleBackColor = false;
            this.BtnZamansizSinav.Click += new System.EventHandler(this.BtnZamansizSinav_Click);
            // 
            // BtnAnalizRaporu
            // 
            this.BtnAnalizRaporu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnAnalizRaporu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnalizRaporu.Location = new System.Drawing.Point(775, 204);
            this.BtnAnalizRaporu.Name = "BtnAnalizRaporu";
            this.BtnAnalizRaporu.Size = new System.Drawing.Size(133, 131);
            this.BtnAnalizRaporu.TabIndex = 3;
            this.BtnAnalizRaporu.Text = "Başarınızı Görmek İçin Tıklayınız";
            this.BtnAnalizRaporu.UseVisualStyleBackColor = false;
            this.BtnAnalizRaporu.Click += new System.EventHandler(this.BtnAnalizRaporu_Click);
            // 
            // StudentHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1028, 558);
            this.Controls.Add(this.BtnAnalizRaporu);
            this.Controls.Add(this.BtnZamansizSinav);
            this.Controls.Add(this.BtnAyarlar);
            this.Controls.Add(this.BtnSinavSistemiGiris);
            this.Name = "StudentHomePage";
            this.Text = "Öğrenci Ana Sayfası";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentHomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSinavSistemiGiris;
        private System.Windows.Forms.Button BtnAyarlar;
        private System.Windows.Forms.Button BtnZamansizSinav;
        private System.Windows.Forms.Button BtnAnalizRaporu;
    }
}