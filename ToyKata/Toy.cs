namespace Toy_Kata;

public class Toy
{
    public int Limbs { get; private set; } =4;
    public string WeaponSound {get;set;}
    public string Name { get; set;}
    public string CharacterActivity { get; set; }
    public void SetLimbs(int limbs)
    {
        Limbs = limbs;
    }

    public Toy(string weaponSound,string name,string characterActivity)
    {
        WeaponSound = weaponSound;
        Name = name;
        CharacterActivity = characterActivity;
    }
}