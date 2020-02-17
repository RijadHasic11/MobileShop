using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.WebAPI.Services;

namespace MobileShop.WebAPI.Controllers
{
    
    public class UlogeController : BaseController<Model.Models.Uloge,object>
    {
        public UlogeController(IService<Model.Models.Uloge,object> service):base(service)
        {

        }
    }
}