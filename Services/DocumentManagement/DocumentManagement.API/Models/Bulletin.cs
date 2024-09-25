namespace DocumentManagement.API.Models;

public class Bulletin
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public List<string> Category { get; set; } = new();
    public string Path { get; set; } = default!;
    public int Revision { get; set; }
    public DateTime PublishedAt { get; set; }
    public string PublishedBy { get; set; } = default!;
}