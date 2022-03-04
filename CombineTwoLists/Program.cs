using CombineTwoArrays;

    var numbers1 = new List<int> {1,12,8,7,6,2,10,20};
    var numbers2 = new List<int> {2,8,3,7,5,11,6,13};

    var combinedLists = Combine.CombineList(numbers1, numbers2);
    foreach (var number in combinedLists.OrderBy(x => x))
    {
        Console.WriteLine(number);
    }

    var combineList2 = Combine.CombineList2(numbers1, numbers2);
    {
        {
            Console.WriteLine(combineList2);
        } 
    }

    var combineList3 = Combine.CombineList3(numbers1, numbers2);
    {
        Console.WriteLine(combineList3);
    }

    var combineList4 = Combine.CombineList4(numbers1, numbers2);
    { 
        Console.WriteLine(combineList4);
    }