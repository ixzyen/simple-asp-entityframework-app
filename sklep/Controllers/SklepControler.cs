using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sklep.encje;

namespace sklep.Controllers
{
    [Route("api/zamowienie")]
    public class SklepControler : ControllerBase
    {
        private SklepContext sklep;
        public SklepControler(SklepContext sklep)
        {
            this.sklep = sklep;
        }
        public ActionResult<List<zamowienie>> Get()
        {
            var zamowienia = sklep.zamowienia.ToList();
            return zamowienia;
        }
    }
}
