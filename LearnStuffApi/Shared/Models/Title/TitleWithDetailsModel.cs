using Shared.Models.Author;

namespace Shared.Models.Title;

public class TitleWithDetailsModel
{
	public string Name { get; set; }

    public string Description { get; set; }

    public string AuthorName { get; set; }

    public int AllPiecesCount { get; set; }

    public int PiecesAvailable { get; set; }

    public List<BorrowForTitleModel> Borrows { get; set; }
}
