using System.Runtime.InteropServices;
using System.Security.Principal;
using MangaStore.Users;

namespace MangaStore;

public static class Gui
{
    public static void Print(User user, Stores stores)
    {
        int printProducts = PrintProducts(user, stores);
        SelectProduct(user, stores, printProducts);
    }

    private static int PrintProducts(User user, Stores stores)
    {
        //Prints products
        Console.WriteLine("\nWhat item would you like to add? Please select from numbers below.");
        Console.WriteLine("\n 1: Books\n 2: Posters\n 3: Figurines\n 4: Games\n"); //Prompt
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
                Console.WriteLine($"\nYou selected number : {itemNumber}\n");
            }
        }

        if (isValid == false)
        {
            Console.WriteLine(
                $"{itemNumber} is not a number in a the picklist. Please only select numbers from 1-4");
        }
        return itemNumber;
    }

    private static void SelectProduct(User user, Stores stores, int itemNumber)
    {
        if (itemNumber == 1)
        {
            while (true)
            {
                Console.WriteLine("Please select the book type:\n \n1: Mangas\n2: Comics");
                string userInput = Console.ReadLine();
                bool isValid = int.TryParse(userInput, out int bookItem);

                if (isValid == false)
                {
                    Console.WriteLine(
                        $"\n{itemNumber} is not a number in a the picklist. Please only select numbers from 1-2\n");
                    continue;
                }

                if (bookItem == 1)
                {
                    DisplayManga(stores);
                    AddManga(user, stores);
                    break;
                }

                if (bookItem == 2)
                {
                    DisplayComic(stores);
                    AddComic(user, stores);
                    break;
                }

                Console.WriteLine(
                    $"{bookItem} is not a number in a the picklist. Please only select numbers from 1-2");
            }
        }
    }

    private static void DisplayManga(Stores stores)
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

    private static void DisplayComic(Stores stores)
    {
        var comicNames = stores.MangaStore.Products.Books.Comics;
        Console.WriteLine("List of all the names of the Comic:");
        int index = 1;
        foreach (Comic item in comicNames)
        {
            Console.WriteLine($"{index}: {item.Name}");
            index++;
        }
    }

    private static void AddComic(User user, Stores stores)
    {
        while (true)
        {
            Console.WriteLine("\n What comic would you like to add to the cart?\n");
            string comic = Console.ReadLine();
            bool isValid = int.TryParse(comic, out int comicNumber);
            if (isValid == false)
            {
                Console.WriteLine(
                    $"\n{comicNumber} is not in the selection. Please try again \n");
                continue;
            }

            if (comicNumber == 1)
            {
                var mangas = stores.MangaStore.Products.Books;
                var batman = mangas.Find("Batman");
                user.ShoppingCart.Add(batman);
                Console.WriteLine($"You added {batman.Name} to cart");
            }

            if (comicNumber == 2)
            {
                var mangas = stores.MangaStore.Products.Books;
                var superman = mangas.Find("Superman");
                user.ShoppingCart.Add(superman);
                Console.WriteLine($"You added {superman.Name} to cart");
            }

            if (comicNumber > 2 || comicNumber < 0)
            {
                Console.WriteLine(
                    $"{comicNumber}* is not a number in a the picklist. Please only select numbers from 1-2");
            }
        }
    }

    private static void AddManga(User user, Stores stores)
    {
        Console.WriteLine("------------------------------------");
        Console.WriteLine("What manga would you like to add to cart?");

        string manga = Console.ReadLine();
        bool isValid = int.TryParse(manga, out int mangaNumber);
        if (isValid)
        {
            if (mangaNumber == 1)
            {
                var mangas = stores.MangaStore.Products.Books;
                var naruto = mangas.Find("Naruto");
                user.ShoppingCart.Add(naruto);
                Console.WriteLine($"You added {naruto.Name} to cart");
            }

            if (mangaNumber == 2)
            {
                var mangas = stores.MangaStore.Products.Books;
                var blueSpringRide = mangas.Find("Blue Spring Ride");
                user.ShoppingCart.Add(blueSpringRide);
                Console.WriteLine($"You added {blueSpringRide.Name} to cart");
            }

            if (mangaNumber == 3)
            {
                var mangas = stores.MangaStore.Products.Books;
                var onePiece = mangas.Find("One Piece");
                user.ShoppingCart.Add(onePiece);
                Console.WriteLine($"You added {onePiece.Name} to cart");
            }

            if (mangaNumber > 3 || mangaNumber < 0)
            {
                Console.WriteLine(
                    $"{mangaNumber} is not a number in the Manga List. Please only select numbers from 1-3");
            }

            if (isValid == false)
            {
                Console.WriteLine(
                    $"{mangaNumber} is not a number in the Manga List. Please only select numbers from 1-3");
            }
        }
    }
}