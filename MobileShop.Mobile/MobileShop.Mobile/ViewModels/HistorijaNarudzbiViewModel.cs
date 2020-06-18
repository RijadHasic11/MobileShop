using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileShop.Mobile.ViewModels
{
    public class HistorijaNarudzbiViewModel:BaseViewModel
    {
        private readonly APIService _service = new APIService("Narudzbe");

        public HistorijaNarudzbiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Model.Models.Narudzbe> ListaNarudzbi { get; set; } = new ObservableCollection<Model.Models.Narudzbe>();

        public ICommand InitCommand { get; set; }

        int _korisnikId = 0;
        public int KorisnikId
        {
            get { return _korisnikId; }
            set { SetProperty(ref _korisnikId, value); }
        }
        int _narudzbaId = 0;
        public int NarudzbaId
        {
            get { return _narudzbaId; }
            set { SetProperty(ref _narudzbaId, value); }
        }
        bool _izabran = false;
        public bool Izabran
        {
            get { return _izabran; }
            set { SetProperty(ref _izabran, value); }
        }
        public async Task Init()
        {
            List<Model.Models.Narudzbe> lista = await _service.Get<List<Model.Models.Narudzbe>>(null);
            ListaNarudzbi.Clear();
            foreach (var item in lista)
            {
                
                if (item.KlijentId == Global.PrijavljeniKlijent.KlijentId)
                {
                        ListaNarudzbi.Add(item);
                    
                }
            }


        }
    }
}
