using MangaStore;
using MangaStore.ShoppingCart;
using MangaStore.User;
using Newtonsoft.Json;

string text = File.ReadAllText(@"C:\Code\Kata\MangaStore\Stores.json");
//Console.WriteLine("Contents of WriteText.txt = {0}", text);

Stores stores= JsonConvert.DeserializeObject<Stores>(text);

while (true)// Loop indefinitely// Select choice
{
    Console.WriteLine();
    Console.WriteLine("What item would you like to add? Please select from numbers below.");
    Console.WriteLine("\n 1: Books\n 2: Posters\n 3: Figurines\n 4: Games");//Prompt
    string a = Console.ReadLine();//Get int from user
    bool isValidDouble_a = double.TryParse(a, out double number_a);//double works for negative numbers
    if(isValidDouble_a)
    {
        if (number_a > 4 || number_a < 0)
        {
            Console.WriteLine($"{number_a} is not in the picklist. Please only select numbers from 1-4");
        }
        else
        {
            Console.WriteLine("You selected number : " + number_a);
        }

        if (number_a == 1)
        {
            Console.WriteLine("Please select the book type:\n 1: Mangas\n 2: Comics");

            while (true)
            {
                string b = Console.ReadLine();//Get int from user
                bool isValidDouble_b = double.TryParse(b, out double number_b);//double works for negative numbers

                if (isValidDouble_b)
                {
                    if (number_b == 1)
                    {
                        var mangaNames = stores.MangaStore.Products.Books.Mangas;
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("This is the list of Manga Books Titles:");
                        Console.WriteLine();

                        int index = 1; //Declare the integer loop variable beforehand
                        foreach (Manga item in
                                 mangaNames) // Loop through all values, incrementing the loop variable with 1 each loop cycle
                        {
                            Console.WriteLine($"{index}: {item.Name}");
                            index++;
                        }

                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("What manga would you like to add to cart?");

                        string c = Console.ReadLine();
                        bool isValidDouble_c = double.TryParse(c, out double number_c);
                        if (isValidDouble_c)
                        {
                            if (number_c == 1)
                            {
                                var mangas = stores.MangaStore.Products.Books;
                                var naruto = mangas.Find("Naruto");
                                var user_c = new User("Laura");
                                user_c.ShoppingCart.Add(naruto);
                                Console.WriteLine($"You added {naruto.Name} to cart");
                            }

                            if (number_c == 2)
                            {
                                var mangas = stores.MangaStore.Products.Books;
                                var blueSpringRide = mangas.Find("Blue Spring Ride");
                                var user_c = new User("Laura");
                                user_c.ShoppingCart.Add(blueSpringRide);
                                Console.WriteLine($"You added {blueSpringRide.Name} to cart");
                            }

                            if (number_c == 3)
                            {
                                var mangas = stores.MangaStore.Products.Books;
                                var onePiece = mangas.Find("One Piece");
                                var user_c = new User("Laura");
                                user_c.ShoppingCart.Add(onePiece);
                                Console.WriteLine($"You added {onePiece.Name} to cart");
                            }

                            if (number_c > 3 || number_c < 0)
                            {
                                Console.WriteLine(
                                    $"{number_a} is not a number in a the picklist. Please only select numbers from 1-2");
                            }

                            if (isValidDouble_c == false)
                            {
                                Console.WriteLine(
                                    $"{number_a} is not a number in a the picklist. Please only select numbers from 1-2");
                            }
                        }
                    }
                    else if (number_b == 2)
                    {
                        var comicNames = stores.MangaStore.Products.Books.Comics;
                        Console.WriteLine("List of all the names of the Comic:");
                        int index = 1;
                        foreach (Comic item in comicNames)
                        {
                            Console.WriteLine($"{index}: {item.Name}");
                            index++;
                        }

                        Console.WriteLine("What comic would you like to add to the cart?");
                        string d = Console.ReadLine();
                        bool isValidDouble_d = double.TryParse(d, out double number_d);
                        if (isValidDouble_d)
                        {
                            if (number_d == 1)
                            {
                                var mangas = stores.MangaStore.Products.Books;
                                var batman = mangas.Find("Batman");
                                var user_c = new User("Laura");
                                user_c.ShoppingCart.Add(batman);
                                Console.WriteLine($"You added {batman.Name} to cart");
                            }

                            if (number_d == 2)
                            {
                                var mangas = stores.MangaStore.Products.Books;
                                var superman = mangas.Find("Superman");
                                var user_c = new User("Laura");
                                user_c.ShoppingCart.Add(superman);
                                Console.WriteLine($"You added {superman.Name} to cart");
                            }

                            if (number_d > 2 || number_d < 0)
                            {
                                Console.WriteLine(
                                    $"{number_a} is not a number in a the picklist. Please only select numbers from 1-2");
                            }
                        }

                        if (isValidDouble_d == false)
                        {
                            Console.WriteLine(
                                $"{number_a} is not a number in a the picklist. Please only select numbers from 1-2");
                        }
                    }
                    else
                    {
                        Console.WriteLine(
                            $"{number_b} is not a number in a the picklist. Please only select numbers from 1-2");
                    }
                }
                if (isValidDouble_b == false) 
                { 
                    Console.WriteLine($"{number_a} is not a number in a the picklist. Please only select numbers from 1-2");
                }
            }
        }
    }

    if (isValidDouble_a == false)
    { 
        Console.WriteLine($"{number_a} is not a number in a the picklist. Please only select numbers from 1-4");
    }
}


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

Console.WriteLine("end");

