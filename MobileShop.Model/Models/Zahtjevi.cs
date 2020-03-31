using System;
using System.Collections.Generic;
using System.Text;

namespace MobileShop.Model.Models
{
    public class Zahtjevi
    {
        public int Id { get; set; }
        public DateTime DatumZahtjeva { get; set; }
        public string Naslov { get; set; }
        public string Opis { get; set; }
        public int KlijentId { get; set; }


    }
}
