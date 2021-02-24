using sklep.encje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sklep
{
    public class dodaj
    {
        private SklepContext sklepContext;
        public dodaj(SklepContext sklepContext)
        {
            this.sklepContext = sklepContext;
        }
        public void DodajDane()
        {
            if(sklepContext.Database.CanConnect())
            {
                if(!sklepContext.zamowienia.Any())
                {
                    WstawRekordy();
                }
            }
        }
        private void WstawRekordy()
        {
            var Zamowienia1 = new List<zamowienie>
            {
            new zamowienie{Klient=new klient{Imie="Jan",Nazwisko="Kowalski",Telefon="31231"}, produkt=new produkt{Nazwa="gtx",Kategoria="elektronika"} }
            };
            sklepContext.AddRange(Zamowienia1);
            sklepContext.SaveChanges();
        }
    }
}
