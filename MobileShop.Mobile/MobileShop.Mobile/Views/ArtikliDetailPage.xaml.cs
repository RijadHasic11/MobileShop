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
    public partial class ArtikliDetailPage : ContentPage
    {
        private ArtikliDetailViewModel model = null;
        public ArtikliDetailPage(Model.Models.Artikli artikal, Model.Models.Karakteristike karakteristike)
        {
            BindingContext = model = new ArtikliDetailViewModel
            {
                Artikal = artikal,
                Karakteristika=karakteristike
            
            };
            InitializeComponent();
        }
       
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Uspjeh", "Uspjesno dodan artikal u korpu", "OK");
        }

        protected  override async void  OnAppearing()
        {
            
            base.OnAppearing();
            model.NaStanju_IsVisible = model.Artikal.Status.Value;
            model.NijeNaStanju_IsVisible = !model.Artikal.Status.Value;
            await model.Init();
        }
        //private async void UporediDvaArtikla(Model.Models.Artikli artikal1, Model.Models.Karakteristike karakteristika1, Model.Models.Artikli artikal2, Model.Models.Karakteristike karakteristika2)
        //{

        //    //await Navigation.PushAsync(new DvaArtiklaPage(artikal1, karakteristika1, artikal2, karakteristika2));
        //    //MainPage = new MainPage(DvaArtiklaPage(artikal1, karakteristika1, artikal2, karakteristika2));
        //    //Navigation.PushAsync(new DvaArtiklaPage(artikal1, karakteristika1, artikal2, karakteristika2));

        //}
     


    }
}