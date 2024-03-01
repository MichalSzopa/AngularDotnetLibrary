namespace Data.Models;

public class Borrow
{
	public int Id { get; set; }

	public DateTime BorrowDate { get; set; }

	public DateTime ExpirationDate { get; set; }

	public int ClientId { get; set; }

	public virtual Client? Client { get; set; }

	public int BookId { get; set; }

	public virtual Book? Book { get; set; }
}
