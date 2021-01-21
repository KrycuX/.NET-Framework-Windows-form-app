using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Fabryka_Mebli_IO.Forms.StwórzPlanForm;
using Fabryka_Mebli_IO.Forms.WyświetlPlan;
using Fabryka_Mebli_IO.Forms.WydanieZewForm;
using Fabryka_Mebli_IO.Forms.MagazynForm;

using Fabryka_Mebli_IO.Scripts;
using Fabryka_Mebli_IO.Databases;
using Fabryka_Mebli_IO.Forms.Produkcja;
using Fabryka_Mebli_IO.Forms.Przychodzace;

namespace Fabryka_Mebli_IO.Forms
{
    public partial class Main_GUI : Form
    {
        PracownikClass pracownik;
        
        ProdukcjaEntities2 db;
        public Main_GUI(PracownikClass ob)
        {

            InitializeComponent();
           
            this.pracownik = ob;
        }

     
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Nawigacja.logForm.Show();
            this.Close();
        }

        private void Main_GUI_Load_1(object sender, EventArgs e)
        {
            this.label.Text = "Zalogowany jako " + pracownik.getStanowisko()+" "+pracownik.getImie();
            Nawigacja.mainGUI = this;
            
            prodButt.Visible = false;
            
            if (pracownik.getStanowisko().Equals("Pilarz") || pracownik.getStanowisko().Equals("Oklejacz") || pracownik.getStanowisko().Equals("Wiertacz") || pracownik.getStanowisko().Equals("Montażysta")|| pracownik.getStanowisko().Equals("Pakowacz"))
            {
                tworzplanButt.Visible = false;
                listaButt.Visible = false;
                magazynButt.Visible = false;
                prodButt.Visible = true;
                button1.Visible = false;
                groupBox1.Text = pracownik.getStanowisko();
                
             

            }

            



            db = new ProdukcjaEntities2();

            Sprawdz.CzyWyslane(db);
            Sprawdz.CzyGotowe(db);
            db.SaveChanges();

        }

        private void tworzplanButt_Click(object sender, EventArgs e)
        {
            Nawigacja.PrevPage = this;
           Stwórz_Plan plan = new Stwórz_Plan(pracownik.getZmiana());
            plan.Show();
            this.Hide();

        }

        private void listaButt_Click(object sender, EventArgs e)
        {
            db = new ProdukcjaEntities2();
            /*PrevForm.PrevPage = this;
            Lista_Zlecen zlecenia = new Lista_Zlecen();
            zlecenia.Show();
            this.Hide();*/

            List<Zamówienie> zamowienia = db.Zamówienie.ToList();
            List<DaneZamawiajacego> c = db.DaneZamawiajacego.ToList();
           // List<String> check = new List<String>();


            listView1.Clear();
            
            listView1.Columns.Add("id");
            listView1.Columns.Add("Kod Zamówienia");
            listView1.Columns.Add("Imie");
            listView1.Columns.Add("Nazwisko");
            listView1.Columns.Add("Miasto");
            listView1.Columns.Add("Nr.Tel.");
            listView1.Columns.Add("Data");
            listView1.Columns.Add("Status");
        
            


            foreach (var x in zamowienia)
            { 
                
                    ListViewItem listViewItem = new ListViewItem(x.id.ToString());
                    //listViewItem.SubItems.Add(y.Mebel.Nazwa);
                    listViewItem.SubItems.Add(x.Kod_Zlecenia);
                    listViewItem.SubItems.Add(x.DaneZamawiajacego.Imie);
                    listViewItem.SubItems.Add(x.DaneZamawiajacego.Nazwisko);
                    listViewItem.SubItems.Add(x.DaneZamawiajacego.Miasto);
                    listViewItem.SubItems.Add(x.DaneZamawiajacego.NrTel.ToString());
                    listViewItem.SubItems.Add(x.DataRealizacji.ToString());
                    listViewItem.SubItems.Add(x.Status);
                    listView1.Items.Add(listViewItem);

                    
                    
                


            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);




        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            
        }

        private void magazynButt_Click(object sender, EventArgs e)
        {
            Nawigacja.PrevPage = this;
            Magazyn m = new Magazyn(pracownik);
            m.Show();
            this.Hide();
        }

        private void wyswietl_planButt_Click(object sender, EventArgs e)
        {
            Nawigacja.PrevPage = this;

            

            Wyswietl_Plan plan = new Wyswietl_Plan(pracownik);
            plan.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nawigacja.PrevPage = this;
            ProdForm prod = new ProdForm(pracownik);
            prod.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<Zamówienie> zamowienie = new List<Zamówienie>();
            List<ListaMebli_Zamowienie> meble = new List<ListaMebli_Zamowienie>();

            foreach (var x in zamowienie)
            {
                Boolean pomoc = true;
                foreach (var y in meble)
                {
                    if (y.idListy.Equals(x.idLista) && y.Status.Equals("DoRealizacji") || y.Status.Equals("W Realizacji"))
                    {
                        pomoc = false;
                    }

                }
                if (pomoc == true)
                {
                    x.Status = "Gotowe Do Wydania";
                }


            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Nawigacja.PrevPage = this;
            Zlecenia_Przychodzace zlec = new Zlecenia_Przychodzace(); 
            zlec.Show();
            this.Hide();
        }
    }
}
