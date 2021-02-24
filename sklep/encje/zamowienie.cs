using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sklep.encje
{
    public class zamowienie
    {
        public int ZamowienieId { get; set; }
        public klient Klient { get; set; }
        public  produkt produkt { get; set; }
        public int ProduktFK { get; set; }
        public int KlientFK { get; set; }
    }
}
