using HomeworkWeatherApp.Models;
using IServiceContracts;

namespace Services
{
	public class WeatherService : IWeatherService
	{
		private List<CityWeather> _weatherDetails;

		public WeatherService() 
		{
			_weatherDetails = new List<CityWeather>()
			{
			  new CityWeather(){CityUniqueCode = "LDN", CityName = "London",
				  DateAndTime = DateTime.Parse("2030-01-01 8:00"), TemperatureFahrenheit = 33},
			  new CityWeather(){CityUniqueCode = "NYC", CityName = "NewYork",
				  DateAndTime = DateTime.Parse("2030-01-01 3:00"),  TemperatureFahrenheit = 60},
			  new CityWeather(){CityUniqueCode = "PAR", CityName = "Paris",
				  DateAndTime = DateTime.Parse("2030-01-01 9:00"),  TemperatureFahrenheit = 82}
			};
		}

		public CityWeather? GetWeatherByCityCode(string cityCode)
		{
			foreach (var item in _weatherDetails)
			{
				if (cityCode == item.CityUniqueCode)
				{

					CityWeather? matchingCity = _weatherDetails.Where(code => code.CityUniqueCode == cityCode).FirstOrDefault();
					return matchingCity;
				}
			}
			return null;
		}

		public List<CityWeather> GetWeatherDetails()
		{
			return _weatherDetails;
		}
	}
}