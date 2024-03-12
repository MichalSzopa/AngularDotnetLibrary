using Data.Models;
using Shared.Models.Author;

namespace Services.Interfaces;

public interface IAuthorService
{
	Task<Author> AddAuthor(AddAuthorModel model);

	Task<IEnumerable<Author>> GetAll();
}
