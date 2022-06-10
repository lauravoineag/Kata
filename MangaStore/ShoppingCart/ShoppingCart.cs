using System.Net.Sockets;
using MangaStore;

namespace MangaStore.ShoppingCart;

public class ShoppingCart
{
    public double TotalPrice { get; set; }
    public List<CartItem> CartItems { get; set; } = new ();

    public void Add(IProduct product)
    {
        foreach (var cartItem in CartItems)
        {
            if (cartItem.Product.Name == product.Name)
            {
                cartItem.Quantity++;
                TotalPrice += cartItem.Product.Price;
                return;
            } 
        }
        CartItems.Add(new CartItem(product));
        TotalPrice += product.Price;
        Console.WriteLine("end"); 
    }

    public void Remove(string productName)
    {
        foreach (var cartItem in CartItems)
        {
            if (cartItem.Product.Name == productName)
            {
                if (cartItem.Quantity <= 1)
                {
                    CartItems.Remove(cartItem);

                }
                else
                { 
                    cartItem.Quantity--;
                    TotalPrice += cartItem.Product.Price;
                }
                
                return;
            } 
        }
    }

    public double CalcutateTotal()
    {
        return TotalPrice;
        
    }
}