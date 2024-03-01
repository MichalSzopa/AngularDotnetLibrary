using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;

namespace Repositories.Repositories;

public class AuthorRepository(ApplicationDbContext context) : IAuthorRepository
{
	public async Task Add(Author author)
	{
		await context.Authors.AddAsync(author);
		await context.SaveChangesAsync();
	}

	public async Task<IEnumerable<Author>> GetAll()
	{
		return await context.Authors.ToListAsync();
	}
}
