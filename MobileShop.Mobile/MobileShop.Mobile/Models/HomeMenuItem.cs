using System;
using System.Collections.Generic;
using System.Text;

namespace MobileShop.Mobile.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Artikli,
        Narudzba,
        Placanje,
        Obavijesti,
        Zahtjevi,
        HistorijaZahtjeva
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
