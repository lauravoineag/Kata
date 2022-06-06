using MangaStore;
using MangaStore.User;
using Newtonsoft.Json;

string text = File.ReadAllText(@"C:\Code\Kata\MangaStore\Data.json");
Console.WriteLine("Contents of WriteText.txt = {0}", text);

Stores mangaStores= JsonConvert.DeserializeObject<Stores>(text);


var user = new User("Bob");
var books = mangaStores.MangaStore.Products.Books;
user.ShoppingCart.Add(books.Find("Naruto"));
user.ShoppingCart.Add(books.Find("Blue Spring Ride"));
user.ShoppingCart.Remove(books.Find("Blue Spring Ride"));

var games = mangaStores.MangaStore.Products.Games;
user.ShoppingCart.Add(games.Find("Yu-Gi-Oh!"));
//var swordArt=games.Find("Sword Art Online");
//user.ShoppingCart.Add(swordArt);

var products = mangaStores.MangaStore.Products;
user.ShoppingCart.Add(products.Find("Claymore"));
user.ShoppingCart.Add(products.FindMatch("Kaisen"));

    Console.WriteLine("end");

