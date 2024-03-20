namespace Shared.Models.Title;

public class BorrowTitleModel
{
	public int UserId { get; set; }

    public int TitleId { get; set; }

    public DateTime ExpirationDate { get; set; }
}
