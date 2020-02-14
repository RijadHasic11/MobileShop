using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Model.Requests;
using MobileShop.WebAPI.Services;

namespace MobileShop.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;
        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Models.Korisnici> Get([FromQuery]KorisniciSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public Model.Models.Korisnici Insert(KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Models.Korisnici Update(int id, [FromBody]KorisniciInsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Model.Models.Korisnici GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}