using Data.Models;
using Shared.Models.Title;

namespace Repositories.Interfaces;

public interface ITitleRepository
{
	Task Add(List<Title> titles);

	Task<IEnumerable<TitleForListModel>> GetAll();

    Task BorrowTitle(BorrowTitleModel model);

    Task<TitleWithDetailsModel> GetWithDetails(int titleId);
}