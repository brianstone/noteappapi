using System.Text.Json.Serialization;

namespace NoteAppApi.Models;

public class User
{
	public int Id { get; set; }
	public string? FirstName { get; set; }
	public string? LastName { get; set; }
	public string? Email { get; set; }
	public string? ExternalType { get; set; }
	public string? ExternalId { get; set; }
	public List<Note>? Notes { get; set; }
	[JsonIgnore]
	public string? PasswordHash { get; set; }
};