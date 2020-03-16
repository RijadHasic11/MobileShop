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
        public ArtikliDetailPage(Model.Models.Artikli artikal)
        {
            BindingContext = model = new ArtikliDetailViewModel
            {
                Artikal = artikal
            };

            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Uspjeh", "Uspjesno dodan artikal u korpu", "OK");
        }
    }
}