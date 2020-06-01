using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.WebAPI.Services;

namespace MobileShop.WebAPI.Controllers
{
    
    public class PoslanaNarudzbaController : BaseCRUDController<Model.Models.PoslanaNarudzba,object,Model.Requests.PoslanaNarduzbaInsertRequest,Model.Requests.PoslanaNarudzbaUpdateRequest>
    {
        public PoslanaNarudzbaController(ICRUDService<Model.Models.PoslanaNarudzba,object,Model.Requests.PoslanaNarduzbaInsertRequest,Model.Requests.PoslanaNarudzbaUpdateRequest> service) : base(service)
        {

        }
    }
}