using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka_Mebli_IO.Scripts
{
    public class PracownikClass
    {
        int id;
        String imie;
        String nazwisko;
        int? zmiana;
        String stanowisko;

        public PracownikClass(int id,String imie,String nazwisko,int? zmiana,String stanowisko)
        {
            this.id=id;
            this.imie=imie;
            this.nazwisko=nazwisko;
            this.zmiana=zmiana;
            this.stanowisko=stanowisko;

        }

        public int getId()
        {
            return this.id;
        }
        public String getImie()
        {
            return this.imie;
        }

        public String getNazwisko()
        {
            return this.nazwisko;
        }
        public int? getZmiana()
        {
            return this.zmiana;
        }
        public String getStanowisko()
        {
            return this.stanowisko;
        }

       


    }
}
