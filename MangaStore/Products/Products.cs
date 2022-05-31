using Newtonsoft.Json;

namespace MangaStore;

public class Products
{
    public Books Books { get;}
    public Games Games { get;}
    public List<Poster> Posters { get; }
    public List<Figurine> Figurines { get; }
    public List<IProduct> AllProducts { get; } = new List<IProduct>();
    
    [JsonConstructor]
    public Products(Books books, Games games, List<Poster> posters, List<Figurine> figurines)
    {
        Books = books;
        Games = games;
        Posters = posters;
        Figurines = figurines;
        AllProducts.AddRange(Books.AllBooks);
        AllProducts.AddRange(Games.AllGames);
        AllProducts.AddRange(Figurines);
        AllProducts.AddRange(Posters);
    }
    
    public IProduct Find(string name)
    {
        foreach (IProduct game in AllProducts)
        {
            if (game.Name == name)
            {
                return game;
            }
        }

        throw new ProductNotFound();
    }
    
    public IProduct FindMatch(string name)
    {
        foreach (IProduct game in AllProducts)
        {
            if (game.Name.Contains(name))
            {
                return game;
            }
        }

        throw new ProductNotFound();
    }
    
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