using System.Reflection.Metadata;

namespace _6.Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input is "Paid")
                {
                    Console.WriteLine(string.Join(Environment.NewLine,names));
                    names.Clear();
                    continue;
                }
                names.Enqueue(input);
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
