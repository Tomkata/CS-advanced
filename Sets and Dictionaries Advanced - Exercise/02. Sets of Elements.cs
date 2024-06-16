using System.Linq;
using System.Xml.Schema;

namespace ExercisesSetsandDictionariesAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = arr[0];
            int m = arr[1];
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                set1.Add(number);
            }
            for (int i = 0; i < m; i++)
            {
                int number = int.Parse(Console.ReadLine());
                set2.Add(number);
            }
            var sameNumbers = set1.Intersect(set2);
            Console.WriteLine(string.Join(" ",sameNumbers));
        }
    }
}
