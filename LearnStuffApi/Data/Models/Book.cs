namespace Data.Models;

public class Book
{
	public int Id { get; set; }

	public int TitleId { get; set; }

	public bool IsBorrowed { get; set; }

	public virtual Title? Title { get; set; }

	public virtual IEnumerable<Borrow>? Borrows { get; set; }
}
