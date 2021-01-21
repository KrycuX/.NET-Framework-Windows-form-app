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
    public partial class Usterka : Form
    {
        private ProdukcjaEntities2 db;
        private ListBox listBox2;
        private Form prev;
        private PracownikClass pracownik;
        private Timer timer;
        public Usterka(ProdukcjaEntities2 db, ListBox listBox, Form prev, PracownikClass pracownik,Timer timer)
        {
            InitializeComponent();
            this.db = db;
            this.listBox2 = listBox;
            this.prev = prev;
            this.pracownik = pracownik;
            this.timer = timer;
        }

        private void Usterka_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string help = listBox2.SelectedItem.ToString();
            string[] split = help.Split(' ');
            int id = Int32.Parse(split[0]);
            var obj = db.ListaMebli_Zamowienie.Where(j => j.id == id).FirstOrDefault();

            List<Zamówienie> zam = db.Zamówienie.ToList();

            obj.Status = "Usterka";

            db.SaveChanges();

            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            timer.Start();
            this.Close();
            prev.Enabled = true;
        }
    }
}
