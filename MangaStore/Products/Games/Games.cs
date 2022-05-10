using Newtonsoft.Json;

namespace MangaStore;

public class Games
{
    public List<CardGame> CardGames { get;  }
    public List<VideoGame> VideoGames { get; }
    public List<BoardGame> BoardGames { get; }
    public List<IGame> AllGames { get;} = new List<IGame>();
    
    [JsonConstructor]
    public Games(List<CardGame> cardGames, List<VideoGame> videoGames, List<BoardGame> boardGames)
    {
        CardGames = cardGames;
        VideoGames = videoGames;
        BoardGames = boardGames;
        AllGames.AddRange(cardGames);
        AllGames.AddRange(videoGames);
        AllGames.AddRange(boardGames);
    }
    
    
    public void Add(BoardGame boardGame)
    {
        BoardGames.Add(boardGame);
    }
    
    public void Add(VideoGame videoGame)
    {
        VideoGames.Add(videoGame);
    }
    
    public void Add(CardGame cardGame)
    {
        CardGames.Add(cardGame);
    }

    public void Remove(string name)
    {
        throw new NotImplementedException();
    }
}