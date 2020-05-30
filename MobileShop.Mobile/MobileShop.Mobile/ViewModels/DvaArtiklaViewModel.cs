using Flurl.Util;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MobileShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace MobileShop.Mobile.ViewModels
{

    class DvaArtiklaViewModel : BaseViewModel
    {
        private readonly APIService _karakteristikeService = new APIService("Karakteristike");
        private readonly APIService _artikliService = new APIService("Artikli");
        public DvaArtiklaViewModel()
        {

        }
        public Model.Models.Artikli Artikal1 { get; set; }
        public Model.Models.Artikli Artikal2 { get; set; }
        public Model.Models.Karakteristike Karakteristika1 { get; set; } = new Model.Models.Karakteristike();
        public Model.Models.Karakteristike Karakteristika2 { get; set; } = new Model.Models.Karakteristike();

        bool _NovoPrvi_IsVisible;
        public bool NovoPrvi_IsVisible
        {
            get { return _NovoPrvi_IsVisible; }
            set
            {
                SetProperty(ref _NovoPrvi_IsVisible, value);
            }
        }

        bool _PolovnoPrvi_IsVisible;
        public bool PolovnoPrvi_IsVisible
        {
            get { return _PolovnoPrvi_IsVisible; }
            set
            {
                SetProperty(ref _PolovnoPrvi_IsVisible, value);

            }
        }
        bool _NovoDrugi_IsVisible;
        public bool NovoDrugi_IsVisible
        {
            get { return _NovoDrugi_IsVisible; }
            set
            {
                SetProperty(ref _NovoDrugi_IsVisible, value);
            }
        }

        bool _PolovnoDrugi_IsVisible;
        public bool PolovnoDrugi_IsVisible
        {
            get { return _PolovnoDrugi_IsVisible; }
            set
            {
                SetProperty(ref _PolovnoDrugi_IsVisible, value);

            }
        }
    }
}