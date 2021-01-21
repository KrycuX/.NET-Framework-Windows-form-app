
namespace Fabryka_Mebli_IO.Forms.WyświetlPlan
{
    partial class Wyswietl_Plan
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
            this.powrotButt = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.plan1 = new System.Windows.Forms.RadioButton();
            this.plan2 = new System.Windows.Forms.RadioButton();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // powrotButt
            // 
            this.powrotButt.Location = new System.Drawing.Point(641, 375);
            this.powrotButt.Name = "powrotButt";
            this.powrotButt.Size = new System.Drawing.Size(147, 34);
            this.powrotButt.TabIndex = 0;
            this.powrotButt.Text = "Powrót";
            this.powrotButt.UseVisualStyleBackColor = true;
            this.powrotButt.Click += new System.EventHandler(this.powrotButt_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(623, 397);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nazwa";
            this.columnHeader1.Width = 185;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kolor";
            this.columnHeader2.Width = 129;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kod";
            this.columnHeader3.Width = 79;
            // 
            // plan1
            // 
            this.plan1.AutoSize = true;
            this.plan1.Location = new System.Drawing.Point(658, 31);
            this.plan1.Name = "plan1";
            this.plan1.Size = new System.Drawing.Size(52, 17);
            this.plan1.TabIndex = 2;
            this.plan1.TabStop = true;
            this.plan1.Text = "Plan1";
            this.plan1.UseVisualStyleBackColor = true;
            this.plan1.CheckedChanged += new System.EventHandler(this.plan1_CheckedChanged);
            // 
            // plan2
            // 
            this.plan2.AutoSize = true;
            this.plan2.Location = new System.Drawing.Point(658, 55);
            this.plan2.Name = "plan2";
            this.plan2.Size = new System.Drawing.Size(52, 17);
            this.plan2.TabIndex = 3;
            this.plan2.TabStop = true;
            this.plan2.Text = "Plan2";
            this.plan2.UseVisualStyleBackColor = true;
            this.plan2.CheckedChanged += new System.EventHandler(this.plan2_CheckedChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 227;
            // 
            // Wyswietl_Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.plan2);
            this.Controls.Add(this.plan1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.powrotButt);
            this.Name = "Wyswietl_Plan";
            this.Text = "WyswietlPlan";
            this.Load += new System.EventHandler(this.Wyswietl_Plan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powrotButt;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton plan1;
        private System.Windows.Forms.RadioButton plan2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}