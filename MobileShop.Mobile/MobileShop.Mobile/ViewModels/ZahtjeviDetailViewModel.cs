using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileShop.Mobile.ViewModels
{
    public class ZahtjeviDetailViewModel:BaseViewModel
    {
        private readonly APIService _service = new APIService("ZahtjeviStavke");
        

      
        public Model.Models.Zahtjevi Zahtjev { get; set; }
        

        public ObservableCollection<Model.Models.ZahtjeviStavke> listastavki { get; set; } = new ObservableCollection<Model.Models.ZahtjeviStavke>();

        public string _opis = null;

        public string Opis
        {
            get { return _opis; }
            set { SetProperty(ref _opis, value); }
        }
       

        public async Task Init()
        {

            Opis = Zahtjev.Opis;
            List<Model.Models.ZahtjeviStavke> lista = await _service.Get<List<Model.Models.ZahtjeviStavke>>(null);
            listastavki.Clear();
            foreach (var item in lista)
            {
                if (item.ZahtjevId == Zahtjev.Id)
                { 
                    listastavki.Add(item);
                }
            }
        }
       
    }
}
