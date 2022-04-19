namespace MangaStore;

public class Store:IStore
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Genre { get; set; }
    public List<IManga> MangasList { get; set; } = new List<IManga>();
    
    
    public List<IAnimeSeries> AnimeSeriesList { get; set; } = new List<IAnimeSeries>();

    public void AddManga(IManga manga)
    {
        MangasList.Add(manga);
    }
    public void AddAnimeSeries(IAnimeSeries animeSeries){}
    {
        AnimeSeries.Add(animeSeries);
    }
}

