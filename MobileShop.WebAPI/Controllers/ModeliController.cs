using MobileShop.Model.Requests;
using MobileShop.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Controllers
{

    public class ModeliController : BaseCRUDController<Model.Models.Modeli, object, ModeliInsertRequest, object>
    {
        public ModeliController(ICRUDService<Model.Models.Modeli, object, ModeliInsertRequest, object> service) : base(service)
        {

        }
    }
}
