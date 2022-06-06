using MangaStore;

namespace MangaStore;

public class CardGame : IGame
{
    public string Description { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Discount { get; set; }
}