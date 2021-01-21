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

namespace Fabryka_Mebli_IO.Forms.Produkcja
{
    public partial class ZakonczForm : Form
    {
        private ProdukcjaEntities2 db;
        private ListBox listBox2;
        private Form prev;
        private PracownikClass pracownik;
        private Timer timer;
        public ZakonczForm(ProdukcjaEntities2 db, ListBox listBox,Form prev,PracownikClass pracownik,Timer timer)
        {
            InitializeComponent();
            this.db = db;
            this.listBox2 = listBox;
            this.prev = prev;
            this.pracownik = pracownik;
            this.timer = timer;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void takButt_Click(object sender, EventArgs e)
        {
            string help = listBox2.SelectedItem.ToString();
            string[] split = help.Split(' ');
            int id = Int32.Parse(split[0]);
            var obj = db.ListaMebli_Zamowienie.Where(j => j.id == id).FirstOrDefault();
            
            List<Zamówienie> zam = db.Zamówienie.ToList();
            

            if (pracownik.getStanowisko().Equals("Pilarz"))
            {
                obj.Status = "Gotowy Do Wiercenia";
            }
            else if (pracownik.getStanowisko().Equals("Wiertacz"))
            {
                obj.Status = "Gotowy Do Oklejania";
            }
            else if (pracownik.getStanowisko().Equals("Oklejacz"))
            {

                foreach (var x in zam)
                    {
                    if (x.idLista == obj.idListy && x.Rodzaj==1)
                    { 
                        obj.Status = "Gotowy Do Pakowania";
                    }
                    if (x.idLista == obj.idListy && x.Rodzaj == 2)
                    {
                        obj.Status = "Gotowy Do Montażu";
                    }
                }
            }
            else if (pracownik.getStanowisko().Equals("Pakowacz") || pracownik.getStanowisko().Equals("Montażysta"))
            {
                obj.Status = "Gotowy";

            }

            db.SaveChanges();



            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            timer.Start();
            this.Close();
            prev.Enabled = true;
        }

        private void ZakonczForm_Load(object sender, EventArgs e)
        {

        }

        private void nieButt_Click(object sender, EventArgs e)
        {
            timer.Start();
            this.Close();
            prev.Enabled = true;
        }
    }
}
