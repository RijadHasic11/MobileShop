using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Model.Models;
using MobileShop.Model.Requests;
using MobileShop.WebAPI.Services;

namespace MobileShop.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DobavljaciController : ControllerBase
    {
        private readonly IDobavljaciService _service;

        public DobavljaciController(IDobavljaciService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Dobavljaci> Get([FromQuery]DobavljaciSearchRequest request)
        {
            var list = _service.Get(request);
            return list;
        }
        [HttpGet("{id}")]
        public Dobavljaci GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}