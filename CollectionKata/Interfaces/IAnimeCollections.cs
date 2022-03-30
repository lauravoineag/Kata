namespace CollectionKata;

public interface IAnimeCollections
{
    public List<IAnime> AnimeList { get; set; }
    public ICollection<IAnime> AnimeCollection { get; set; }
    public IAnime[] AnimeArray { get; set; }
    public IEnumerable<IAnime> AnimeEnumerable { get; set; }
}