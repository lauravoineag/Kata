using MangaStore;

namespace MangaStore;

public class Manga:IBook
{
    public string Genre { get; set; }
    public int Volumes { get; set; }
    public List<Character> Characters { get; set; }
    public string Description { get; set; }
    public double Rating { get; set; }


    public string Name { get; set; }
    public double Price { get; set; }
}