using MobileShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Services
{
    public interface INabavkeService
    {
        List<Model.Models.Nabavke> Get();

        Model.Models.Nabavke GetById(int id);

        void Insert(NabavkeInsertRequest request);
    }
}
