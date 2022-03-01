int VowelCount(string text)
{
    char[] vowels={'a', 'e', 'i', 'o', 'u'};
    int total = 0;

    Console.WriteLine(vowels[0]);//test 

    for (int i = 0; i < text.Length; i++)
    {
        for (int g = 0; g < vowels.Length; g++)
        {
            if (text[i] == vowels[g])
            {
                total++;
                Console.WriteLine(text[i]);
            }
        }
    }
    return total;
}

//var result=VowelCount(Console.ReadLine());
//Console.WriteLine(result);


int VowelCount2(string text)
{
    char[] vowels={'a', 'e', 'i', 'o', 'u'};
    int total2 = 0;

    foreach (var character in text)
    {
        foreach (var vowel in vowels )
        {
            if (character==vowel)
            {
                total2++;
                Console.WriteLine(character);
            }
        }
    }
    return total2;
}
//var result2=VowelCount2(Console.ReadLine());
//Console.WriteLine(result2);

int VowelCount3(string text)
{
    char[] vowels = {'a', 'e', 'i', 'o', 'u'};
    int total3 = 0;

    int i = 0;
    while (i < text.Length)
    {
        int g = 0;
        while (g < vowels.Length)
        {
            if (text[i] == vowels[g])
            {
                total3++;
            }
            g++;
        }
        i++;
    }

    return total3;
}

var result3=VowelCount3(Console.ReadLine());
Console.WriteLine(result3);
    


    
  
