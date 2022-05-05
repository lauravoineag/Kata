using MangaStore.Products;

namespace MangaStore;

public class CardGame:IProduct
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}