using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.WebAPI.Services;
using MobileShop.Model.Requests;

namespace MobileShop.WebAPI.Controllers
{
    
    public class ObavijestiController : BaseCRUDController<Model.Models.Obavijesti,ObavijestiSearchRequest,ObavijestInsertRequest,ObavijestInsertRequest>
    {
        public ObavijestiController(ICRUDService<Model.Models.Obavijesti, ObavijestiSearchRequest,ObavijestInsertRequest, ObavijestInsertRequest> service) : base(service)
        {

        }

    }
}