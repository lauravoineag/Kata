namespace MangaStore;

public class Products
{
    public Books Books { get; } = new Books();
    public Games Games { get; } = new Games();
    public List<IProduct> AllProducts { get; } = new List<IProduct>();
    public List<Poster> Posters { get; } = new List<Poster>();
    public List<Figurine> Figurines { get; } = new List<Figurine>();
    
    public void Add(Comic comic)
    {
        AllProducts.Add(comic);
        Books.Add(comic);
    }
    public void Add(Manga manga)
    {
        AllProducts.Add(manga);
        Books.Add(manga);
    }
    
    public void Add(Figurine figurine)
    {
        AllProducts.Add(figurine);
        Figurines.Add(figurine);
    }
    
    public void Add(Poster poster)
    {
        AllProducts.Add(poster);
        Posters.Add(poster);
    }
    
    public void Add(BoardGame boardGame)
    {
        AllProducts.Add(boardGame);
        Games.Add(boardGame);
    }
    public void Add(CardGame cardGame)
    {
        AllProducts.Add(cardGame);
        Games.Add(cardGame);
    }
    
    public void Add(VideoGame videoGame)
    {
        AllProducts.Add(videoGame);
        Games.Add(videoGame);
    }
    
    public void RemoveProduct(IProduct product)
    {
        AllProducts.Remove(product);
    }
}