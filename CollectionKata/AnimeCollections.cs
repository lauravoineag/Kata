namespace CollectionKata;
 
public class AnimeCollections : IAnimeCollections
{
    public List<IAnime> AnimeList { get; set; } 
    public ICollection<IAnime> AnimeCollection { get; set; }
    public IAnime[] AnimeArray { get; set; }
    public IEnumerable<IAnime> AnimeEnumerable { get; set; }

    publi      vc AnimeCollections()
    {
        //Lists
        AnimeList = new List<IAnime>();
        AnimeList.Add(new Anime
        {
            Name = "Nana",
            Episodes =47,
            Genre = "Drama, Romance, Slice of Life",  
            Studio = "Madhouse",
            ReleasedDate = new DateOnly(2006, 4, 05)
        });

        var naruto = new Anime
        {
            Name = "Naruto",
            Episodes = 800,
            Genre = "Action, Adventure, Martial Arts",
            Studio = "Studio Pierrot",
            ReleasedDate = new DateOnly(2002, 10, 03)
        };
        AnimeList.Add(naruto);

        var aSilentVoice = new Anime
        {
            Name = "A silent voice",
            Episodes = 1,
            Genre = "Drama",
            Studio = "Kyoto Animation",
            ReleasedDate = new DateOnly(2016, 09, 17)
        };
        AnimeList.Add(aSilentVoice);     
        
        AnimeList.Add(new Anime
        {
            Name = "Attack on Titan",
            Episodes = 100,
            Genre = "Action, Drama, Mystery, Survival",
            Studio = "Wit Studio",
            ReleasedDate = new DateOnly(2013, 04, 07)
        });

        var violetEvergarden = new Anime
        {
            Name = "Violet Evergarden",
            Episodes = 30,
            Genre = "Drama, Fantasy, Slice of Life",
            Studio = "Kyoto Animation",
            ReleasedDate = new DateOnly(2018, 01, 11)
        };
        AnimeList.Add(violetEvergarden);

        //Collections 
        AnimeCollection = new List<IAnime>();
        AnimeCollection.Add(new Anime
        {
            Name = "Attack on Titan",
            Episodes = 100,
            Genre = "Action, Drama, Mystery, Survival",
            Studio = "Wit Studio",
            ReleasedDate = new DateOnly(2013, 04, 07)
        });
        
        AnimeCollection.Add(violetEvergarden);
        AnimeCollection.Add(aSilentVoice);
        AnimeCollection.Add(naruto);
        
        
        //IEnumerable
        //AnimeEnumerable = new List<IAnime>();
        //((List<IAnime>) AnimeEnumerable).Add(violetEvergarden);

        AnimeEnumerable = new List<IAnime>
        {
            violetEvergarden
        };

        AnimeArray = new IAnime[] {violetEvergarden, naruto};



    }
    
}