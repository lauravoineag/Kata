using MangaStore;

namespace MangaStore;

public class Figurine: IProduct
{
    public string Cuteness { get; set; }
    public string Manufacturer { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}