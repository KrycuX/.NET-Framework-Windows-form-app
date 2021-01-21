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

   

    public partial class ProdForm : Form
    {
        public Timer timer;
        private PracownikClass pracownik;
        public ProdForm(PracownikClass pracownik)
        {
            InitializeComponent();
            this.pracownik = pracownik;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();

            ProdukcjaEntities2 db = new ProdukcjaEntities2();
            if (listBox1.SelectedIndex > -1)
            {
                DodajForm dodaj = new DodajForm(db, listBox1, listBox2, this, pracownik.getId(),timer);

                dodaj.Show();
                this.Enabled = false;
            }
            else
            {
                MessageBox.Show("Musisz zaznaczyc rekord!");
                timer.Start();
            }
        }

        private void ProdForm_Load(object sender, EventArgs e)
        {

            timer = new Timer();
            timer.Interval = (5 * 1000); // 5 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            

            ProdukcjaEntities2 db = new ProdukcjaEntities2();
            Boolean zmiana1=false;
            Boolean zmiana2=false;

            List<Plan_Pracy> plan = db.Plan_Pracy.ToList();
            List<ListaMebli_Zamowienie> meble = db.ListaMebli_Zamowienie.ToList();
            List<String> list = new List<String>();
            List<String> list2 = new List<String>();
            int id = pracownik.getId();
            var obj = db.Pracownicy.Where(j => j.id == id).FirstOrDefault();
               
           
                if(obj.Zmiany==1)
                {
                    zmiana1 = true;
                    zmiana2 = false;
                }else if (obj.Zmiany==2)
                {
                    zmiana1 = false;
                    zmiana2 = true;
                }

            

            if (zmiana1 == true)
            {
                foreach (var x in plan)
                {
                    if (x.idPlanu.Equals(1))
                    {
                        foreach (var y in meble)
                        {
                            if(y.idListy.Equals(x.Zamówienie.idLista) && pracownik.getStanowisko().Equals("Pilarz") && y.Status.Equals("Usterka"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie+" | [POPRAWKA]"; ;

                                list.Add(element);
                            }

                            if (y.idListy.Equals(x.Zamówienie.idLista) && y.Status.Equals("DoRealizacji") && pracownik.getStanowisko().Equals("Pilarz") )
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu+ " | " + x.idZamowienie;

                                list.Add(element);


                            }else if(y.idListy.Equals(x.Zamówienie.idLista) && y.Status.Equals("Gotowy Do Wiercenia") && pracownik.getStanowisko().Equals("Wiertacz"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie;

                                list.Add(element);
                            }else if (y.idListy.Equals(x.Zamówienie.idLista) && y.Status.Equals("Gotowy Do Oklejania") && pracownik.getStanowisko().Equals("Oklejacz"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie;

                                list.Add(element);
                            }
                            else if (y.idListy.Equals(x.Zamówienie.idLista) && y.Status.Equals("Gotowy Do Pakowania") && pracownik.getStanowisko().Equals("Pakowacz"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie;

                                list.Add(element);
                            }
                            else if (y.idListy.Equals(x.Zamówienie.idLista) && y.Status.Equals("Gotowy Do Montażu") && pracownik.getStanowisko().Equals("Montażysta"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie;

                                list.Add(element);
                            }



                            if (y.idListy.Equals(x.Zamówienie.idLista) && y.pracownikWykonujacy == pracownik.getId() && y.Status.Equals("W Realizacji"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu+ " | " + x.idZamowienie;
                                list2.Add(element);
                            }
                        }
                    }
                }

                listBox1.Items.AddRange(list.ToArray());
                listBox2.Items.AddRange(list2.ToArray());


            }else if (zmiana2 == true)
            {
                foreach (var x in plan)
                {
                    if (x.idPlanu.Equals(2))
                    {
                        foreach (var y in meble)
                        {
                            if (y.idListy.Equals(x.Zamówienie.idLista) && pracownik.getStanowisko().Equals("Pilarz") && y.Status.Equals("Usterka"))
                            {
                                string element =y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie +" | [POPRAWKA]"; 

                                list.Add(element);
                            }

                            if (y.idListy.Equals(x.Zamówienie.idLista) && pracownik.getStanowisko().Equals("Pilarz") && y.Status.Equals("DoRealizacji"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie;

                                list.Add(element);


                            }
                            else if (y.idListy.Equals(x.Zamówienie.idLista) && y.Status.Equals("Gotowy Do Wiercenia") && pracownik.getStanowisko().Equals("Wiertacz"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie;

                                list.Add(element);
                            }
                            else if (y.idListy.Equals(x.Zamówienie.idLista) && y.Status.Equals("Gotowy Do Oklejania") && pracownik.getStanowisko().Equals("Oklejacz"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie;

                                list.Add(element);
                            }
                            else if (y.idListy.Equals(x.Zamówienie.idLista) && y.Status.Equals("Gotowy Do Pakowania") && pracownik.getStanowisko().Equals("Pakowacz"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie;

                                list.Add(element);
                            }
                            else if (y.idListy.Equals(x.Zamówienie.idLista) && y.Status.Equals("Gotowy Do Montażu") && pracownik.getStanowisko().Equals("Montażysta"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie;

                                list.Add(element);
                            }



                            if (y.idListy.Equals(x.Zamówienie.idLista) && y.pracownikWykonujacy == pracownik.getId() && y.Status.Equals("W Realizacji"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie;
                                list2.Add(element);
                            }

                        }
                    }
                }

                listBox1.Items.AddRange(list.ToArray());
                listBox2.Items.AddRange(list2.ToArray());
            }

           
          

          
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();


            ProdukcjaEntities2 db = new ProdukcjaEntities2();
            Boolean zmiana1 = false;
            Boolean zmiana2 = false;

            List<Plan_Pracy> plan = db.Plan_Pracy.ToList();
            List<ListaMebli_Zamowienie> meble = db.ListaMebli_Zamowienie.ToList();
            List<String> list = new List<String>();
            List<String> list2 = new List<String>();
            int id = pracownik.getId();
            var obj = db.Pracownicy.Where(j => j.id == id).FirstOrDefault();


            if (obj.Zmiany == 1)
            {
                zmiana1 = true;
                zmiana2 = false;
            }
            else if (obj.Zmiany == 2)
            {
                zmiana1 = false;
                zmiana2 = true;
            }



            if (zmiana1 == true)
            {
                foreach (var x in plan)
                {
                    if (x.idPlanu.Equals(1))
                    {
                        foreach (var y in meble)
                        {
                            if (y.idListy.Equals(x.Zamówienie.idLista) && pracownik.getStanowisko().Equals("Pilarz") && y.Status.Equals("Usterka"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie + " | [POPRAWKA]"; ;

                                list.Add(element);
                            }

                            if (y.idListy.Equals(x.Zamówienie.idLista) && y.Status.Equals("DoRealizacji") && pracownik.getStanowisko().Equals("Pilarz"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie;

                                list.Add(element);


                            }
                            else if (y.idListy.Equals(x.Zamówienie.idLista) && y.Status.Equals("Gotowy Do Wiercenia") && pracownik.getStanowisko().Equals("Wiertacz"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie;

                                list.Add(element);
                            }
                            else if (y.idListy.Equals(x.Zamówienie.idLista) && y.Status.Equals("Gotowy Do Oklejania") && pracownik.getStanowisko().Equals("Oklejacz"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie;

                                list.Add(element);
                            }
                            else if (y.idListy.Equals(x.Zamówienie.idLista) && y.Status.Equals("Gotowy Do Pakowania") && pracownik.getStanowisko().Equals("Pakowacz"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie;

                                list.Add(element);
                            }
                            else if (y.idListy.Equals(x.Zamówienie.idLista) && y.Status.Equals("Gotowy Do Montażu") && pracownik.getStanowisko().Equals("Montażysta"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie;

                                list.Add(element);
                            }



                            if (y.idListy.Equals(x.Zamówienie.idLista) && y.pracownikWykonujacy == pracownik.getId() && y.Status.Equals("W Realizacji"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie;
                                list2.Add(element);
                            }
                        }
                    }
                }

                listBox1.Items.AddRange(list.ToArray());
                listBox2.Items.AddRange(list2.ToArray());


            }
            else if (zmiana2 == true)
            {
                foreach (var x in plan)
                {
                    if (x.idPlanu.Equals(2))
                    {
                        foreach (var y in meble)
                        {
                            if (y.idListy.Equals(x.Zamówienie.idLista) && pracownik.getStanowisko().Equals("Pilarz") && y.Status.Equals("Usterka"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie + " | [POPRAWKA]";

                                list.Add(element);
                            }

                            if (y.idListy.Equals(x.Zamówienie.idLista) && pracownik.getStanowisko().Equals("Pilarz") && y.Status.Equals("DoRealizacji"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie;

                                list.Add(element);


                            }
                            else if (y.idListy.Equals(x.Zamówienie.idLista) && y.Status.Equals("Gotowy Do Wiercenia") && pracownik.getStanowisko().Equals("Wiertacz"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie;

                                list.Add(element);
                            }
                            else if (y.idListy.Equals(x.Zamówienie.idLista) && y.Status.Equals("Gotowy Do Oklejania") && pracownik.getStanowisko().Equals("Oklejacz"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie;

                                list.Add(element);
                            }
                            else if (y.idListy.Equals(x.Zamówienie.idLista) && y.Status.Equals("Gotowy Do Pakowania") && pracownik.getStanowisko().Equals("Pakowacz"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie;

                                list.Add(element);
                            }
                            else if (y.idListy.Equals(x.Zamówienie.idLista) && y.Status.Equals("Gotowy Do Montażu") && pracownik.getStanowisko().Equals("Montażysta"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie;

                                list.Add(element);
                            }



                            if (y.idListy.Equals(x.Zamówienie.idLista) && y.pracownikWykonujacy == pracownik.getId() && y.Status.Equals("W Realizacji"))
                            {
                                string element = y.id + " " + y.Mebel.Nazwa + " " + y.Kolor + " " + y.Mebel.Kod_Produktu + " | " + x.idZamowienie;
                                list2.Add(element);
                            }

                        }
                    }
                }

                listBox1.Items.AddRange(list.ToArray());
                listBox2.Items.AddRange(list2.ToArray());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            ProdukcjaEntities2 db = new ProdukcjaEntities2();
            if (listBox2.SelectedIndex > -1)
            {
                ZakonczForm end = new ZakonczForm(db, listBox2, this, pracownik, timer);

                end.Show();
                this.Enabled = false;
            }
            else
            
                MessageBox.Show("Musisz zaznaczyc rekord!");
                timer.Start();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Nawigacja.mainGUI.Show();
        }

        private void zglosButt_Click(object sender, EventArgs e)
        {
            timer.Stop();
            ProdukcjaEntities2 db = new ProdukcjaEntities2();
            if (listBox2.SelectedIndex > -1)
            {
                Usterka ust = new Usterka(db, listBox2, this, pracownik, timer);
                ust.Show();
                    this.Enabled = false;
            }
            else
                MessageBox.Show("Musisz zaznaczyc rekord!");
            timer.Start();
        }
    }
}
