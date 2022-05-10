namespace MangaStore;

public class Games
{
    public List<CardGame> CardGames { get; } = new List<CardGame>();
    public List<VideoGame> VideoGames { get; } = new List<VideoGame>();
    public List<BoardGame> BoardGames { get; } = new List<BoardGame>();
    public List<IGame> AllGames { get;} = new List<IGame>();

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