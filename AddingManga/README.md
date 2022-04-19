##Step by step
1. First create the blueprint
``` csharp
namespace MangaStore;
public interface IManga:IStore
{
public string Name { get; set; }
public double Price { get; set; }
}
public interface IStore
{
List<IManga> Mangas { get; set; }
}
```
2. Implement the Blueprint
- create the Manga, Store classes off the blueprint.
- to do this create the actual classes and make them inherit the interface 

```
Manga.cs
namespace MangaStore;

public class Manga:IManga
{
public string Name { get; set; }
public double Price { get; set; }
}
```
3.Set up the constructor

``` 
Manga.cs
public Manga(string name, double price)
{
Name = name;
Price = price;
}
```
4.Add values 

```
Program.cs
using MangaStore;

var mangaGiven=new Manga();
mangaGiven.Name = "Given";
mangaGiven.Price = 10;

var mangaAttackOnTitan = new Manga
{
    Name = "Given",
    Price = 10
};

Manga tokyoRevengers=new Manga("Tokyo Revengers", 10);
Manga bleach=new Manga("Bleach",10 );
Manga jujutsuKaisen=new Manga("Jujutsu Kaisen",10)
```

5.Add values to the List    

```
Store.cs

//best way is to initialise the list up front 
public class Store:IStore
{
    public List<IManga> MangasList { get; set; } = new List<IManga>();
}

Program.cs - Add items to the List

var store= new Store();
sttore.MangasLis.Add(tokyoRevengers);
```
OR
```
if you know what the list contains

var store= new Store();
store.MangasList = new List<IManga>()
{
  tokyoRevengers
};
```

OR

```
if list is not initialised in Program.cs Store Class
public class Store:IStore 
{
    public List<IManga> MangasList { get; set; } 
}

Program.cs
var store= new Store();
store.MangasList = new List<IManga>();
store.MangasList.Add(tokyoRevengers);
```

6.Passing an interface as a parameter