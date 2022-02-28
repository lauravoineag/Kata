namespace Toy_Kata;

public class Dogverine : Toy
{
    public string ArmMetal { get; set; }
    public string Height { get; set; } = "tall";

    public Dogverine(string name, string weaponSound, string characterActivity) : base(weaponSound,
        name, characterActivity)
    {
    }
}