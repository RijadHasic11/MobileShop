using MobileShop.Model.Requests;
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
        private readonly APIService _proizvodjaciService = new APIService("Proizvodjaci");
       
        
        public ArtikliViewModel()
        {
            InitCommand = new Command(async () => await  Init());
        }
        public ObservableCollection<Model.Models.Artikli> ArtikliList { get; set; } = new ObservableCollection<Model.Models.Artikli>();
        public ObservableCollection<Model.Models.Proizvodjaci> ProizvodjaciList { get; set; } = new ObservableCollection<Model.Models.Proizvodjaci>();

      



        Model.Models.Proizvodjaci _SelectedProizvodjac = null;
        public Model.Models.Proizvodjaci SelectedProizvodjac
        {
            get { return _SelectedProizvodjac; }
            set { SetProperty(ref _SelectedProizvodjac, value);

                if (value != null)
                {

                    InitCommand.Execute(null);
                }

            }
        }
        public ICommand InitCommand { get; set; }
       
       

        public async Task Init()
        {
            var listaproizvodjaci = await _proizvodjaciService.Get<List<Model.Models.Proizvodjaci>>(null);

            if (ProizvodjaciList.Count == 0)
            {
                foreach(var item in listaproizvodjaci)
                {
                    ProizvodjaciList.Add(item);
                }
            }
            if (SelectedProizvodjac != null)
            {
                ArtikliSearchRequest search = new ArtikliSearchRequest();
                search.ProizvodjacId = SelectedProizvodjac.ProizvodjacId;

                List<Model.Models.Artikli> lista = await _artikliService.Get<List<Model.Models.Artikli>>(search);

                ArtikliList.Clear();


                foreach (var item in lista)
                {
                    ArtikliList.Add(item);
                }
            }
            else
            {
                List<Model.Models.Artikli> lista = await _artikliService.Get<List<Model.Models.Artikli>>(null);

                ArtikliList.Clear();


                foreach (var item in lista)
                {
                    ArtikliList.Add(item);
                }
            }

            
        }
       
    }
}
