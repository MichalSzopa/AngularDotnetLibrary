using Shared.Models.Weather;

namespace Repositories.Interfaces;

public interface IWeatherRepository
{
	public IEnumerable<WeatherForecast> GetWeatherForecasts();
}
