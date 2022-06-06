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

        foreach (var item in CartItems)
        {
            if (product.Name == cartItem.Product.Name)
            {
                cartItem.Quantity += 1;
                Total += cartItem.CalculateItem();
            }
            else
            {
                CartItems.Add(cartItem);
                Total += cartItem.CalculateItem();
            }

        }
    }
    
    public void Remove(IProduct product)
    {
        var cartItem = new CartItem(product);
        CartItems.Remove(cartItem);
        Total -= cartItem.CalculateItem();
    }

    public double CalcutateTotal()
    {
        return Total;
    }
}