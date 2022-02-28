using Toy_Kata;

var dogverine = new Dogverine("Dogverine", "Slash", "Slashes with knives");
dogverine.ArmMetal = "metal claws show when threatened";
dogverine.SetLimbs(2); // after battle

/*Dogverine dogverine = new Dogverine();
dogverine.Height = "tall";
dogverine.Name = "Dogverine";
dogverine.WeaponSound = "Slash";
dogverine.CharacterActivity = "Slashes with knives";
dogverine.ArmMetal = "metal claws show when threatened";
dogverine.SetLimbs(2); // after battle*/

var thar = new Thar("Thar", "Bump", "Swings with Hammer");
thar.WeaponSound = "Bump";

/*Thar thar = new Thar();
thar.Height = dogverine.Height;
thar.Beauty = "pretty";
thar.Name = "Thar";
thar.WeaponSound = "Bump";
thar.CharacterActivity = "Swings with Hammer";*/

WhiteShadow whiteShadow = new WhiteShadow("Whiteshadow", "Pew Pew", "Fires with Gun");
/*WhiteShadow whiteShadow = new WhiteShadow();
whiteShadow.Height = "medium";*/

string CharacterList(string character1, string character2, string character3)
{
    return $"These are the superheroes I created: {character1}, {character2},{character3}";
}

Console.WriteLine(CharacterList(dogverine.Name,thar.Name,whiteShadow.Name));