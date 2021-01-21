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
using Fabryka_Mebli_IO.Forms.MagazynForm.WydanieZewForm;
using Fabryka_Mebli_IO.Scripts;
namespace Fabryka_Mebli_IO.Forms.WydanieZewForm
{
    public partial class WZ : Form
    {
        PracownikClass pracownik;
        private Form prevPage;
        private List<String> list;
        public WZ(Form prevPage, List<String> list,PracownikClass pracownik)
        {
            InitializeComponent();
            this.prevPage = prevPage;
            this.list = list;
            this.pracownik = pracownik;
        }

     

        private void Wyślij_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            zapytanie z = new zapytanie(this,prevPage,list);
            z.Show();
        }

        private void Powrót_Click(object sender, EventArgs e)
        {
           prevPage.Enabled=true;
          
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WZ_Load(object sender, EventArgs e)
        {
            imieText.Enabled = false;
            nazwiskoText.Enabled = false;
            zmianaText.Enabled = false;
            dateTimePicker2.Enabled = false;
            miastoBox.Enabled = false;
            UlicaBox.Enabled = false;
            Wyślij.Enabled = false;
            imieText.Text=pracownik.getImie();
            nazwiskoText.Text = pracownik.getNazwisko();
            zmianaText.Text = pracownik.getZmiana().ToString();
            dateTimePicker2.Value = DateTime.Now;

            listBox1.Items.AddRange(list.ToArray());


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            miastoBox.Text = "Węgrów";
            UlicaBox.Text = "Kościuszki";
            Wyślij.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            miastoBox.Text = "Siedlce";
            UlicaBox.Text = "Popiełuszki";
            Wyślij.Enabled = true;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
