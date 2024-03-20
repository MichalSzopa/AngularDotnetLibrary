using Data;
using Repositories.Interfaces;

namespace Repositories.Repositories
{
	public class UnitOfWork(
							ApplicationDbContext context, 
							IAuthorRepository authorRepository, 
							IWeatherRepository weatherRepository,
							ITitleRepository titleRepository) : IUnitOfWork
	{
		public IAuthorRepository AuthorRepository => authorRepository;

		public IWeatherRepository WeatherRepository => weatherRepository;

		public ITitleRepository TitleRepository => titleRepository;

		public async Task SaveChanges()
		{
			await context.SaveChangesAsync();
		}
	}
}
