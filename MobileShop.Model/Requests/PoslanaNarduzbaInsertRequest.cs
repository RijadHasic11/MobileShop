using System;
using System.Collections.Generic;
using System.Text;

namespace MobileShop.Model.Requests
{
    public class PoslanaNarduzbaInsertRequest
    {
        public int KlijentId { get; set; }
        public int KorisnikId { get; set; }
        public bool Poslano { get; set; }
        public int NarudzbaId { get; set; }
        public DateTime Datum { get; set; }
    }
}
