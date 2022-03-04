
namespace CombineTwoArrays
{
    public static class Combine
    {
        public static List<int> CombineList(List<int> numbers1, List<int> numbers2)
        {
            var result = new List<int>();

            foreach (var num1 in numbers1)
            {
                result.Add(num1);
                Console.WriteLine(result);
            }

            foreach (var num2 in numbers2)
            {
                if (result.Contains(num2))
                {
                    continue;
                }

                result.Add(num2);
            }

            return result;
        }
        public static IEnumerable<int> CombineList2(IEnumerable<int> first, IEnumerable<int> second)
        {
            var result = new List<int>();
            result.AddRange(first);
            result.AddRange(second);
            return result.Distinct();
        }
        
        public static IEnumerable<int> CombineList3(IEnumerable<int> first, IEnumerable<int> second)
        {
            return first.Union(second);
        }
        
        public static List<int> CombineList4(List<int> first, List<int> second)
        {
            var result = new List<int>();
            foreach (var number in first)
                if(!result.Contains(number))
                    result.Add(number);
    
            foreach (var number in second)
                if(!result.Contains(number))
                    result.Add(number);
    
            return result;
        }
    }
}


