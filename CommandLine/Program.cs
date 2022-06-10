while (true)
{
    string input = Console.ReadLine();
    if (input == "quit")
    {
        Console.WriteLine("Are you sure you want to quit?\n\n(Type YES to confirm or anything else to continue)");
        string reply = Console.ReadLine();
        if (reply == "YES")
        {
            break;  
        }
        continue;
    }

    var words = input.Split();
    foreach (var word in words)
    {
        if (string.IsNullOrWhiteSpace(word))
        { 
            continue;//SKIP
        }

        bool isValidInt = int.TryParse(word, out int number);// bring back 2 values: bool, int-only used if bool true else defaults to zero
        if (isValidInt)
        {
            Console.WriteLine(number + 10);//if true
        }
        else
        {
            Console.WriteLine(word);
        }
    }
}