using MangaStore;
using Newtonsoft.Json;

string text = File.ReadAllText(@"C:\Code\Kata\MangaStore\Data.json");
Console.WriteLine("Contents of WriteText.txt = {0}", text);

Root mangaStore= JsonConvert.DeserializeObject<Root>(text);

Console.WriteLine("mangastore");