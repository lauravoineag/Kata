using AddListProject;

var numbers1 = new List<int> {1,12,8,7,6,2,10,20};
var numbers2 = new List<int> {2,8,3,7,5,11,6,13};

AddingNumbersList addingNumbersList = new AddingNumbersList();
addingNumbersList.AddWithoutReturn(numbers1);
addingNumbersList.AddWithoutReturn(numbers2);

foreach (var combined in addingNumbersList.Numbers)
{
 Console.WriteLine(combined);   
}

Console.WriteLine("test");

