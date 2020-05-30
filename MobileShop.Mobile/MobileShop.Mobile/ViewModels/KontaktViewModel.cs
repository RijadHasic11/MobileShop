using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace MobileShop.Mobile.ViewModels
{
    public class KontaktViewModel : BaseViewModel
    {
        public KontaktViewModel()
        {
            Title = "Kontakt";

            //OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

       // public ICommand OpenWebCommand { get; }
    }
}