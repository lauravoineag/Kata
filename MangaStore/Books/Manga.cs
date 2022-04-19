namespace MangaStore;

public class Manga
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public int Volumes { get; set; }
    public List<Character> Characters { get; set; }
    public string Description { get; set; }
    public int Rating { get; set; }

}