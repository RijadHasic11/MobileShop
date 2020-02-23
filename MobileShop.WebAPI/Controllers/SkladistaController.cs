using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Model.Models;
using MobileShop.WebAPI.Services;

namespace MobileShop.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkladistaController : ControllerBase
    {
        private readonly INabavkeService _service;

        public SkladistaController(INabavkeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Nabavke> Get()
        {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public Nabavke GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}