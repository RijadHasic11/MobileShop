using Flurl.Util;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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
    
    class DvaArtiklaViewModel
    {
        private readonly APIService _karakteristikeService = new APIService("Karakteristike");
        private readonly APIService _artikliService = new APIService("Artikli");
        public DvaArtiklaViewModel()
        {

        }
        public Model.Models.Artikli Artikal1 { get; set; }
        public Model.Models.Artikli Artikal2 { get; set; }
        public Model.Models.Karakteristike Karakteristika1 { get; set; } = new Model.Models.Karakteristike();
        public Model.Models.Karakteristike Karakteristika2 { get; set; } = new Model.Models.Karakteristike();
    }
    
}
