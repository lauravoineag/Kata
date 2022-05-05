using MangaStore.Products;

namespace MangaStore;

public class Comic:IProduct
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public string Description { get; set; }
    public double Rating { get; set; }

    public Comic(string title, string genre, string description, double rating)
    {
        Title = title;
        Genre = genre;
        Description = description;
        Rating = rating;
    }
}