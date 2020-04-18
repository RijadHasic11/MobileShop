using MobileShop.Mobile.ViewModels;
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
    public partial class ZahtjeviDetailPage : ContentPage
    {
        private ZahtjeviDetailViewModel model = null;
        public ZahtjeviDetailPage(Model.Models.Zahtjevi item)
        {
            InitializeComponent();
            BindingContext = model = new ZahtjeviDetailViewModel()
            {
                Zahtjev = item
            };
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

    }
}