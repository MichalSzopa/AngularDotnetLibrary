namespace Data.Models;

public class Title
{
	public int Id { get; set; }

	public string Name { get; set; }

	public string Description { get; set; }

	public int AuthorId { get; set; }

	public virtual Author? Author { get; set; }

	public virtual IEnumerable<Book>? Books { get; set; }
}
