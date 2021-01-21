using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fabryka_Mebli_IO.Databases;
using Fabryka_Mebli_IO.Forms.WydanieZewForm;
using Fabryka_Mebli_IO.Scripts;

namespace Fabryka_Mebli_IO.Forms.MagazynForm
{
    public partial class Magazyn : Form
    { 
        
        
        PracownikClass pracownik;
        public Magazyn(PracownikClass pracownik)
        {
            InitializeComponent();
            this.pracownik = pracownik;
        }

        private void powrót_Click(object sender, EventArgs e)
        {
           Nawigacja.PrevPage.Show();
            this.Close();
        }

     

        private void Magazyn_Load(object sender, EventArgs e)
        {
            ProdukcjaEntities2 db = new ProdukcjaEntities2();

            List<Zamówienie> zam = db.Zamówienie.ToList();
            List<String> check = new List<String>();

            wzButt.Enabled = false;

            foreach (var x in zam)
            {
                if (x.Status.Equals("Gotowe Do Wydania"))
                {
                    string info = x.id.ToString() + " " + x.DaneZamawiajacego.Imie + " " + x.DaneZamawiajacego.Nazwisko + " " + x.DaneZamawiajacego.Miasto + " " + x.DaneZamawiajacego.Ulica + " " + x.DaneZamawiajacego.NrTel.ToString();
                    check.Add(info);
                }
            }

            checkedListBox1.Items.AddRange(check.ToArray());
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checkedListBox1.CheckedItems.Count>0)
            {
                wzButt.Enabled = true;
            }
            else
            {
                wzButt.Enabled = false;
            }
        }

        private void wzButt_Click(object sender, EventArgs e)
        {
            List<String> list = new List<String>();
            foreach (var x in checkedListBox1.CheckedItems.OfType<String>().ToList())
            {
                list.Add(x);
            
            
            }
           
            WZ wz = new WZ(this,list,pracownik);
            wz.Show();
            this.Enabled = false;

        }
    }
}
