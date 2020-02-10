using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobileShop.Model.Database
{
    public  class Skladista
    {
        public Skladista()
        {
            Narudzba = new HashSet<Narudzba>();
            Nabavka = new HashSet<Nabavka>();
        }

        [Key]
        public int SkladisteId { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Opis { get; set; }

        public ICollection<Narudzba> Narudzba { get; set; }
        public ICollection<Nabavka> Nabavka { get; set; }
    }
}
