using Fabryka_Mebli_IO.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka_Mebli_IO.Scripts
{
    class Sprawdz
    {

    public static void CzyGotowe(ProdukcjaEntities2 db)
        {
            List<Zamówienie> zamowienie = db.Zamówienie.ToList();
            List<ListaMebli_Zamowienie> meble = db.ListaMebli_Zamowienie.ToList();

            foreach(var x in zamowienie)
            {
                if (!x.Status.Equals("Oczekujacy")&& !x.Status.Equals("Wysłany")&& !x.Status.Equals("Oczekujący Na Przyjecie"))
                {
                    Boolean pomoc = true;
                    foreach (var y in meble)
                    {
                        if (y.idListy.Equals(x.idLista) && !y.Status.Equals("Gotowy"))
                        {
                            pomoc = false;
                        }

                    }

                    if (pomoc == true)
                    {
                        x.Status = "Gotowe Do Wydania";
                    }
                    else
                    {
                        x.Status = "W Planie";
                    }

                }
            }
            
        }

        public static void CzyWyslane(ProdukcjaEntities2 db)
        {
            List<Zamówienie> zamowienie = db.Zamówienie.ToList();
            List<Plan_Pracy> plan = db.Plan_Pracy.ToList();
            List<ListaMebli_Zamowienie> meble = db.ListaMebli_Zamowienie.ToList();

            foreach (var x in zamowienie)
            {
                if(x.Status.Equals("Wysłany"))
                {
                    foreach(var y in plan)
                    {
                       if(x.id == y.idZamowienie)
                        {
                            db.Plan_Pracy.Remove(y);
                          
                        }
                    }
                }
            }

        }

    }
}
