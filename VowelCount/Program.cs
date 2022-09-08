using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        return str.Count(predicate: c => IsAVowel(c));
    }

    private static bool IsAVowel(char c) => c is 'a' or 'e' or 'i' or 'o' or 'u'; // return true if any of  these characters,false otherwise
}

/*foreach (var i in str)
 {
 if (i  == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u')
 {
 vowelCount++;
 }
}
for (int i = 0; i < str.Length; i++)
{
if (str[i]  == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
{
vowelCount++;
}
}

 public static int GetVowelCount(string str)
    {
        return str.Count(i => "aeiou".Contains(i));
    }

*/