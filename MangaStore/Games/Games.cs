namespace MangaStore;

public class Games
{
    public List<CardGame> CardGames { get; set; } = new List<CardGame>();
    public List<VideoGame> VideoGames { get; set; } = new List<VideoGame>();
    public List<BoardGame> BoardGames { get; set; } = new List<BoardGame>();
    public List<IGame> AllGames { get; set; } = new List<IGame>();

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

    public void Remove(BoardGame boardGame)
    {
        BoardGames.Remove(boardGame);
    }
    public void Remove(VideoGame videoGame)
    {
        VideoGames.Remove(videoGame);
    }
    public void Remove(CardGame cardGame)
    {
        CardGames.Remove(cardGame);
    }

}