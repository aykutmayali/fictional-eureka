using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApp_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GatewayController : Controller
    {
        private readonly ILogger<GatewayController> _logger;

        public GatewayController(ILogger<GatewayController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Gateway> Get()
        {
            List<Gateway> lst = new List<Gateway>()
            {
                new Gateway{ID = 1001, Mac= 40120800,Name="GW1",Location="Ofis - 1"},
                new Gateway{ID = 1002, Mac= 40120801,Name="GW2",Location="Ofis - 1"},
                new Gateway{ID = 1003, Mac= 40120802,Name="GW3",Location="Ofis - 1"},
                new Gateway{ID = 1004, Mac= 40120803,Name="GW4",Location="Ofis - 1"},
                new Gateway{ID = 1005, Mac= 40120804,Name="GW5",Location="Ofis - 2"},
                new Gateway{ID = 1006, Mac= 40120805,Name="GW6",Location="Ofis - 2"},
                new Gateway{ID = 1007, Mac= 40120806,Name="GW7",Location="Ofis - 2"},
                new Gateway{ID = 1008, Mac= 40120807,Name="GW8",Location="Ofis - 2"},
            };
            return lst;
        }
    }
}

//var rng = new Random();
//return Enumerable.Range(1, 6).Select(index => new Gateway
//{
//    Date = DateTime.Now.ToShortTimeString(),
//    rssi1 = rng.Next(-50, -10),
//    rssi2 = rng.Next(-100, -40),
//    rssi3 = rng.Next(-80, -30),
//    rssi4 = rng.Next(-50, -30),
//    Mac = rng.Next(40100500, 40101999),
//    Name = Summaries[rng.Next(Summaries.Length)],
//    //  Name = "Ziyaretci - "+rng.Next(1,10).ToString() ,
//    Location = "Ofis - " + rng.Next(1, 3).ToString()
//})
//.ToArray();