namespace NoteAppApi.Models;
public class Note
{
	public int Id { get; set; }
	public string? Name { get; set; }
	public string? NoteContent { get; set; }
	public DateTime? DateCreated { get; set; } = DateTime.UtcNow;
	public DateTime? DateModified { get; set; } = DateTime.UtcNow;
	public int UserId { get; set; }
};