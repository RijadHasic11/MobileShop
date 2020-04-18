using MobileShop.Mobile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileShop.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse" },
                new HomeMenuItem {Id = MenuItemType.About, Title="About" },
                new HomeMenuItem {Id = MenuItemType.Artikli, Title="Artikli" },
                new HomeMenuItem{Id=MenuItemType.Narudzba,Title="Narudzba"},
                new HomeMenuItem{Id=MenuItemType.Placanje,Title="Placanje"},
                new HomeMenuItem{Id=MenuItemType.Obavijesti,Title="Obavijesti"},
                new HomeMenuItem{Id=MenuItemType.Zahtjevi,Title="Novi zahtjev"},
                new HomeMenuItem{Id=MenuItemType.HistorijaZahtjeva,Title="Historija zahtjeva"}

            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}