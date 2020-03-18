using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileShop.Mobile.ViewModels
{
    public class ArtikliDetailViewModel :BaseViewModel
    {
        public ArtikliDetailViewModel()
        {
            PovecajKolicinuCommand = new Command(() => Kolicina += 1);
            NaruciCommand = new Command(Naruci);
        }
        public Model.Models.Artikli Artikal { get; set; }

        int _kolicina = 0;

        public int Kolicina
        {
            get { return _kolicina; }
            set { SetProperty(ref _kolicina, value); }
        }

        public ICommand PovecajKolicinuCommand { get; set; }

        public ICommand NaruciCommand { get; set; }

        private void Naruci()
        {
            if (CartService.Cart.ContainsKey(Artikal.ArtikalId))
            {
                CartService.Cart.Remove(Artikal.ArtikalId);
            }
            CartService.Cart.Add(Artikal.ArtikalId, this);
            
            
        }
    }
}
