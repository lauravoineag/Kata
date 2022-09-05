/*This time no story, no theory. The examples below show you how to write function accum:

Examples:
accum("abcd") -> "A-Bb-Ccc-Dddd"
accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
accum("cwAt") -> "C-Ww-Aaa-Tttt"
The parameter of accum is a string which includes only letters from a..z and A..Z.*/

//Remember:
//String is IEnumerable of Char

/*
char c = 'a';
string s = new string(c, 4);
Console.WriteLine(s);
*/

string letters = "abcd";

var selectors=letters.Select((c, i) => c.ToString().ToUpper() + new string(c,i));
foreach (var item in selectors)
{
    Console.WriteLine(item);    
}

var joined=string.Join('-',selectors);
Console.WriteLine(joined);


var hi = "hello";
var who = "laura";
var result = hi + " " + who;
Console.WriteLine(result);


