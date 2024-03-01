namespace Data.Models;

public class Author
{
	public int Id { get; set; }

	public string FullName { get; set; }

	public virtual IEnumerable<Title>? Titles { get; set; }
}
