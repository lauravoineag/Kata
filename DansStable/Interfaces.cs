namespace Dan_s_Stable;
public interface IAnimal
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public interface IHorse : IAnimal
{
    public int Speed { get; set; }
}

public interface IPig : IAnimal
{
    public int Weight { get; set; }
}

public interface IDonkey : IAnimal
{
    public string Colour { get; set; }
}

public interface IStable
{
    List<IAnimal> Animals { get; }
    List<IHorse> Horses { get; }
    List<IPig> Pigs { get; }
    List<IDonkey> Donkeys { get; }
    
    void AddHorse(IHorse horse);
    void AddPig(IPig pig);
    void AddDonkey(IDonkey donkey);
}
