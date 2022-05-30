namespace MangaStore.User;
using ShoppingCart;

public class User
{
    public string Username { get; set; }
    public ShoppingCart ShoppingCart { get; set; }

    public User(string username)
    {
        Username = username;
        ShoppingCart = new ShoppingCart();
    }
}