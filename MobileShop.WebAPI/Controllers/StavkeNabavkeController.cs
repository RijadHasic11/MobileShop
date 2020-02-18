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
    public class StavkeNabavkeController : ControllerBase
    {
        private readonly IStavkeNabavke _service;

        public StavkeNabavkeController(IStavkeNabavke service)
        {
            _service = service;
        }

        [HttpGet]
        public List<StavkeNabavke> Get()
        {
            return _service.Get();
        }
        
    }
}