using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileShop.Mobile.ViewModels
{
    public class ObavijestiViewModel
    {
        private readonly APIService _service = new APIService("Obavijesti");
        public ObavijestiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Model.Models.Obavijesti> ObavijestiList { get; set; } = new ObservableCollection<Model.Models.Obavijesti>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            List<Model.Models.Obavijesti> list =await _service.Get<List<Model.Models.Obavijesti>>(null);

            ObavijestiList.Clear();
            foreach(var item in list)
            {
                ObavijestiList.Add(item);
            }
        }

    }
}
