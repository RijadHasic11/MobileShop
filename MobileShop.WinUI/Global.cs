using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShop.WinUI
{

    public class Global
    {
        public static Model.Models.Korisnici PrijavljeniKorisnik { get; set; }
       
        public static bool Admin { get; set; }
        public static bool Prodavac { get; set; }

        
    }
}
