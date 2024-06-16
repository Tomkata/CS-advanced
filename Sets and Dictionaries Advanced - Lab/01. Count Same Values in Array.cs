namespace LabSetsandDictionariesAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split().ToArray();

            Dictionary<string, int> numbers = new Dictionary<string, int>();
            foreach (var number in nums)
            {
                if(!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);
                }
                numbers[number]++;
            }
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
