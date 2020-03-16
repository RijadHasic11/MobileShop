using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MobileShop.Mobile.ViewModels
{
    public class NarudzbaViewModel :BaseViewModel
    {
        public ObservableCollection<ArtikliDetailViewModel> NarudzbaList { get; set; } = new ObservableCollection<ArtikliDetailViewModel>();

       
        decimal _brojartikala = 0;

        public decimal BrojArtikala
        {
            get { return _brojartikala; }
            set { SetProperty(ref _brojartikala, value); }
        }
        decimal _iznos = 0;

        public decimal Iznos
        {
            get { return _iznos; }
            set { SetProperty(ref _iznos, value); }
        }
        public void Init()
        {
           
            
            NarudzbaList.Clear();


            foreach(var item in CartService.Cart.Values)
            {
                NarudzbaList.Add(item);
                Iznos = item.Kolicina * item.Artikal.Cijena;
               
            }

            BrojArtikala = NarudzbaList.Count();
            
        }
    }
}
