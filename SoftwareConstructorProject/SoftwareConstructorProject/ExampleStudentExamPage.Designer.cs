
namespace SoftwareConstructorProject
{
    partial class ExampleStudentExamPage
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
            this.RchTxtSorular = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RchTxtSorular
            // 
            this.RchTxtSorular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RchTxtSorular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RchTxtSorular.Location = new System.Drawing.Point(0, 0);
            this.RchTxtSorular.Name = "RchTxtSorular";
            this.RchTxtSorular.Size = new System.Drawing.Size(1174, 587);
            this.RchTxtSorular.TabIndex = 0;
            this.RchTxtSorular.Text = "";
            // 
            // ExampleStudentExamPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 587);
            this.Controls.Add(this.RchTxtSorular);
            this.Name = "ExampleStudentExamPage";
            this.Text = "ExampleStudentExamPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExampleStudentExamPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RchTxtSorular;
    }
}