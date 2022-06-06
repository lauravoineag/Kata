using System.Net.Sockets;
using MangaStore;

namespace MangaStore.ShoppingCart;

public class ShoppingCart
{
    public double Total { get; set; }
    public List<CartItem> CartItems { get; set; } = new ();

    public void Add(IProduct product)
    {
        var cartItem = new CartItem(product); 
        CartItems.Add(cartItem);
        Total += cartItem.CalculateItem();
    }
    
    public void Remove(IProduct product)
    {
        CartItems.Remove(product);
        Total -= product.Price;
    }
}