
namespace Fabryka_Mebli_IO.Forms.Produkcja
{
    partial class ZakonczForm
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
            this.takButt = new System.Windows.Forms.Button();
            this.nieButt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // takButt
            // 
            this.takButt.Location = new System.Drawing.Point(82, 88);
            this.takButt.Name = "takButt";
            this.takButt.Size = new System.Drawing.Size(75, 23);
            this.takButt.TabIndex = 0;
            this.takButt.Text = "Tak";
            this.takButt.UseVisualStyleBackColor = true;
            this.takButt.Click += new System.EventHandler(this.takButt_Click);
            // 
            // nieButt
            // 
            this.nieButt.Location = new System.Drawing.Point(265, 88);
            this.nieButt.Name = "nieButt";
            this.nieButt.Size = new System.Drawing.Size(75, 23);
            this.nieButt.TabIndex = 1;
            this.nieButt.Text = "Nie";
            this.nieButt.UseVisualStyleBackColor = true;
            this.nieButt.Click += new System.EventHandler(this.nieButt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Czy chcesz Zakonczyc Dany mebel?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ZakonczForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 180);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nieButt);
            this.Controls.Add(this.takButt);
            this.Name = "ZakonczForm";
            this.Text = "ZakonczForm";
            this.Load += new System.EventHandler(this.ZakonczForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button takButt;
        private System.Windows.Forms.Button nieButt;
        private System.Windows.Forms.Label label1;
    }
}