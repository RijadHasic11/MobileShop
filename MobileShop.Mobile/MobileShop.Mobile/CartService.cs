using MobileShop.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileShop.Mobile
{
    public class CartService
    {

        public static Dictionary<int, ArtikliDetailViewModel> Cart = new Dictionary<int, ArtikliDetailViewModel>();
    }
}
