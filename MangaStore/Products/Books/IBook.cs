namespace MangaStore;

public interface IBook: IProduct
{
    public string Genre { get; set; }
    public string Description { get; set; }
    public double Rating { get; set; }
}