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
    public class NabavkeController : ControllerBase
    {
        private readonly INabavkeService _service;

        public NabavkeController(INabavkeService service)
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
        [HttpPost]
        public void Insert(NabavkeInsertRequest request)
        {
            _service.Insert(request);
        }
    }
}