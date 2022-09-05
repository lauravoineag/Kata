//Write a program that finds the summation of every number from 1 to num. The number will always be a positive integer greater than 0.
//For example:
//summation(2) -> 3
//1 + 2
//summation(8) -> 36
//1 + 2 + 3 + 4 + 5 + 6 + 7 + 8


var sum = 0;
var num = 3;

for(int i = 1; i <= num; i++)
{
    sum += i;
}
Console.WriteLine(sum);

//create sequence
var sequence = Enumerable.Range(1, num);
//sum it up
var sum2=sequence.Sum();
Console.WriteLine(sum2);

var sum3 = Enumerable.Range(1, num).Sum();
Console.WriteLine(sum3);









