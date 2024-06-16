namespace LabSetsandDictionariesAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var studentInfo = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);
                if (!studentInfo.ContainsKey(name))
                {
                    studentInfo.Add(name, new List<decimal>());
                }
                studentInfo[name].Add(grade);
            }
            foreach (var item in studentInfo)
            {
                Console.Write($"{item.Key} -> ");
                foreach (var grade in item.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {item.Value.Average():f2})");
            }
        }
    }
}
