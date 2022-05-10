using MangaStore;
using Newtonsoft.Json;

string text = File.ReadAllText(@"C:\Code\Kata\MangaStore\Data.json");
Console.WriteLine("Contents of WriteText.txt = {0}", text);

Stores mangaStores= JsonConvert.DeserializeObject<Stores>(text);

Console.WriteLine("mangastore");

