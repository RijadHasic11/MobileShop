using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.WebAPI.Services;

namespace MobileShop.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZahtjeviController : BaseController<Model.Models.Zahtjevi,object>
    {
        public ZahtjeviController(IService<Model.Models.Zahtjevi, object> service) : base(service)
        {

        }
    }
}