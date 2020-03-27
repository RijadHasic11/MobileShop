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
    public class UlogeController : ControllerBase
    {
        private readonly IUlogeService _service;

        public UlogeController(IUlogeService service)
        {
            _service = service;
        }
        
        [HttpGet]
        public List<Model.Models.Uloge> Get()
        {
            return _service.Get();
        }
        [HttpGet]
        [Route("ProvjeriAdmin/{UlogaId}")]
        public Model.Models.Uloge ProvjeriAdmin(int UlogaId)
        {
            return _service.ProvjeriAdmin(UlogaId);
        }
        [HttpGet]
        [Route("ProvjeriProdavac/{UlogaId}")]
        public Model.Models.Uloge ProvjeriProdavac(int UlogaId)
        {
            return _service.ProvjeriProdavac(UlogaId);
        }
    }
}