
namespace Fabryka_Mebli_IO.Forms.Produkcja
{
    partial class DodajForm
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
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // takButt
            // 
            this.takButt.Location = new System.Drawing.Point(85, 70);
            this.takButt.Name = "takButt";
            this.takButt.Size = new System.Drawing.Size(75, 23);
            this.takButt.TabIndex = 0;
            this.takButt.Text = "Tak";
            this.takButt.UseVisualStyleBackColor = true;
            this.takButt.Click += new System.EventHandler(this.takButt_Click);
            // 
            // nieButt
            // 
            this.nieButt.Location = new System.Drawing.Point(246, 70);
            this.nieButt.Name = "nieButt";
            this.nieButt.Size = new System.Drawing.Size(75, 23);
            this.nieButt.TabIndex = 1;
            this.nieButt.Text = "Nie";
            this.nieButt.UseVisualStyleBackColor = true;
            this.nieButt.Click += new System.EventHandler(this.nieButt_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(82, 27);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(239, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Czy chcesz zacząc realizować wybrany element?";
            // 
            // DodajForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 120);
            this.Controls.Add(this.label);
            this.Controls.Add(this.nieButt);
            this.Controls.Add(this.takButt);
            this.Name = "DodajForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button takButt;
        private System.Windows.Forms.Button nieButt;
        private System.Windows.Forms.Label label;
    }
}