using Data.Models;
using Repositories.Interfaces;
using Services.Interfaces;
using Shared.Models.Title;

namespace Services.Services;

public class TitleService(IUnitOfWork unitOfWork) : ITitleService
{
    public async Task AddTitle(AddTitleModel model)
    {
        var titles = new List<Title>();
        for(int i=0; i<model.PiecesToAdd; i++) 
        {
            titles.Add
            (new Title() {
                Name = model.Name,
                Description = model.Description,
                AuthorId = model.AuthorId
             });
        }

        await unitOfWork.TitleRepository.Add(titles);
    }

    public async Task Borrow(BorrowTitleModel model)
    {
        await unitOfWork.TitleRepository.BorrowTitle(model);
    }

    public async Task<IEnumerable<TitleForListModel>> GetAllForList()
    {
        return await unitOfWork.TitleRepository.GetAll();
    }

    public async Task<Title> GetWithDetails(int titleId)
    {
        var title = await unitOfWork.TitleRepository.GetWithDetails(titleId);
    }
}
