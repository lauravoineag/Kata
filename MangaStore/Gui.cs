using System.Runtime.InteropServices;
using System.Security.Principal;
using MangaStore.Users;

namespace MangaStore;

public static class Gui
{

    public static void Print(User user, Stores stores)
    {
        while (true) // Loop indefinitely
        {
            int printProducts = PrintProducts(user, stores);
            SelectProduct(user, stores, printProducts);
        }
    }

    private static int PrintProducts(User user, Stores stores)
    {
        //Prints products
        Console.WriteLine();
        Console.WriteLine("What item would you like to add? Please select from numbers below.");
        Console.WriteLine("\n 1: Books\n 2: Posters\n 3: Figurines\n 4: Games"); //Prompt
        string userInput = Console.ReadLine();

        bool isValid = int.TryParse(userInput, out int itemNumber);
        if (isValid)
        {
            if (itemNumber > 4 || itemNumber < 0)
            {
                Console.WriteLine($"{itemNumber} is not in the picklist. Please only select numbers from 1-4");
            }
            else
            {
                Console.WriteLine("You selected number : " + itemNumber);
            }
        }

        if (isValid == false)
        {
            Console.WriteLine(
                $"{itemNumber} is not a number in a the picklist. Please only select numbers from 1-4");
        }
        return itemNumber;
    }

    //Select book
    private static void SelectProduct(User user, Stores stores, int itemNumber)
    {
        if (itemNumber == 1)
        {
            while (true)
            {
                Console.WriteLine("Please select the book type:\n 1: Mangas\n 2: Comics");
                string userInput = Console.ReadLine();
                bool isValidDouble_b = int.TryParse(userInput, out int number_b);

                if (isValidDouble_b)
                {
                    if (number_b == 1)
                    {
                        var mangaNames = stores.MangaStore.Products.Books.Mangas;
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("This is the list of Manga Books Titles:");
                        Console.WriteLine();

                        int index = 1;
                        foreach (Manga item in
                                 mangaNames) // Loop through all values, incrementing the loop variable with 1 each loop cycle
                        {
                            Console.WriteLine($"{index}: {item.Name}");
                            index++;
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
                                user.ShoppingCart.Add(batman);
                                Console.WriteLine($"You added {batman.Name} to cart");
                            }

                            if (number_d == 2)
                            {
                                var mangas = stores.MangaStore.Products.Books;
                                var superman = mangas.Find("Superman");
                                user.ShoppingCart.Add(superman);
                                Console.WriteLine($"You added {superman.Name} to cart");
                            }

                            if (number_d > 2 || number_d < 0)
                            {
                                Console.WriteLine(
                                    $"{itemNumber} is not a number in a the picklist. Please only select numbers from 1-2");
                            }
                        }

                        if (isValidDouble_d == false)
                        {
                            Console.WriteLine(
                                $"{itemNumber} is not a number in a the picklist. Please only select numbers from 1-2");
                        }
                    }
                    else
                    {
                        Console.WriteLine(
                            $"{number_b} is not a number in a the picklist. Please only select numbers from 1-2");
                    }

                    //Next step
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
                            user.ShoppingCart.Add(naruto);
                            Console.WriteLine($"You added {naruto.Name} to cart");
                        }

                        if (number_c == 2)
                        {
                            var mangas = stores.MangaStore.Products.Books;
                            var blueSpringRide = mangas.Find("Blue Spring Ride");
                            user.ShoppingCart.Add(blueSpringRide);
                            Console.WriteLine($"You added {blueSpringRide.Name} to cart");
                        }

                        if (number_c == 3)
                        {
                            var mangas = stores.MangaStore.Products.Books;
                            var onePiece = mangas.Find("One Piece");
                            user.ShoppingCart.Add(onePiece);
                            Console.WriteLine($"You added {onePiece.Name} to cart");
                        }

                        if (number_c > 3 || number_c < 0)
                        {
                            Console.WriteLine(
                                $"{number_c} is not a number in the Manga List. Please only select numbers from 1-3");
                        }

                        if (isValidDouble_c == false)
                        {
                            Console.WriteLine(
                                $"{number_c} is not a number in the Manga List. Please only select numbers from 1-3");
                        }
                    }
                }
            }
        }
    }
}
