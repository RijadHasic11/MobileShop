using System;
using System.Collections.Generic;
using System.Text;

namespace MobileShop.Model.Requests
{
    public class ZahtjeviStavkeInsertRequest
    {
        public string Odgovor { get; set; }
        public int ZahtjevId { get; set; }
        public int KorisnikId { get; set; }
    }
}
