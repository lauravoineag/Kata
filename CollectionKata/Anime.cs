namespace CollectionKata;

public class Anime:IAnime
{
    public string Name { get; set; }
    public int Episodes { get; set; }
    public string Genre { get; set; }
    public string Studio { get; set; }
    public DateOnly ReleasedDate { get; set; }
}