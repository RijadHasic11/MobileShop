using MobileShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Services
{
    public interface ISkladistaService
    {
        List<Model.Models.Skladista> Get();

        Model.Models.Skladista GetById(int id);
    }
}
