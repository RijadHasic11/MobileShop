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
        public ArtikliPage()
        {
            InitializeComponent();
            BindingContext = model = new ArtikliViewModel();
        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();
            await model.Init();
        }
    }
}