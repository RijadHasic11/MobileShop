using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Services
{
    public interface IStavkeNarudzbeService
    {

        List<Model.Models.StavkeNarudzbe> Get();

        Model.Models.StavkeNarudzbe GetById(int id);
    }
}
