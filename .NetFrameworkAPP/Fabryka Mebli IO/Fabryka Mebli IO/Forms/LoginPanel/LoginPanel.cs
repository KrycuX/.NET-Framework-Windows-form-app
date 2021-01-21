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
using Fabryka_Mebli_IO.Forms;
using Fabryka_Mebli_IO.Scripts;




namespace Fabryka_Mebli_IO
{
    public partial class Login_panel : Form
    {

        public static string stanowisko;
        public static string imie;
        public Login_panel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            string login = loginText.Text;
            string password = passwordText.Text;
            string stanowisko = comboBox.Text;
            Nawigacja.logForm = this;

            ProdukcjaEntities2 db = new ProdukcjaEntities2();

            var x = db.Pracownicy.Where(y=> y.Login.Equals(login)).FirstOrDefault();

            if(x!=null)
            {
                if (x.Haslo.Equals(password) && x.Stanowisko.Equals(stanowisko))
                {
                    PracownikClass ob = new PracownikClass(x.id,x.Imię,x.Nazwisko,x.Zmiany,x.Stanowisko);
                    imie = x.Imię.ToString();
                    Main_GUI m = new Main_GUI(ob);
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Niepoprawna Nazwa użytkownika Lub hasło");
                }
            }
            else
            {
                MessageBox.Show("Niepoprawna Nazwa użytkownika Lub hasło");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
