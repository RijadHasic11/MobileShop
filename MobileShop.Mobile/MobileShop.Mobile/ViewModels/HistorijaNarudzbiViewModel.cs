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
