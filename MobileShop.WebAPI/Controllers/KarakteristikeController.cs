using MobileShop.Model.Requests;
using MobileShop.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.WebAPI.Controllers
{

    public class KarakteristikeController : BaseCRUDController<Model.Models.Karakteristike, object, KarakteristikeInsertRequest, object>
    {
        public KarakteristikeController(ICRUDService<Model.Models.Karakteristike, object, KarakteristikeInsertRequest, object> service) : base(service)
        {

        }
    }
}
