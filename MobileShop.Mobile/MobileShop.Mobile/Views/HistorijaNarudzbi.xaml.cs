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
        private APIService service = new APIService("PoslanaNarudzba");
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

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (model.KorisnikId > 1)
            {
                int NarudzbaPostoji = 0;
                var lista = await service.Get<List<Model.Models.PoslanaNarudzba>>(null);
                foreach(var item in lista)
                {
                    if (item.NarudzbaId == model.NarudzbaId)
                    {
                        NarudzbaPostoji = model.NarudzbaId;
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
                        NarudzbaId = model.NarudzbaId,
                        KorisnikId = model.KorisnikId

                    };

                    await service.Insert<Model.Models.PoslanaNarudzba>(request);
                    await DisplayAlert("Uspjeh", "Potvrdjena narudzba", "OK");
                }

            }

            else
            {
                await DisplayAlert("Upozorenje", "Ova narudzba nije zakljucena od strane prodavaca", "OK");
            }

            

        }
    }
}