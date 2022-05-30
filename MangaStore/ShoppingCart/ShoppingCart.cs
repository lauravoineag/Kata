using System.Net.Sockets;
using MangaStore;

namespace MangaStore.ShoppingCart;

public class ShoppingCart
{
    public double Total { get; set; }
    public List<IProduct> Products { get; set; } = new List<IProduct>();

    public void Add(IProduct product)
    {
        Products.Add(product);
        Total += product.Price;
    }
    
    public void Remove(IProduct product)
    {
        Products.Remove(product);
        Total -= product.Price;
    }
}