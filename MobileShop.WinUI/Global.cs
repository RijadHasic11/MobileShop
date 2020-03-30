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
        //public static APIService _service = new APIService("Uloge");
        public static bool Admin { get; set; }
        public static bool Prodavac { get; set; }

        //public async static Task<Model.Models.Uloge> ProvjeriAdmin()
        //{
        //    int ulogaId = 0;
        //    foreach(var item in PrijavljeniKorisnik.KorisniciUloge)
        //    {
        //        ulogaId = item.UlogaId;
        //    }

        //    Model.Models.Uloge uloga = await _service.ProvjeriAdmin<Model.Models.Uloge>(ulogaId);


        //    if (uloga != null)
        //    {
        //        return uloga;
        //    }

        //    return null;

        //}
        //public async static Task<Model.Models.Uloge> ProvjeriProdavac()
        //{
        //    int ulogaId = 0;
        //    foreach (var item in PrijavljeniKorisnik.KorisniciUloge)
        //    {
        //        ulogaId = item.UlogaId;
        //    }

        //    Model.Models.Uloge uloga = await _service.ProvjeriProdavac<Model.Models.Uloge>(ulogaId);


        //    if (uloga != null)
        //    {
        //        return uloga;
        //    }

        //    return null;

        //}
    }
}
