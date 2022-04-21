namespace MangaStore;

public interface IManga
{
    public string Name { get; set; }
    public double Price { get; set; }
}
public interface IStore: IManga
{
    List<IManga> MangasList { get; set; }
    void AddManga(IManga manga);
}
