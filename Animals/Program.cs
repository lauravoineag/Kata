using System.Threading.Channels;
using Animals;
using Newtonsoft.Json;

Console.WriteLine("Hello, World!");

string jsonInput = "{\"Type\":\"Dog\",\n\"Name\":\"Fred\",\n\"Age\":6}";
Animal animal= JsonConvert.DeserializeObject<Animal>(jsonInput);
Console.WriteLine(animal.Age);
Console.WriteLine(animal.Name);
Console.WriteLine(animal.Type);

string text = File.ReadAllText(@"C:\Code\Kata\Animals\Animals.json");
Console.WriteLine("Contents of WriteText.txt = {0}", text);
ListOfAnimals animals= JsonConvert.DeserializeObject<ListOfAnimals>(text);


Console.WriteLine("test");