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
    public partial class HistorijaNarudzbiDetailPage : ContentPage
    {
        private readonly APIService _service = new APIService("PoslanaNarudzba");
        HistorijaNarudzbiDetailViewModel model = null;
        public HistorijaNarudzbiDetailPage(Model.Models.Narudzbe narudzba)
        {
            InitializeComponent();
            BindingContext = model = new HistorijaNarudzbiDetailViewModel
            {
                Narudzba = narudzba
            };
            

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            if (model.Narudzba.KorisnikId > 1)
            {
                int NarudzbaPostoji = 0;
                var lista = await _service.Get<List<Model.Models.PoslanaNarudzba>>(null);
                foreach (var item in lista)
                {
                    if (item.NarudzbaId == model.Narudzba.NarudzbaId)
                    {
                        NarudzbaPostoji = model.Narudzba.NarudzbaId;
                    }
                }
                if (NarudzbaPostoji != 0)
                {
                    await DisplayAlert("Upozorenje", "Narudzba je zavrsena", "OK");
                }
                else
                {
                    PoslanaNarduzbaInsertRequest request = new PoslanaNarduzbaInsertRequest
                    {
                        Datum = DateTime.Now,
                        KlijentId = Global.PrijavljeniKlijent.KlijentId,
                        Poslano = false,
                        NarudzbaId = model.Narudzba.NarudzbaId,
                        KorisnikId = model.Narudzba.KorisnikId

                    };

                    await _service.Insert<Model.Models.PoslanaNarudzba>(request);
                    await DisplayAlert("Uspjeh", "Potvrdjeno da je narudzba primljena", "OK");
                }

            }

            else
            {
                await DisplayAlert("Upozorenje", "Ova narudzba nije zakljucena od strane prodavaca", "OK");
            }



        }
    }
}