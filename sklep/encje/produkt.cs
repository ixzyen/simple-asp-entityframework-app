using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sklep.encje
{
    public class produkt
    {
        public int ProduktId { get; set; }
        public string Nazwa { get; set; }
        public string Kategoria { get; set; }
        public  zamowienie zamowienie { get; set; }
    }
}
