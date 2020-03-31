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
    
    public class ProizvodjaciController : BaseCRUDController<Model.Models.Proizvodjaci, object, ProizvodjaciInsertRequest, object>
    {
        public ProizvodjaciController(ICRUDService<Model.Models.Proizvodjaci, object, ProizvodjaciInsertRequest, object> service) : base(service)
        {

        }
    }
}