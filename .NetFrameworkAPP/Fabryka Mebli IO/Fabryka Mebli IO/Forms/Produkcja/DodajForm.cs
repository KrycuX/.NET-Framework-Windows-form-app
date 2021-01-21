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

namespace Fabryka_Mebli_IO.Forms.Produkcja
{
    public partial class DodajForm : Form
    {
        private ProdukcjaEntities2 db;
        private ListBox listBox1;
        private ListBox listBox2;
        private Form prev;
        private int idPrac;
        private Timer timer;

        public DodajForm(ProdukcjaEntities2 db, ListBox listBox1,ListBox listBox2,Form prev,int id,Timer timer)
        {
            InitializeComponent();
            this.db = db;
            this.listBox1 = listBox1;
            this.listBox2 = listBox2;
            this.prev = prev;
            this.idPrac = id;
            this.timer = timer;
        }

        private void takButt_Click(object sender, EventArgs e)
        {


            listBox2.Items.Add(listBox1.SelectedItem);

            string help = listBox1.SelectedItem.ToString();
            string[] split = help.Split(' ');
            int id = Int32.Parse(split[0]);
            var obj = db.ListaMebli_Zamowienie.Where(j => j.id == id).FirstOrDefault();



            obj.pracownikWykonujacy = idPrac;
            obj.Status = "W Realizacji";
            db.SaveChanges();


            
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            timer.Start();
            this.Close();
            prev.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void nieButt_Click(object sender, EventArgs e)
        {
            timer.Start();
            this.Close();
        }
    }
}
