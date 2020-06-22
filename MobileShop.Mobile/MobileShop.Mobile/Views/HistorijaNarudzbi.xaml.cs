using MobileShop.Mobile.ViewModels;
using MobileShop.Model.Requests;
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
    public partial class HistorijaNarudzbi : ContentPage
    {
        private HistorijaNarudzbiViewModel model =null;
        
        public HistorijaNarudzbi()
        {
            InitializeComponent();
            BindingContext = model = new HistorijaNarudzbiViewModel();

        }
        protected async override void OnAppearing()
        {
           
            base.OnAppearing();
            await model.Init();
        }
           
        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Model.Models.Narudzbe;

            await Navigation.PushAsync(new HistorijaNarudzbiDetailPage(item));
        }
    }
}