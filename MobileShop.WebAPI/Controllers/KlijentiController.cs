using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.WebAPI.Services;

namespace MobileShop.WebAPI.Controllers
{
   
    public class KlijentiController : BaseController<Model.Models.Klijenti,object>
    {
        public KlijentiController(IService<Model.Models.Klijenti,object> service):base(service)
        {

        }
    }
}