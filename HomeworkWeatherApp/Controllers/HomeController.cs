using HomeworkWeatherApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeworkWeatherApp.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            List<CityWeather> cityWeathers = new List<CityWeather>()
            {
              new CityWeather(){CityUniqueCode = "LDN", CityName = "London",
                  DateAndTime = DateTime.Parse("2030-01-01 8:00"), TemperatureFahrenheit = 33},
              new CityWeather(){CityUniqueCode = "NYC", CityName = "NewYork",
                  DateAndTime = DateTime.Parse("2030-01-01 3:00"),  TemperatureFahrenheit = 60},
              new CityWeather(){CityUniqueCode = "PAR", CityName = "Paris", 
                  DateAndTime = DateTime.Parse("2030-01-01 9:00"),  TemperatureFahrenheit = 82}
            };

            return View(cityWeathers);
        }

        [Route("/weather/{cityCode}")]

        public IActionResult Details(string? cityCode)
        {
            List<CityWeather> cityWeathers = new List<CityWeather>()
            {
              new CityWeather(){CityUniqueCode = "LDN", CityName = "London",
                  DateAndTime = DateTime.Parse("2030-01-01 8:00"), TemperatureFahrenheit = 33},
              new CityWeather(){CityUniqueCode = "NYC", CityName = "NewYork",
                  DateAndTime = DateTime.Parse("2030-01-01 3:00"),  TemperatureFahrenheit = 60},
              new CityWeather(){CityUniqueCode = "PAR", CityName = "Paris",
                  DateAndTime = DateTime.Parse("2030-01-01 9:00"),  TemperatureFahrenheit = 82}
            };

            foreach (var item in cityWeathers)
            {
                if (cityCode == item.CityUniqueCode)
                {

                    CityWeather? matchingCity = cityWeathers.Where(code => code.CityUniqueCode == cityCode).FirstOrDefault();

                    return View(matchingCity);

                }
            }

            return BadRequest("You write not exist Unique Code:( ");
        }
    }
}
