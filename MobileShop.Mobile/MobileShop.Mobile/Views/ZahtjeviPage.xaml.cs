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
    public partial class ZahtjeviPage : ContentPage
    {
        private ZahtjeviViewModel model = null;
        public ZahtjeviPage()
        {
            InitializeComponent();
            BindingContext = model = new ZahtjeviViewModel();

            
        }
        private void Button_Clicked(object sender, EventArgs e)
        {

            DisplayAlert("Uspjeh", "Uspjesno ste poslali novi zahtjev", "OK");
        }
    }
}