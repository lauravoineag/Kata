namespace MangaStore;

public interface IManga
{
    public string Name { get; set; }
    public double Price { get; set; }
}

public interface IAnimeSeries
{
    public string Genre { get; set; }
    void AddAnimeSeries(IAnimeSeries animeSeries);
}

public interface IStore: IManga,IAnimeSeries
{
    List<IManga> MangasList { get; set; }
    void AddManga(IManga manga);
}
