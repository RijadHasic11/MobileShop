using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.WebAPI.Services;

namespace MobileShop.WebAPI.Controllers
{
    
    public class ObavijestiController : BaseCRUDController<Model.Models.Obavijesti,Model.Requests.ObavijestiSearchRequest,object,object>
    {
        public ObavijestiController(ICRUDService<Model.Models.Obavijesti, Model.Requests.ObavijestiSearchRequest,object, object> service) : base(service)
        {

        }

    }
}