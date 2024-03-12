using Repositories.Interfaces;
using Services.Interfaces;
using Shared.Models.Weather;

namespace Services.Services
{
	public class WeatherService(IUnitOfWork unitOfWork) : IWeatherService
	{
		public IEnumerable<WeatherForecast> GetWeatherForecasts()
		{
			return unitOfWork.WeatherRepository.GetWeatherForecasts();
		}
	}
}
