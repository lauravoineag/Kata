namespace MangaStore;

public class MangaStore
{
    public Books Books { get; set; }
    public List<Poster> Posters { get; set; }
    public List <Figurine> Figurines { get; set; }
    public AnimeMusic StoreMusic { get; set; }
    public Games Games { get; set; }
}

 public class Root
    {
        public MangaStore MangaStore { get; set; }
    }