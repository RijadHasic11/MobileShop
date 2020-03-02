using System;
using System.Collections.Generic;
using System.Text;

namespace MobileShop.Model.Models
{
    public class NarudzbeIzvjestaj
    {
        public string BrojNarudzbe { get; set; }
       
        public DateTime Datum { get; set; }
       
        public decimal IznosBezPdv { get; set; }
        public decimal IznosSaPdv { get; set; }
       
    }
}
