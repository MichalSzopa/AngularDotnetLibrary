using Repositories.Interfaces;
using Shared.Models.Weather;

namespace Repositories.Repositories;

public class WeatherRepository : IWeatherRepository
{
	public WeatherRepository() { }

	public IEnumerable<WeatherForecast> GetWeatherForecasts()
	{
		return Enumerable.Range(1, 5).Select(index => new WeatherForecast
		{
			Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
			TemperatureC = Random.Shared.Next(-20, 55),
			Summary = Summaries[Random.Shared.Next(Summaries.Length)]
		}).ToArray();
	}

	private static readonly string[] Summaries =
		[
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		];
}
