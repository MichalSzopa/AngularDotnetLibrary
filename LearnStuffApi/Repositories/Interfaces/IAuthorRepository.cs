using Data.Models;

namespace Repositories.Interfaces;

public interface IAuthorRepository
{
	Task Add(Author author);

	Task<IEnumerable<Author>> GetAll();
}
