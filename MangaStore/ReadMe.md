##Step by step
1. First create the blueprint
```namespace MangaStore;
public interface IManga:IStore
{
public string Name { get; set; }
public double Price { get; set; }
}

public interface IStore
{
List<IManga> Mangas { get; set; }
}
```
2. Implement the Blueprint
> - create the Manga, Store classes off the blueprint