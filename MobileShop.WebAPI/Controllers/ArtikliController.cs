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
    public class ArtikliController : ControllerBase
    {
        private readonly IArtikliService _service;
        public ArtikliController(IArtikliService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Models.Artikli> Get()
        {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public Model.Models.Artikli GetById(int id)
        {
            return _service.GetById(id);
        }
        
    }
}