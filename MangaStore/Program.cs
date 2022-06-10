using MangaStore;
using MangaStore.User;
using Newtonsoft.Json;

string text = File.ReadAllText(@"C:\Code\Kata\MangaStore\Stores.json");
//Console.WriteLine("Contents of WriteText.txt = {0}", text);

Stores stores= JsonConvert.DeserializeObject<Stores>(text);

while (true)// Loop indefinitely
{
    Console.WriteLine("What would you like to add?\n 1.Books\n 2.Posters\n 3.Figurines\n 4.Games");//Prompt
    int a = Convert.ToInt32(Console.ReadLine());//Get int from user
    
    if (a > 4)
    {
        Console.WriteLine($"{a} is not in the picklist. Please only select numbers from 1-4");
    }
    else
    {
        Console.WriteLine("You selected number : " + a);
        break;
    }
}
















/*var mangaNames = stores.MangaStore.Products.Books.Mangas;
Console.WriteLine("List of all the names of the Manga:");
foreach (Manga item in mangaNames)
{
    Console.WriteLine(item.Name);
}
Console.WriteLine("What manga would you like to pick?");
Console.ReadLine();

var comicNames = stores.MangaStore.Products.Books.Comics;
Console.WriteLine("List of all the names of the Comic:");
foreach (Comic item in comicNames)
{
    Console.WriteLine(item.Name);
}
Console.WriteLine("What comic would you like to pick?");
Console.ReadLine();*/










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

Console.WriteLine("end");

