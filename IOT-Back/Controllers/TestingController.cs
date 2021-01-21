using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IOT_Back.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;

namespace IOT_Back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestingController : ControllerBase
    {
        private IHubContext<DevicesHub> _devicesHubContext;
        public TestingController(IHubContext<DevicesHub> devicesHubContext)
        {
            _devicesHubContext = devicesHubContext;
        }
        
        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            await _devicesHubContext.Clients.All.SendAsync("deviceData", new {name = "yolo"});
            return Ok();
        }
        
        [HttpGet("test")]
        public ActionResult<string> Test()
        {
            return Ok(new { Response = "Yolo"});
        }
    }
}
