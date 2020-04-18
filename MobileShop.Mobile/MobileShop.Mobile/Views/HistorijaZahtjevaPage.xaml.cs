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
    public partial class HistorijaZahtjevaPage : ContentPage
    {
        HistorijaZahtjevaViewModel model = null;
        public HistorijaZahtjevaPage()
        {
            InitializeComponent();
            BindingContext = model = new HistorijaZahtjevaViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Model.Models.Zahtjevi;
            await Navigation.PushAsync(new ZahtjeviDetailPage(item));
            
        }
    }
}