using MobileShop.Mobile.ViewModels;
using MobileShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileShop.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UporediDvaArtiklaPage : ContentPage
    {
        private DvaArtiklaViewModel model = null;
        private Artikli artikal1;
        private Karakteristike karakteristika1;
        private Artikli artikal2;
        private Task<Karakteristike> karakteristika2;

        public UporediDvaArtiklaPage(Model.Models.Artikli artikal1, Model.Models.Karakteristike karakteristike1, Model.Models.Artikli artikal2, Model.Models.Karakteristike karakteristike2)
        {
            BindingContext = model = new DvaArtiklaViewModel
            {
                Artikal1 = artikal1,
                Karakteristika1 = karakteristike1,
                Artikal2 = artikal2,
                Karakteristika2 = karakteristike2

            };
            InitializeComponent();
        }
        protected override void OnAppearing()
        {

            base.OnAppearing();
            model.NovoPrvi_IsVisible = model.Karakteristika1.Novo;
            model.PolovnoPrvi_IsVisible = !model.Karakteristika1.Novo;
            model.NovoDrugi_IsVisible = model.Karakteristika2.Novo;
            model.PolovnoDrugi_IsVisible = !model.Karakteristika2.Novo;
        }
    }
}