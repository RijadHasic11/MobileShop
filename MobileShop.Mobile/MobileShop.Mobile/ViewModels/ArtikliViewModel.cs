using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileShop.Mobile.ViewModels
{
    public class ArtikliViewModel:BaseViewModel
    {
        private readonly APIService _artikliService = new APIService("Artikli");
        public ArtikliViewModel()
        {
            InitCommand = new Command(async () => await  Init());
        }
        public ObservableCollection<Model.Models.Artikli> ArtikliList { get; set; } = new ObservableCollection<Model.Models.Artikli>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            List<Model.Models.Artikli> lista =await _artikliService.Get<List<Model.Models.Artikli>>(null);
            ArtikliList.Clear();

            foreach (var item in lista)
            {
                

                ArtikliList.Add(item);
            }
        }
    }
}
