namespace AddListProject
{
    public class AddingNumbersList
    {
        public List<int> Numbers { get; set; } = new List<int>();

        public void AddWithoutReturn(List<int> numbers)
        {
            Numbers = Numbers
                .Union(numbers)
                .ToList();
        }
    }
}