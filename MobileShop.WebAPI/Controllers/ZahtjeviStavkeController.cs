using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.WebAPI.Services;

namespace MobileShop.WebAPI.Controllers
{
    
    public class ZahtjeviStavkeController : BaseCRUDController<Model.Models.ZahtjeviStavke,object,Model.Requests.ZahtjeviStavkeInsertRequest,object>
    {
        public ZahtjeviStavkeController(ICRUDService<Model.Models.ZahtjeviStavke,object,Model.Requests.ZahtjeviStavkeInsertRequest,object> service) : base(service)
        {

        }
    }
}