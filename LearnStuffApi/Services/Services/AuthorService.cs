using Data.Models;
using Repositories.Interfaces;
using Services.Interfaces;
using Shared.Models.Author;

namespace Services.Services;

public class AuthorService(IUnitOfWork unitOfWork) : IAuthorService
{
	public async Task<Author> AddAuthor(AddAuthorModel model)
	{
		Author author = new()
		{
			FullName = model.FullName,
		};

		await unitOfWork.AuthorRepository.Add(author);
		return author;
	}

	public async Task<IEnumerable<Author>> GetAll()
	{
		return await unitOfWork.AuthorRepository.GetAll();
	}
}
