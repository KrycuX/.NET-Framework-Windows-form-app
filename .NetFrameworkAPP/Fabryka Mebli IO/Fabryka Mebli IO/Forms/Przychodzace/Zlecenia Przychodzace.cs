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

namespace Fabryka_Mebli_IO.Forms.Przychodzace
{
    public partial class Zlecenia_Przychodzace : Form
    {
        ProdukcjaEntities2 db;
        public Zlecenia_Przychodzace()
        {
            InitializeComponent();
            db = new ProdukcjaEntities2();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void Zlecenia_Przychodzace_Load(object sender, EventArgs e)
        {
            List<Zamówienie> zamowienia = db.Zamówienie.ToList();
            List<DaneZamawiajacego> c = db.DaneZamawiajacego.ToList();
            List<String> check = new List<String>();




            foreach (var x in zamowienia)
            {
                if (x.Status.Equals("Oczekujący Na Przyjecie"))
                {
                    string nameAndId = x.id.ToString() + " " + x.DataRealizacji + " ";
                    foreach (var y in c)
                    {
                        if (y.id.Equals(x.idZamawiający))
                        {
                            nameAndId += y.Imie + " " + y.Miasto;
                            check.Add(nameAndId);
                        }

                    }
                }

            }
            listBox1.Items.AddRange(check.ToArray());



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nawigacja.PrevPage.Show();
            this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int y = listBox1.Items.Count;


            String[] split;



            for (int i = 0; i < y; i++)
                {
                listBox1.SetSelected(i, true);
                split = listBox1.SelectedItem.ToString().Split(' ');

                 int id = Int32.Parse(split[0]);
                    Plan_Pracy u = new Plan_Pracy(1, id);
                   db.Plan_Pracy.Add(u);


                  var s = db.Zamówienie.Where(j => j.id == id).FirstOrDefault();
                   if (s != null)
                 {
                     s.Status = "Oczekujacy";
                 }

                  db.SaveChanges();
                  listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                }
            
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
