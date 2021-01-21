
namespace Fabryka_Mebli_IO.Forms
{
    partial class Main_GUI
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
            this.Logout = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.listaButt = new System.Windows.Forms.Button();
            this.tworzplanButt = new System.Windows.Forms.Button();
            this.magazynButt = new System.Windows.Forms.Button();
            this.wyswietl_planButt = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.prodButt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(773, 459);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(96, 30);
            this.Logout.TabIndex = 0;
            this.Logout.Text = "Wyloguj";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(22, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Zalogowany jako ...";
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // listaButt
            // 
            this.listaButt.Location = new System.Drawing.Point(6, 18);
            this.listaButt.Name = "listaButt";
            this.listaButt.Size = new System.Drawing.Size(96, 33);
            this.listaButt.TabIndex = 3;
            this.listaButt.Text = "Lista Zlecen";
            this.listaButt.UseVisualStyleBackColor = true;
            this.listaButt.Click += new System.EventHandler(this.listaButt_Click);
            // 
            // tworzplanButt
            // 
            this.tworzplanButt.Location = new System.Drawing.Point(6, 74);
            this.tworzplanButt.Name = "tworzplanButt";
            this.tworzplanButt.Size = new System.Drawing.Size(96, 34);
            this.tworzplanButt.TabIndex = 4;
            this.tworzplanButt.Text = "Stwórz Plan";
            this.tworzplanButt.UseVisualStyleBackColor = true;
            this.tworzplanButt.Click += new System.EventHandler(this.tworzplanButt_Click);
            // 
            // magazynButt
            // 
            this.magazynButt.Location = new System.Drawing.Point(158, 75);
            this.magazynButt.Name = "magazynButt";
            this.magazynButt.Size = new System.Drawing.Size(96, 33);
            this.magazynButt.TabIndex = 5;
            this.magazynButt.Text = "Magazyn";
            this.magazynButt.UseVisualStyleBackColor = true;
            this.magazynButt.Click += new System.EventHandler(this.magazynButt_Click);
            // 
            // wyswietl_planButt
            // 
            this.wyswietl_planButt.Location = new System.Drawing.Point(158, 17);
            this.wyswietl_planButt.Name = "wyswietl_planButt";
            this.wyswietl_planButt.Size = new System.Drawing.Size(96, 34);
            this.wyswietl_planButt.TabIndex = 6;
            this.wyswietl_planButt.Text = "Wyswietl Plan";
            this.wyswietl_planButt.UseVisualStyleBackColor = true;
            this.wyswietl_planButt.Click += new System.EventHandler(this.wyswietl_planButt_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(584, 397);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // prodButt
            // 
            this.prodButt.Location = new System.Drawing.Point(6, 18);
            this.prodButt.Name = "prodButt";
            this.prodButt.Size = new System.Drawing.Size(96, 33);
            this.prodButt.TabIndex = 9;
            this.prodButt.Text = "Produkcja";
            this.prodButt.UseVisualStyleBackColor = true;
            this.prodButt.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.magazynButt);
            this.groupBox1.Controls.Add(this.prodButt);
            this.groupBox1.Controls.Add(this.listaButt);
            this.groupBox1.Controls.Add(this.tworzplanButt);
            this.groupBox1.Controls.Add(this.wyswietl_planButt);
            this.groupBox1.Location = new System.Drawing.Point(615, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 176);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kierownik";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Zlecenia Przychodzące";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Main_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 501);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Logout);
            this.Name = "Main_GUI";
            this.Text = "Meble z Klasą";
            this.Load += new System.EventHandler(this.Main_GUI_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button listaButt;
        private System.Windows.Forms.Button tworzplanButt;
        private System.Windows.Forms.Button magazynButt;
        private System.Windows.Forms.Button wyswietl_planButt;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button prodButt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}