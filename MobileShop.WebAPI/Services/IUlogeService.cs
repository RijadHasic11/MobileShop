using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Services
{
    public interface IUlogeService
    {
        List<Model.Models.Uloge> Get();

        Model.Models.Uloge ProvjeriAdmin(int UlogaId);
      
    }
}
