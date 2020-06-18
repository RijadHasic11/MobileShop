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
    public partial class ArtikliPage : ContentPage
    {
        ArtikliViewModel model = null;
        private readonly APIService _karakteristikeService = new APIService("Karakteristike");
        private readonly APIService _artikliService = new APIService("Artikli");

        public ArtikliPage()
        {
            InitializeComponent();
            BindingContext = model = new ArtikliViewModel();

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var artikal = e.SelectedItem as Model.Models.Artikli;
            var karakteristike= await _karakteristikeService.GetById<Model.Models.Karakteristike>(artikal.KarakteristikeId);
            model.ArtikliList.Clear();
            await Navigation.PushAsync(new ArtikliDetailPage(artikal, karakteristike));
        }
        
    }
}