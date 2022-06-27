using MangaStore;
using MangaStore.ShoppingCart;
using MangaStore.Users;
using Newtonsoft.Json;

string text = File.ReadAllText(@"C:\Code\Kata\MangaStore\Stores.json");
//Console.WriteLine("Contents of WriteText.txt = {0}", text);

Stores stores = JsonConvert.DeserializeObject<Stores>(text);
var user = new User("Laura");

Gui.Print(user, stores);


/*while (true) //Select quantity
{
    Console.WriteLine("How many would you like to add? Enter quantity:");
    string b = Console.ReadLine();
    bool isValidDouble = double.TryParse(b, out double quantity);
    {
        if (isValidDouble)
        {
            if (quantity > 0)
            {
                Console.WriteLine("You selected quantity : " + quantity);
                break;
            }else
            {
                Console.WriteLine("Please select positive numbers only.");
            }
        }

        if (isValidDouble == false)
        {
            Console.WriteLine($"{quantity} is not a number.Please enter correct quantity.");
        }
    }
}*/


/*var user = new User("Bob");
var books = stores.MangaStore.Products.Books;
user.ShoppingCart.Add(books.Find("Naruto"));
user.ShoppingCart.Add(books.Find("Blue Spring Ride"));
var games = stores.MangaStore.Products.Games;
user.ShoppingCart.Add(games.Find("Yu-Gi-Oh!"));

var swordArt=games.Find("Sword Art Online");
user.ShoppingCart.Add(swordArt);
user.ShoppingCart.Add(swordArt);
user.ShoppingCart.Add(swordArt);

user.ShoppingCart.Remove("Naruto");
user.ShoppingCart.Remove("Sword Art Online");

var products = stores.MangaStore.Products;
user.ShoppingCart.Add(products.Find("Claymore"));
user.ShoppingCart.Add(products.FindMatch("Kaisen"));*/

