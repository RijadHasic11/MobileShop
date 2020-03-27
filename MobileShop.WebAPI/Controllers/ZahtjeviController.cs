using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Model.Requests;
using MobileShop.WebAPI.Services;

namespace MobileShop.WebAPI.Controllers
{
  
    public class ZahtjeviController : BaseCRUDController<Model.Models.Zahtjevi,ZahtjeviSearchRequest,ZahtjeviInsertRequest,object>
    {
        public ZahtjeviController(ICRUDService<Model.Models.Zahtjevi,ZahtjeviSearchRequest,ZahtjeviInsertRequest,object> service) : base(service)
        {

        }
    }
}