using Data;
using Repositories.Interfaces;

namespace Repositories.Repositories
{
	public class UnitOfWork(
							ApplicationDbContext context, 
							IAuthorRepository authorRepository, 
							IWeatherRepository weatherRepository) : IUnitOfWork
	{
		public IAuthorRepository AuthorRepository => authorRepository;

		public IWeatherRepository WeatherRepository => weatherRepository;

		public async Task SaveChanges()
		{
			await context.SaveChangesAsync();
		}
	}
}
