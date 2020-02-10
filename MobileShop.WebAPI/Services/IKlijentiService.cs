using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Services
{
    public interface IKlijentiService
    {
        List<Model.Models.Klijenti> Get();
    }
}
