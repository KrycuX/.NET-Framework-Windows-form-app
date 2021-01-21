using Fabryka_Mebli_IO.Databases;
using Fabryka_Mebli_IO.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabryka_Mebli_IO.Forms.MagazynForm.WydanieZewForm
{
    public partial class zapytanie : Form
    {
        Form prev;
        Form magazyn;
        List<String> list;
        ProdukcjaEntities2 db;
        public zapytanie(Form prev, Form magazyn, List<String> list)
        {
            InitializeComponent();
            this.prev = prev;
            this.magazyn = magazyn;
            this.list = list;
            db = new ProdukcjaEntities2();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void zapytanie_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Visible = false;

            button2.Enabled = false;
            button2.Visible = false;
            label1.Text = "";

            progressBar1.Visible = true;

            List<Zamówienie> zm = db.Zamówienie.ToList();

            foreach(var x in zm)
            {
                foreach(var y in list)
                {
                    string[] split = y.Split(' ');
                    if(x.id == Int32.Parse(split[0]))
                    {
                        x.Status = "Wysłany";
                    }
                }
            }
            db.SaveChanges();
         
            for (int i = 0; i <= 10000; i++)
            {
                progressBar1.PerformStep();
                
            }

            if (progressBar1.Value==100)
            {
                label1.Text = "Pomyślnie wysłano plik";
                button3.Enabled = true;
                button3.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nawigacja.mainGUI.Show();
            magazyn.Close();
        
            prev.Close();
            this.Close();
            
        }
    }
}
