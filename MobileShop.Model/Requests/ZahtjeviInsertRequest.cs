using System;
using System.Collections.Generic;
using System.Text;

namespace MobileShop.Model.Requests
{
    public class ZahtjeviInsertRequest
    {
        public DateTime DatumZahtjeva { get; set; }
        public string Naslov { get; set; }
        public string Opis { get; set; }
        public int KlijentId { get; set; }
    }
}
