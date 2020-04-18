using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileShop.Mobile.ViewModels
{
    public class HistorijaZahtjevaViewModel:BaseViewModel
    {
        private readonly APIService _service = new APIService("Zahtjevi");

        public HistorijaZahtjevaViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Model.Models.Zahtjevi> ListaZahtjeva { get; set; } = new ObservableCollection<Model.Models.Zahtjevi>();

        public ICommand InitCommand { get; set; }


        public async Task Init()
        {
            List<Model.Models.Zahtjevi> lista = await _service.Get<List<Model.Models.Zahtjevi>>(null);
            ListaZahtjeva.Clear();
            foreach(var item in lista)
            {
                //if(item.KlijentId == Global.PrijavljeniKlijent.KlijentId)
                //{
                    ListaZahtjeva.Add(item);
                //}
            }


        }
    }
}
