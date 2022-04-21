
using MangaStore;

//var mangaGiven=new Manga();
//mangaGiven.Name = "Given";
//mangaGiven.Price = 10;

//var mangaAttackOnTitan = new Manga
//{
   // Name = "Given",
   // Price = 10
//};

Manga tokyoRevengers=new Manga("Tokyo Revengers", 10);
Manga bleach=new Manga("Bleach",10 );
Manga jujutsuKaisen = new Manga("Jujutsu Kaisen", 10);
Manga given=new Manga("Given",10);
Manga attackOnTitan = new Manga("Attack on Titan",10 );

var store= new Store();
store.MangasList.Add(tokyoRevengers);
store.MangasList.Add(bleach);
store.MangasList.Add(jujutsuKaisen);
store.MangasList.Add(given);
store.MangasList.Add(attackOnTitan);


//if list is not initialised in Program.cs Store Class
//var store= new Store();
//store.MangasList = new List<IManga>();
//store.MangasList.Add(tokyoRevengers);

//if you know what the list contains
//var store= new Store();
//store.MangasList = new List<IManga>()
//{
//   tokyoRevengers
//};

//with interface
var store2 = new Store();
store2.AddManga(tokyoRevengers);



Console.WriteLine("Test");