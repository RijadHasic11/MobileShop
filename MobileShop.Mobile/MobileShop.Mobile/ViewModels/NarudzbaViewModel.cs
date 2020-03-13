using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MobileShop.Mobile.ViewModels
{
    public class NarudzbaViewModel
    {
        public ObservableCollection<ArtikliDetailViewModel> NarudzbaList { get; set; } = new ObservableCollection<ArtikliDetailViewModel>();

        public void Init()
        {
            NarudzbaList.Clear();

            foreach(var item in CartService.Cart.Values)
            {
                NarudzbaList.Add(item);
            }
        }
    }
}
