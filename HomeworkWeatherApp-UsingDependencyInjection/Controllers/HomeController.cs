using HomeworkWeatherApp.Models;
using IServiceContracts;
using Microsoft.AspNetCore.Mvc;

namespace HomeworkWeatherApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeatherService _weatherService;

        private readonly IWeatherService _serviceFindCity;


		public HomeController(IWeatherService WeatherService, IWeatherService ServiceFindCity) 
        {
           _weatherService= WeatherService;

           _serviceFindCity = ServiceFindCity;
        }

		[Route("/")]
        public IActionResult Index()
        {
			List<CityWeather> citiesWeather = _weatherService.GetWeatherDetails();


			return View(citiesWeather);
        }

        [Route("/weather/{cityCode}")]

        public IActionResult Details(string? cityCode)
        {
			CityWeather? matchingCity = _serviceFindCity.GetWeatherByCityCode(cityCode);

            if (matchingCity == null)
            {
                return BadRequest("You write not exist Unique Code:( ");
            }

			return View(matchingCity);
		}
    }
}
