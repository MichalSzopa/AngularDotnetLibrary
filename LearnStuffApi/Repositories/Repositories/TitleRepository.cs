using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Interfaces;
using Shared.Models.Author;
using Shared.Models.Title;

namespace Repositories.Repositories;

public class TitleRepository(ApplicationDbContext context) : ITitleRepository
{
    public async Task Add(List<Title> titles)
    {
        await context.Titles.AddRangeAsync(titles);
        await context.SaveChangesAsync();
    }

    public async Task BorrowTitle(BorrowTitleModel model)
    {
        var book = await context.Books.Where(b => b.TitleId == model.TitleId && b.IsBorrowed == false).FirstOrDefaultAsync();
        // TODO check if book is null


        var borrow = new Borrow 
        {
            BorrowDate = DateTime.Now,
            ExpirationDate = model.ExpirationDate,
            ClientId = model.ClientId,
            BookId = book.Id,
        };

        await context.Borrows.AddAsync(borrow);
    }

    public async Task<IEnumerable<TitleForListModel>> GetAll()
    {
        var titles = await context.Titles
            .Include(t => t.Books)
            .Include(t => t.Author)
            .Select(t => new TitleForListModel 
            { 
                Author = t.Author.FullName, 
                Name = t.Name, 
                PiecesAvailable = t.Books.Where(b => b.IsBorrowed).Count()
            })
            .ToListAsync();

        return titles;
    }

    public async Task<TitleWithDetailsModel> GetWithDetails(int titleId)
    {
        var title = await context.Titles
                                .Where(t => t.Id == titleId)
                                .Include(t => t.Author)
                                .Include(t => t.Books)
                                    .ThenInclude(b => b.Borrows)
                                        .ThenInclude(borrow => borrow.Client)
                                .FirstOrDefaultAsync();

        var borrows = new List<BorrowForTitleModel>();

        foreach(var book in title.Books.Where(book => book.IsBorrowed))
        {
            borrows.AddRange(book.Borrows.Select(borrow => 
            new BorrowForTitleModel 
            { 
                ClientName = borrow.Client.FirstName + borrow.Client.LastName,
                ExpirationDate = borrow.ExpirationDate
            }));
        }

        return new TitleWithDetailsModel
        {
            Name = title.Name,
            Description = title.Description,
            AuthorName = title.Author.FullName,
            AllPiecesCount = title.Books.Count(),
            PiecesAvailable = title.Books.Where(b => b.IsBorrowed == false).Count(),
            Borrows = borrows
        };
    }
}
