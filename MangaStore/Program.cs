using MangaStore;
using MangaStore.User;
using Newtonsoft.Json;

string text = File.ReadAllText(@"C:\Code\Kata\MangaStore\Stores.json");
//Console.WriteLine("Contents of WriteText.txt = {0}", text);

Stores stores= JsonConvert.DeserializeObject<Stores>(text);

while (true)// Loop indefinitely// Select choice
{
    Console.WriteLine("What would you like to add? Please select from numbers below.\n 1.Books\n 2.Posters\n 3.Figurines\n 4.Games");//Prompt
    string a = Console.ReadLine();//Get int from user

    bool isValidDouble = double.TryParse(a, out double number);//double works for negative numbers

    if(isValidDouble)
    {
        if (number > 4)
        {
            Console.WriteLine($"{number} is not in the picklist. Please only select numbers from 1-4");
        }
        else
        {
            Console.WriteLine("You selected number : " + number);
            break;
        }
    }

    if (isValidDouble == false)
    { 
        Console.WriteLine($"{number} is not a number in a the picklist. Please only select numbers from 1-4");
    }
}

while (true) //Select quantity
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

