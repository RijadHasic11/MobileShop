using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using MobileShop.Mobile.Models;

namespace MobileShop.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.Artikli:
                        MenuPages.Add(id, new NavigationPage(new ArtikliPage()));
                        break;
                    case (int)MenuItemType.Narudzba:
                        MenuPages.Add(id, new NavigationPage(new NarudzbaPage()));
                        break;
                    case (int)MenuItemType.Obavijesti:
                        MenuPages.Add(id, new NavigationPage(new ObavijestiPage()));
                        break;
                    case (int)MenuItemType.Zahtjevi:
                        MenuPages.Add(id, new NavigationPage(new ZahtjeviPage()));
                        break;
                    case (int)MenuItemType.HistorijaZahtjeva:
                        MenuPages.Add(id, new NavigationPage(new HistorijaZahtjevaPage()));
                        break;
                    case (int)MenuItemType.HistorijaNarudzbi:
                        MenuPages.Add(id, new NavigationPage(new HistorijaNarudzbi()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}