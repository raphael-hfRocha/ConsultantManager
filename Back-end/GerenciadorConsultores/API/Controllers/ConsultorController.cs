using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConsultorController : ControllerBase
    {
        private readonly ConsultorService _consultorService;

        public ConsultorController(ConsultorService consultorService)
        {
            _consultorService = consultorService;
        }

            /*
        [HttpGet]
        public async Task<ActionResult<List<Consultor>>> getAllConsultores()
        {
             try
            {
                var consultores = 
            }
            catch (Exception ex)
            {

            }
        }
            */
    }
}
