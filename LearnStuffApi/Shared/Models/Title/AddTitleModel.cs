namespace Shared.Models.Title;

public class AddTitleModel
{
	public string Name { get; set; }

    public string Description { get; set; }

    public int AuthorId { get; set; }

    public int PiecesToAdd { get; set; }
}
