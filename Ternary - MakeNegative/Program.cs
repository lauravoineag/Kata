public static class Kata
{
    public static int MakeNegative(int number)
    {
        return number < 1 ? number :- number;
        //if(number < 1){return number;}
        //return - number;
    }
}

//Source: https://www.tutorialsteacher.com/csharp/csharp-ternary-operator

public class Cockroach
{
    public static int CockroachSpeed(double x)
    {
        //0.036 km/h in cm/s.
        //cm/s = km/h ÷ 0.036
     
        return  (int) (x / 0.036); 
      
        //Result:
        //75 km/h is equal to 2,083.3333333333 cm/s
    }
}
