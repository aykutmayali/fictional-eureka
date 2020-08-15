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
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Ziyaretçi-1", "Ziyaretçi-2", "Ziyaretçi-3", "Ziyaretçi-4", "Betül", "Sanem", "Delal", "Göknur", "Hakkı", "Said","Ziyaretçi-5","Ziyaretçi-6","Ziyaretçi-7","Ziyaretçi-8",
            "Personel-1", "Personel-2", "Personel-3", "Personel-4", "Personel-5", "Personel-6"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        [HttpGet]
        public IEnumerable<Beacon> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 8).Select(index => new Beacon
            {
                Date = DateTime.Now.ToShortTimeString(),
                rssi1 = rng.Next(-50, -10),
                rssi2 = rng.Next(-100,-40),
                rssi3 = rng.Next(-80, -30),
                rssi4 = rng.Next(-50, -30),
                Mac = rng.Next(40100500,40101999),
                Name = Summaries[rng.Next(Summaries.Length)],
              //  Name = "Ziyaretci - "+rng.Next(1,10).ToString() ,
                Location = "Ofis - " + rng.Next(1,3).ToString()
            })
            .ToArray();
        }

    }
}
