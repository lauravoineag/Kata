namespace Dan_s_Stable;

public static class Print{

public static void Stable(IStable stable)
    {
        foreach (var horse in stable.Horses)
        {
            Horse(horse);
        }

        foreach (var donkey in stable.Donkeys)
        {
            Donkey(donkey);
        }

        foreach (var pig in stable.Pigs)
        {
            Pig(pig);
        }
    }

    public static void Animal(IAnimal animal)
    {
        Console.WriteLine(animal.Name);
        Console.WriteLine(animal.Age);
    }

    public static void Horse(IHorse horse)
    {
        Console.WriteLine(horse.Speed);
        Animal(horse);
    }

    public static void Pig(IPig pig)
    {
        Console.WriteLine(pig.Weight);
        Animal(pig);
    }

    public static void Donkey(IDonkey donkey)
    {
        Console.WriteLine(donkey.Colour);
        Animal(donkey);
   
    }
    
}
