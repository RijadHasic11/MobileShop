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
    public partial class NarudzbaPage : ContentPage
    {
        private NarudzbaViewModel model = null;
        public NarudzbaPage()
        {
            InitializeComponent();
            BindingContext = model = new NarudzbaViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();

        }

        private void Zakljuci_Clicked(object sender, EventArgs e)
        {

        }

        private void Otkazi_Clicked(object sender, EventArgs e)
        {
            model.NarudzbaList.Clear();
            CartService.Cart.Clear();
        }
    }
}