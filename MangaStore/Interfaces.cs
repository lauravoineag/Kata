namespace MangaStore;

public interface IManga:IStore
{
    public string Name { get; set; }
    public double Price { get; set; }
}

public interface IStore
{
    List<IManga> Mangas { get; set; }
}