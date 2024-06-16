using System.Globalization;

namespace sasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> threeMax = new List<int>();
           int[] numms = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] a = new int[3];
            threeMax = numms.OrderByDescending(x=>x).Take(3).ToList();
                

            Console.WriteLine(string.Join(" ", threeMax));

        }
    }
}
