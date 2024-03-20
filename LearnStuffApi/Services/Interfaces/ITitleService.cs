using Data.Models;
using Shared.Models.Title;

namespace Services.Interfaces;

public interface ITitleService
{
	Task AddTitle(AddTitleModel model);

	Task<IEnumerable<TitleForListModel>> GetAllForList();

    Task<Title> GetWithDetails(int titleId);

    Task Borrow(BorrowTitleModel model);
}