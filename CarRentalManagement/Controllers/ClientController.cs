using CarRentalLogic.Logics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagementApi.Controllers
{
    [Route("api/clients")]
    [ApiController]
    public class ClientController : ControllerBase
    {

        public ClientLogic clientLogic { get; set; } = new ClientLogic();

        [HttpGet]
        public IActionResult GetClients([FromQuery] string name, [FromQuery] string country)
        {
            return Ok(clientLogic.GetClientsByNameAndCountry(name, country));
        }
    }
}
