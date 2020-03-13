using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.WebAPI.Services;

namespace MobileShop.WebAPI.Controllers
{
    
    public class ProizvodjaciController : BaseController<Model.Models.Proizvodjaci,object>
    {
        public ProizvodjaciController(IService<Model.Models.Proizvodjaci,object> service) : base(service)
        {

        }

    }
}