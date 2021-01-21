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

namespace Fabryka_Mebli_IO.Forms.StwórzPlanForm
{
    public partial class Stwórz_Plan : Form
    {
        ProdukcjaEntities2 db;
        int? id;
        public Stwórz_Plan(int? id)
        {

            
            InitializeComponent();
            db = new ProdukcjaEntities2();
            this.id = id;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] split;
            split=checkBoxList.SelectedItem.ToString().Split(' ');

            info x = new info(split[0]);
            x.Show();

          
        }

        private void powrótButt_Click(object sender, EventArgs e)
        {
            Nawigacja.PrevPage.Show();
            Nawigacja.PrevPage.Refresh();
            this.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Stwórz_Plan_Load(object sender, EventArgs e)
        {
            dodajButt.Enabled = false;
            usunButt.Enabled = false;
            stworzButt.Enabled = false;
            wyswietl.Enabled = false;

            if(id==1)
            {
                radioButton1.Enabled = true;
                radioButton2.Enabled = false;

            }else if(id==2)
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = true;
            }
            List<Zamówienie> zamowienia = db.Zamówienie.ToList();
            List<DaneZamawiajacego> c = db.DaneZamawiajacego.ToList();
            List<String> check = new List<String>();

            
           

            foreach(var x in zamowienia)
            {
                if (x.Status.Equals("Oczekujacy"))
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
            checkBoxList.Items.AddRange(check.ToArray());




        

           
        }

     

        private void dodajButt_Click(object sender, EventArgs e)
        {
            foreach (object x in checkBoxList.CheckedItems.OfType<String>().ToList())
            {
                listBox.Items.Add(x.ToString());
                checkBoxList.Items.Remove(x);
                
            }
            
            
        }

        private void checkBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checkBoxList.CheckedItems.Count>0)
            {
                dodajButt.Enabled = true;
                
            }
            else 
            {
                dodajButt.Enabled = false;
                
            }
            if(checkBoxList.SelectedIndex>-1)
            {
                wyswietl.Enabled = true;
            }
            else
            {
                wyswietl.Enabled = false;
            }
        }

        private void usunButt_Click(object sender, EventArgs e)
        {
            checkBoxList.Items.Add(
            listBox.SelectedItem.ToString());
            listBox.Items.RemoveAt(listBox.SelectedIndex);

        }

        private void stworzButt_Click(object sender, EventArgs e)
        {
            String[] split;
           
            int x = listBox.Items.Count;
          
            if (radioButton1.Checked)
            {
                for (int i = 0; i < x; i++)
                { 
                    listBox.SetSelected(i, true);
                    split = listBox.SelectedItem.ToString().Split(' ');

                    int id = Int32.Parse(split[0]);
                    Plan_Pracy u = new Plan_Pracy(1, id);
                    db.Plan_Pracy.Add(u);
                    

                 var s=db.Zamówienie.Where(j => j.id == id).FirstOrDefault();
                    if(s!=null)
                    {
                        s.Status = "W Planie";
                    }

                    db.SaveChanges();
                    listBox.Items.RemoveAt(listBox.SelectedIndex);
                    
                }
            }
            else if(radioButton2.Checked)
            {
                for (int i = 0; i < x; i++)
                {
                    listBox.SetSelected(i, true);
                    split = listBox.SelectedItem.ToString().Split(' ');

                    int id = Int32.Parse(split[0]);
                    Plan_Pracy u = new Plan_Pracy(2, id);
                    db.Plan_Pracy.Add(u);


                    var s = db.Zamówienie.Where(j => j.id == id).FirstOrDefault();
                    if (s != null)
                    {
                        s.Status = "W Planie";
                    }

                    db.SaveChanges();
                    listBox.Items.RemoveAt(listBox.SelectedIndex);
                }
            }


           
          
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex>-1)
            {
                usunButt.Enabled = true;
            }
            else
            {
                usunButt.Enabled = false;
            }

            if(listBox.Items.Count>0)
            {
               stworzButt.Enabled = true;
            }
            else
            {
                stworzButt.Enabled = false;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
