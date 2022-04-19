namespace MangaStore;

public class Books
{
    public List<Manga> Mangas { get; set; } = new List<Manga>();
    public List<Comic> Comics { get; set; } = new List<Comic>();
    public List<IBook> AllBooks { get; set; } = new List<IBook>();

    public void Add(Manga manga)
    {
        Mangas.Add(manga);
    }

    public void Add(Comic comic)
    {
        Comics.Add(comic);
    }

    public void Remove(Manga manga)
    {
        Mangas.Add(manga);
    }

    public void Remove(Comic comic)
    {
        Comics.Add(comic);
    }
}