using Shared.Models.Weather;

namespace Services.Interfaces;

public interface IWeatherService
{
	public IEnumerable<WeatherForecast> GetWeatherForecasts();
}
