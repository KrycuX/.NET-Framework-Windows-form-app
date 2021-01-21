
namespace Fabryka_Mebli_IO.Forms.MagazynForm
{
    partial class Magazyn
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
            this.powrót = new System.Windows.Forms.Button();
            this.wzButt = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // powrót
            // 
            this.powrót.Location = new System.Drawing.Point(678, 395);
            this.powrót.Name = "powrót";
            this.powrót.Size = new System.Drawing.Size(110, 33);
            this.powrót.TabIndex = 0;
            this.powrót.Text = "Powrót";
            this.powrót.UseVisualStyleBackColor = true;
            this.powrót.Click += new System.EventHandler(this.powrót_Click);
            // 
            // wzButt
            // 
            this.wzButt.Location = new System.Drawing.Point(543, 395);
            this.wzButt.Name = "wzButt";
            this.wzButt.Size = new System.Drawing.Size(110, 33);
            this.wzButt.TabIndex = 0;
            this.wzButt.Text = "WZ";
            this.wzButt.UseVisualStyleBackColor = true;
            this.wzButt.Click += new System.EventHandler(this.wzButt_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(21, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(516, 409);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Magazyn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.wzButt);
            this.Controls.Add(this.powrót);
            this.Name = "Magazyn";
            this.Text = "Magazyn";
            this.Load += new System.EventHandler(this.Magazyn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button powrót;
        private System.Windows.Forms.Button wzButt;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}