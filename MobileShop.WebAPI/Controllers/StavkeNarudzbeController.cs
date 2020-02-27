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
    public class StavkeNarudzbeController : ControllerBase
    {
        private readonly IStavkeNarudzbeService _service;
        public StavkeNarudzbeController(IStavkeNarudzbeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Models.StavkeNarudzbe> Get()
        {
           return _service.Get();
        }
        [HttpGet("{id}")]
        public Model.Models.StavkeNarudzbe GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}