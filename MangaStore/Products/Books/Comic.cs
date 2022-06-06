using MangaStore;

namespace MangaStore;

public class Comic : IBook
{
    public string Name { get; set; }
    
    public double Price { get; set; }
    public int Discount { get; set; }
    public string Genre { get; set; }
    public string Description { get; set; }
    public double Rating { get; set; }
}