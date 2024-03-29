﻿using MobileShop.Mobile.Helper;
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
    public partial class NarudzbaPage : ContentPage
    {
       
        private decimal PDV = 0.17M;
        private NarudzbaViewModel model = null;
        private APIService _service = new APIService("Narudzbe");
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

        private async void Zakljuci_Clicked(object sender, EventArgs e)
        {
            List<Model.Models.Narudzbe> list =await _service.Get<List<Model.Models.Narudzbe>>(null);
            int najveci = int.MinValue;
            foreach (var item in list)
            {
                
                if (item.NarudzbaId > najveci)
                {
                    najveci = item.NarudzbaId;
                }
            }
            int BrojNarudzbe = najveci + 1;
            
          
            string neki = BrojNarudzbeHelper.GenerisiBrojNarudzbe(BrojNarudzbe);
            

            NarudzbeInsertRequest request = new NarudzbeInsertRequest();

            request.BrojNarudzbe = neki;
            request.Datum = DateTime.Now;
            request.KlijentId = Global.PrijavljeniKlijent.KlijentId;
            request.Status = true;
            request.Otkazano = false;
            request.SkladisteId = 1;
            request.KorisnikId = 1;

            foreach(var item in model.NarudzbaList)
            {
                StavkeNarudzbeInsertRequest stavka = new StavkeNarudzbeInsertRequest();

                stavka.ArtikalId = item.Artikal.ArtikalId;
                stavka.Cijena = item.Artikal.Cijena;
                stavka.Kolicina = item.Kolicina;
                stavka.Popust = 0;

                
                request.IznosBezPdv += stavka.Cijena * stavka.Kolicina;
                request.IznosSaPdv = request.IznosBezPdv + request.IznosBezPdv * PDV;


                request.stavke.Add(stavka);
            }

            

            await _service.Insert<Model.Models.Narudzbe>(request);
           

            await DisplayAlert("Uspjeh", "Uspjesno ste napravili novu narudzbu", "OK");
            model.NarudzbaList.Clear();
            CartService.Cart.Clear();
            lblBrojArtikala.Text = "Broj artikala: 0";
            lblIznos.Text = "Iznos: 0 KM";

            await Navigation.PushAsync(new StripePaymentGatwayPage(model.Iznos));
           
        }

        private void Otkazi_Clicked(object sender, EventArgs e)
        {
            model.NarudzbaList.Clear();
            CartService.Cart.Clear();
            lblBrojArtikala.Text = "Broj artikala: 0";
            lblIznos.Text = "Iznos: 0 KM";

        }
    }
}