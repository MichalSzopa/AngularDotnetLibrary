namespace Repositories.Interfaces
{
	public interface IUnitOfWork
	{
		IAuthorRepository AuthorRepository { get; }

		IWeatherRepository WeatherRepository { get; }

		Task SaveChanges();
	}
}
