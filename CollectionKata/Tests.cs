using NUnit.Framework;

namespace CollectionKata;

[TestFixture]
public class Tests
{
    public static readonly IAnimeCollections AnimeCollections = new AnimeCollections();
    
    [Test]
    public void list_contains_correct_elements()
    {
        Assert.That(AnimeCollections.AnimeList.Count, Is.EqualTo(5));

        TestCollection(AnimeCollections.AnimeList);
    }    
    
    [Test]
    public void collection_contains_correct_elements()
    {
        Assert.That(AnimeCollections.AnimeCollection.Count, Is.EqualTo(4));

        TestCollection(AnimeCollections.AnimeCollection);
    }
    
    [Test]
    public void enumerable_contains_correct_elements()
    {
        Assert.That(AnimeCollections.AnimeEnumerable.Count, Is.EqualTo(1));

        TestCollection(AnimeCollections.AnimeEnumerable);
    }    
    
    [Test]
    public void array_contains_correct_elements()
    {
        Assert.That(AnimeCollections.AnimeArray.Length, Is.EqualTo(2));

        TestCollection(AnimeCollections.AnimeArray);
    }

    //How does this work?
    //All of the collections inherit from IEnumerable, so we can use the foreach loop to iterate over them.
    private static void TestCollection(IEnumerable<IAnime> collection)
    {
        foreach (var anime in collection)
        {
            Assert.That(anime.Name, Is.Not.Empty);
            Assert.That(anime.Episodes, Is.Not.EqualTo(0));
            Assert.That(anime.Genre, Is.Not.Empty);
            Assert.That(anime.Studio, Is.Not.Empty);
            Assert.That(anime.ReleasedDate, Is.Not.EqualTo(default(DateOnly)));
        }
    }
}