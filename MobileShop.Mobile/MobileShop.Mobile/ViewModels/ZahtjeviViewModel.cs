using MobileShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileShop.Mobile.ViewModels
{
    public class ZahtjeviViewModel:BaseViewModel
    {
        private readonly APIService _service = new APIService("Zahtjevi");

        public ZahtjeviViewModel()
        {
            PosaljiCommand = new Command(async() => await Posalji());
        }
        string _naslov = null;

        public string Naslov
        {
            get { return _naslov; }
            set { SetProperty(ref _naslov, value); }
        }

        string _opis = null;
        
        public string Opis
        {
            get { return _opis; }
            set { SetProperty(ref _opis, value); }
        }

        public ICommand PosaljiCommand { get; set; }

        public async Task Posalji()
        {
            ZahtjeviInsertRequest request = new ZahtjeviInsertRequest();

            request.DatumZahtjeva = DateTime.Now;
            request.KlijentId = 1;
            request.Naslov = Naslov;
            request.Opis = Opis;

            await _service.Insert<Model.Models.Zahtjevi>(request);


        }



    }
}
