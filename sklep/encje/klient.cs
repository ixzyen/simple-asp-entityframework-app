using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sklep.encje
{
    public class klient
    {
        public int KlientId { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Telefon { get; set; }
        public ICollection<zamowienie> zamowienia { get; set; }
    }
}
