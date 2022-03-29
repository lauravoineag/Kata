var array = new[] { "A", "B", "C" };

var list = new List<string>();
list.Add("A");
list.Add("B");
list.Add("C");

void PrintList(List<string> items)
{
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}

void PrintIList(IList<string> items)
{
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}

void PrintCollection(ICollection<string> items)
{
    //items.

    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}

void PrintIEnumerable(IEnumerable<string> items)
{
    //var enumerator = items.GetEnumerator();

    //while (enumerator.MoveNext())
    //{
    //    Console.WriteLine(enumerator.Current);
    //}

    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}

void PrintName(string name)
{
    Console.WriteLine(name);
}

//PrintList(list);
//PrintIList(list);
//PrintIEnumerable(list);
PrintIEnumerable(array);
//PrintName("Laura");
//PrintName("Matt");



//IEnumerable<string> a = new List<string>
//{
//    "A", "B", "C", "D", "E", "F"
//};

Console.WriteLine("Hello, World!");