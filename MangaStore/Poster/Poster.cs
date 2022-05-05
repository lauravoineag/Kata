using MangaStore.Products;

namespace MangaStore;

public class Poster: IProduct
{
    public string Title { get; set; }
    public string Dimensions { get; set; }
    public string Material { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}