namespace Dan_s_Stable;

public class Stable:IStable
{
    public List<IAnimal> Animals { get; } = new List<IAnimal>();
    public List<IHorse> Horses { get; } = new List<IHorse>();
    public List<IPig> Pigs { get; } = new List<IPig>();
    public List<IDonkey> Donkeys { get; } = new List<IDonkey>();
    public void AddHorse(IHorse horse)
    {
        Horses.Add(horse);
        Animals.Add(horse);
    }

    public void AddPig(IPig pig)
    {
        Pigs.Add(pig);
        Animals.Add(pig);
    }

    public void AddDonkey(IDonkey donkey)
    {
        Donkeys.Add(donkey);
        Animals.Add(donkey);
    }
}