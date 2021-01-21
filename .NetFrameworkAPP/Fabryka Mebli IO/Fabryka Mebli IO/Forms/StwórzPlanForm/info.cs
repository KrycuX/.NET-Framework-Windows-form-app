using Fabryka_Mebli_IO.Databases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabryka_Mebli_IO.Forms.StwórzPlanForm
{
    public partial class info : Form
    {
        ProdukcjaEntities2 db;
        int id;
        public info(String id)
        {
            InitializeComponent();
            this.id = Int32.Parse(id);
            db = new ProdukcjaEntities2();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void info_Load(object sender, EventArgs e)
        {
            List<ListaMebli_Zamowienie> list = db.ListaMebli_Zamowienie.ToList();
            List<Zamówienie> zamowienie = db.Zamówienie.ToList();
            

            listView1.Columns.Add("Nazwa");
            listView1.Columns.Add("Kolor");
            listView1.Columns.Add("Kod Produktu");
         
            foreach (var x in zamowienie)
            {
                if(x.id.Equals(id))
                {
                    foreach(var y in list)
                    {
                        if(y.idListy.Equals(x.idLista))
                        {
                          
                            ListViewItem listViewItem = new ListViewItem(y.Mebel.Nazwa.ToString());
                            //listViewItem.SubItems.Add(y.Mebel.Nazwa);
                            listViewItem.SubItems.Add(y.Kolor);
                            listViewItem.SubItems.Add(y.Mebel.Kod_Produktu);
                 
                            listView1.Items.Add(listViewItem);

                        }

                    }
                }
                
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
