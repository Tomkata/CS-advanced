using System.Security.Cryptography;

namespace _6.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Blue -> dress,jeans,hat
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" -> ");
                string color = data[0];
                string[] clothes = data[1].Split(",");
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrobe[color].ContainsKey(clothes[j]))
                    {
                        wardrobe[color].Add(clothes[j], 0);
                    }
                    wardrobe[color][clothes[j]]++;
                }
            }
            string[] searhGarmentInfo = Console.ReadLine().Split();
            string searchColor = searhGarmentInfo[0];
            string searchGarment = searhGarmentInfo[1];
            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var clothes in item.Value)
                {
                    if (clothes.Key== searchGarment && item.Key==searchColor)
                    {
                        Console.WriteLine($"* {clothes.Key} - {clothes.Value} (found!)");
                        continue;
                    }
                    Console.WriteLine($"* {clothes.Key} - {clothes.Value}");
                }
            }

        }
    }
}
