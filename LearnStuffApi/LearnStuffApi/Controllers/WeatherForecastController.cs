using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Shared.Models.Weather;

namespace LearnStuffApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController(IWeatherService weatherService) : ControllerBase
{

	[HttpGet(Name = "GetWeatherForecast")]
	public IEnumerable<WeatherForecast> Get()
	{
		return weatherService.GetWeatherForecasts();
	}
}
