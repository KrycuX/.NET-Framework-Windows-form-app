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
using Fabryka_Mebli_IO.Scripts;

namespace Fabryka_Mebli_IO.Forms.WyświetlPlan
{
    public partial class Wyswietl_Plan : Form
    {
        private PracownikClass pracownik;
        public Wyswietl_Plan(PracownikClass pracownik)
        {
            InitializeComponent();
            this.pracownik = pracownik;

        }

        private void powrotButt_Click(object sender, EventArgs e)
        {
            Nawigacja.PrevPage.Show();
            this.Close();
        }

        private void Wyswietl_Plan_Load(object sender, EventArgs e)
        {
           
           
        
           
                if (pracownik.getZmiana().Equals(1) && !pracownik.getStanowisko().Equals("Kierownik"))
                {
                    plan1.Enabled = true;
                    plan2.Enabled = false;
                }
                else if (pracownik.getZmiana().Equals(2) && !pracownik.getStanowisko().Equals("Kierownik"))
                {
                    plan1.Enabled = false;
                    plan2.Enabled = true;
                }
                else
                {
                    plan1.Enabled = true;
                    plan2.Enabled = true;
                }
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void plan1_CheckedChanged(object sender, EventArgs e)
        {
           

           
            ProdukcjaEntities2 db = new ProdukcjaEntities2();
           

            List<Plan_Pracy> plan = db.Plan_Pracy.ToList();
            List<ListaMebli_Zamowienie> meble = db.ListaMebli_Zamowienie.ToList();
            List<Pracownicy> p = db.Pracownicy.ToList();

            if (plan1.Checked)
            {
                listView1.Items.Clear();


                foreach (var x in plan)
                {
                    if (x.idPlanu.Equals(1))
                    {
                        foreach (var y in meble)
                        {
                            if (y.idListy.Equals(x.Zamówienie.idLista))
                            {
                                
                                ListViewItem listViewItem = new ListViewItem(y.Mebel.Nazwa);
                                //listViewItem.SubItems.Add(y.Mebel.Nazwa);
                                listViewItem.SubItems.Add(y.Kolor);
                                listViewItem.SubItems.Add(y.Mebel.Kod_Produktu);
                                if(y.Status.Equals("W Realizacji"))
                                {
                                    foreach (var z in p)
                                    {
                                       
                                        if(z.id==y.pracownikWykonujacy)
                                        {
                                            string stanowisko = z.Stanowisko;
                                            switch(stanowisko)
                                            {
                                                case "Pilarz" : listViewItem.SubItems.Add("W trakcie Cięcia"); break;
                                                case "Wiertacz" : listViewItem.SubItems.Add("W trakcie Wiercenia"); break;
                                                case "Oklejacz" : listViewItem.SubItems.Add("W trakcie Oklejania"); break;
                                                case "Pakowacz" : listViewItem.SubItems.Add("W trakcie Pakowania"); break;
                                                case "Montażysta": listViewItem.SubItems.Add("W trakcie Montażu"); break;


                                            }

                                        }
                                    }

                                }else
                                listViewItem.SubItems.Add(y.Status);
                               

                                
                                listView1.Items.Add(listViewItem); }
                        }
                    }
                }

            }
        }

        private void plan2_CheckedChanged(object sender, EventArgs e)
        {
            ProdukcjaEntities2 db = new ProdukcjaEntities2();

            List<Plan_Pracy> plan = db.Plan_Pracy.ToList();
            List<ListaMebli_Zamowienie> meble = db.ListaMebli_Zamowienie.ToList();
            List<Pracownicy> p = db.Pracownicy.ToList();
            if (plan2.Checked)
            {
                listView1.Items.Clear();
                foreach (var x in plan)
                {
                    if (x.idPlanu.Equals(2))
                    {
                        foreach (var y in meble)
                        {
                            if (y.idListy.Equals(x.Zamówienie.idLista))
                            {
                                ListViewItem listViewItem = new ListViewItem(y.Mebel.Nazwa);
                                //listViewItem.SubItems.Add(y.Mebel.Nazwa);
                                listViewItem.SubItems.Add(y.Kolor);
                                listViewItem.SubItems.Add(y.Mebel.Kod_Produktu);
                                if (y.Status.Equals("W Realizacji"))
                                {
                                    foreach (var z in p)
                                    {

                                        if (z.id == y.pracownikWykonujacy)
                                        {
                                            string stanowisko = z.Stanowisko;
                                            switch (stanowisko)
                                            {
                                                case "Pilarz": listViewItem.SubItems.Add("W trakcie Cięcia"); break;
                                                case "Wiertacz": listViewItem.SubItems.Add("W trakcie Wiercenia"); break;
                                                case "Oklejacz": listViewItem.SubItems.Add("W trakcie Oklejania"); break;
                                                case "Pakowacz": listViewItem.SubItems.Add("W trakcie Pakowania"); break;
                                                case "Montażysta": listViewItem.SubItems.Add("W trakcie Montażu"); break;


                                            }

                                        }
                                    }

                                }
                                else
                                    listViewItem.SubItems.Add(y.Status);
                                listView1.Items.Add(listViewItem);
                            }
                        }

                    }
                }

            }
        }

        
    }
}
