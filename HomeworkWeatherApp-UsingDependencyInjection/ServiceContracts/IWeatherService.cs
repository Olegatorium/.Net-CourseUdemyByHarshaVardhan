using HomeworkWeatherApp.Models;

namespace IServiceContracts
{
	public interface IWeatherService
	{
		List<CityWeather> GetWeatherDetails();

		CityWeather? GetWeatherByCityCode(string CityCode);
	}
}