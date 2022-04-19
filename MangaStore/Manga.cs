namespace MangaStore;

public class Manga:IManga
{
    public string Name { get; set; }
    public double Price { get; set; }
    public Manga(string name, double price)
    {
        Name = name;
        Price = price;
    }
}
