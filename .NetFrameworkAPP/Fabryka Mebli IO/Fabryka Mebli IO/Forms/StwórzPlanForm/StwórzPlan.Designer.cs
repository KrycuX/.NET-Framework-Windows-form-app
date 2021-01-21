
namespace Fabryka_Mebli_IO.Forms.StwórzPlanForm
{
    partial class Stwórz_Plan
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
            this.wyswietl = new System.Windows.Forms.Button();
            this.dodajButt = new System.Windows.Forms.Button();
            this.usunButt = new System.Windows.Forms.Button();
            this.stworzButt = new System.Windows.Forms.Button();
            this.powrótButt = new System.Windows.Forms.Button();
            this.checkBoxList = new System.Windows.Forms.CheckedListBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // wyswietl
            // 
            this.wyswietl.Location = new System.Drawing.Point(546, 12);
            this.wyswietl.Name = "wyswietl";
            this.wyswietl.Size = new System.Drawing.Size(77, 31);
            this.wyswietl.TabIndex = 3;
            this.wyswietl.Text = "Wyświetl";
            this.wyswietl.UseVisualStyleBackColor = true;
            this.wyswietl.Click += new System.EventHandler(this.button1_Click);
            // 
            // dodajButt
            // 
            this.dodajButt.Location = new System.Drawing.Point(546, 76);
            this.dodajButt.Name = "dodajButt";
            this.dodajButt.Size = new System.Drawing.Size(77, 31);
            this.dodajButt.TabIndex = 3;
            this.dodajButt.Text = "Dodaj";
            this.dodajButt.UseVisualStyleBackColor = true;
            this.dodajButt.Click += new System.EventHandler(this.dodajButt_Click);
            // 
            // usunButt
            // 
            this.usunButt.Location = new System.Drawing.Point(546, 124);
            this.usunButt.Name = "usunButt";
            this.usunButt.Size = new System.Drawing.Size(77, 31);
            this.usunButt.TabIndex = 3;
            this.usunButt.Text = "Usuń";
            this.usunButt.UseVisualStyleBackColor = true;
            this.usunButt.Click += new System.EventHandler(this.usunButt_Click);
            // 
            // stworzButt
            // 
            this.stworzButt.Location = new System.Drawing.Point(546, 188);
            this.stworzButt.Name = "stworzButt";
            this.stworzButt.Size = new System.Drawing.Size(77, 31);
            this.stworzButt.TabIndex = 3;
            this.stworzButt.Text = "Stwórz";
            this.stworzButt.UseVisualStyleBackColor = true;
            this.stworzButt.Click += new System.EventHandler(this.stworzButt_Click);
            // 
            // powrótButt
            // 
            this.powrótButt.Location = new System.Drawing.Point(546, 315);
            this.powrótButt.Name = "powrótButt";
            this.powrótButt.Size = new System.Drawing.Size(77, 31);
            this.powrótButt.TabIndex = 3;
            this.powrótButt.Text = "Powrót";
            this.powrótButt.UseVisualStyleBackColor = true;
            this.powrótButt.Click += new System.EventHandler(this.powrótButt_Click);
            // 
            // checkBoxList
            // 
            this.checkBoxList.FormattingEnabled = true;
            this.checkBoxList.Location = new System.Drawing.Point(22, 13);
            this.checkBoxList.Name = "checkBoxList";
            this.checkBoxList.Size = new System.Drawing.Size(496, 304);
            this.checkBoxList.TabIndex = 4;
            this.checkBoxList.SelectedIndexChanged += new System.EventHandler(this.checkBoxList_SelectedIndexChanged);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(22, 391);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(601, 160);
            this.listBox.TabIndex = 5;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(546, 235);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Plan1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(546, 259);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Plan2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Stwórz_Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 659);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.checkBoxList);
            this.Controls.Add(this.powrótButt);
            this.Controls.Add(this.stworzButt);
            this.Controls.Add(this.usunButt);
            this.Controls.Add(this.dodajButt);
            this.Controls.Add(this.wyswietl);
            this.Name = "Stwórz_Plan";
            this.Text = "Meble z Klasą";
            this.Load += new System.EventHandler(this.Stwórz_Plan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button wyswietl;
        private System.Windows.Forms.Button dodajButt;
        private System.Windows.Forms.Button usunButt;
        private System.Windows.Forms.Button stworzButt;
        private System.Windows.Forms.Button powrótButt;

 
        private System.Windows.Forms.CheckedListBox checkBoxList;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}