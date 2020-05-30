using MobileShop.Model.Requests;
using MobileShop.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Controllers
{
    public class OcjeneController : BaseCRUDController<Model.Models.Ocjene, object, Model.Requests.OcjeneInsertRequest, object>
    {
        public OcjeneController(ICRUDService<Model.Models.Ocjene, object, OcjeneInsertRequest, object> service) : base(service)
        {

        }
    }
}
