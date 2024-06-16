using System.Globalization;

namespace sasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cities = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string continent = data[0];
                string country = data[1];
                string citie = data[2];
                if (!cities.ContainsKey(continent))
                {
                    cities.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!cities[continent].ContainsKey(country))
                {   
                    cities[continent].Add(country, new List<string>());
                }
                cities[continent][country].Add(citie);

            }
            foreach (var item in cities)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var location in item.Value)
                {
                    Console.WriteLine($"  {location.Key} -> {string.Join(", ", location.Value)}");
                }
            }
        }
    }
}
