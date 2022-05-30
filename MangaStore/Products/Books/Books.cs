using Newtonsoft.Json;

namespace MangaStore;

public class Books
{
    public List<Manga> Mangas { get; set; }
    public List<Comic> Comics { get; set; }
    public List<IBook> AllBooks { get; set; } = new List<IBook>();

    [JsonConstructor]
    public Books(List<Manga> mangas, List<Comic> comics)
    {
        Mangas = mangas;
        Comics = comics;
        
        AllBooks.AddRange(mangas);
        AllBooks.AddRange(comics);
    }

    public void Add(Manga manga)
    {
        Mangas.Add(manga);
        AllBooks.Add(manga);
    }

    public void Add(Comic comic)
    {
        Comics.Add(comic);
        AllBooks.Add(comic);
    }

    public void Remove(Comic comic)
    {
        Comics.Remove(comic);
        AllBooks.Remove(comic);
    }
    
    public void Remove(string name)
    {
        throw new NotImplementedException();
    }

    public IBook Find(string name)
    {
        foreach (IBook book in AllBooks)
        {
            if (book.Name == name)
            {
                return book;
            }
        }

        throw new ProductNotFound();
    }
}