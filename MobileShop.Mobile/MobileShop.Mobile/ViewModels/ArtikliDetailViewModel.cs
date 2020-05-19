using Flurl.Util;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MobileShop.Mobile.Views;
using MobileShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace MobileShop.Mobile.ViewModels
{
    public class ArtikliDetailViewModel :BaseViewModel
    {
        private readonly APIService _karakteristikeService = new APIService("Karakteristike");
        private readonly APIService _artikliService = new APIService("Artikli");
        public ArtikliDetailViewModel()
        {
            PovecajKolicinuCommand = new Command(() => Kolicina += 1);
            SmanjiKolicinuCommand = new Command(() => Kolicina -= 1);
            UporediDvaArtiklaCommand = new Command(async () =>
            {
                if(SelectedArtikal==null)
                {
                    await App.Current.MainPage.DisplayAlert("Not Found selected article", "", "OK");
                }
                else
                {
                    UcitajKaratkeristiku();
                 
                    await ((App.Current.MainPage as MasterDetailPage).Detail as NavigationPage)
                    .Navigation.PushAsync(new UporediDvaArtiklaPage(Artikal, Karakteristika, SelectedArtikal, SelectedKarakteristika));
                }
                
            });
            NaruciCommand = new Command(Naruci);
            InitCommand = new Command(async () => await  Init());

        }
        public Model.Models.Artikli Artikal { get; set; }
        public Model.Models.Karakteristike Karakteristika { get; set; } = new Model.Models.Karakteristike();
        public Model.Models.Karakteristike SelectedKarakteristika { get; set; } = new Model.Models.Karakteristike();
        public ObservableCollection<Model.Models.Artikli> ArtikliList { get; set; } = new ObservableCollection<Model.Models.Artikli>();

        public async Task Init()
        {
            Karakteristika =  await _karakteristikeService.GetById<Model.Models.Karakteristike>(Artikal.KarakteristikeId);
          
            var listaartikala = await _artikliService.Get<List<Model.Models.Artikli>>(null);
           
            if (ArtikliList.Count == 0)
            {
                foreach (var item in listaartikala)
                {
                    ArtikliList.Add(item);
                }
            }
  
           
        }

        int _kolicina = 0;

        public int Kolicina
        {
            get { return _kolicina; }
            set { SetProperty(ref _kolicina, value); }
        }

        public ICommand PovecajKolicinuCommand { get; set; }
        public ICommand SmanjiKolicinuCommand { get; set; }
        public ICommand UporediDvaArtiklaCommand { get; set; }
        

        public ICommand NaruciCommand { get; set; }
        public ICommand InitCommand { get; set; }
        private async void UcitajKaratkeristiku()
        {
                SelectedKarakteristika= await _karakteristikeService.GetById<Model.Models.Karakteristike>(_SelectedArtikal.KarakteristikeId);  
        }
        private void Naruci()
        {
            if (CartService.Cart.ContainsKey(Artikal.ArtikalId))
            {
                CartService.Cart.Remove(Artikal.ArtikalId);
            }
            CartService.Cart.Add(Artikal.ArtikalId, this);

        }
     
  

        bool _NaStanju_IsVisible;
        public bool NaStanju_IsVisible
        {
            get { return _NaStanju_IsVisible; }
            set
            {
                SetProperty(ref _NaStanju_IsVisible, value);
            }
        }

        bool _NijeNaStanju_IsVisible;
        public bool NijeNaStanju_IsVisible
        {
            get { return _NijeNaStanju_IsVisible; }
            set
            {
                SetProperty(ref _NijeNaStanju_IsVisible, value);

            }
        }
        Model.Models.Artikli _SelectedArtikal = null;
        public Model.Models.Artikli SelectedArtikal
        {
            get { return _SelectedArtikal; }
            set
            {
                SetProperty(ref _SelectedArtikal, value);

                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }



    }
}
