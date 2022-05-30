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

Console.WriteLine("end");