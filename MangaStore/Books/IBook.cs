namespace MangaStore;

public interface IBook
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public string Description { get; set; }
    public int Rating { get; set; }
}