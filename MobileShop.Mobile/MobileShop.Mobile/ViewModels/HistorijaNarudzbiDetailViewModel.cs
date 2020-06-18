using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileShop.Mobile.ViewModels
{
    public class HistorijaNarudzbiDetailViewModel :BaseViewModel
    {
        private readonly APIService _service = new APIService("StavkeNarudzbe");
        public HistorijaNarudzbiDetailViewModel()
        {
          
        }

        public Model.Models.Narudzbe Narudzba { get; set; }
        public ObservableCollection<Model.Models.StavkeNarudzbe> listastavki { get; set; } = new ObservableCollection<Model.Models.StavkeNarudzbe>();

       

        public async Task Init()
        {
            var lista =await _service.Get<List<Model.Models.StavkeNarudzbe>>(null);
            listastavki.Clear();
            foreach(var item in lista)
            {
                if (item.NarudzbaId == Narudzba.NarudzbaId)
                {
                    listastavki.Add(item);
                }
            }

        }
    }
   


}
