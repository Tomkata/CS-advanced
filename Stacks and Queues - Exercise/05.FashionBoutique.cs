using System.Runtime.CompilerServices;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography;

namespace _05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothesQuantities = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int capacityRack = int.Parse(Console.ReadLine());
            Stack<int> clothesQueue = new Stack<int>();

            foreach (var quantity in clothesQuantities)
                clothesQueue.Push(quantity);
            int sum = 0;
            int racksCount = 0;
            if (capacityRack == 0)
            {
                Console.WriteLine(0);
                return;
            }
            while (clothesQueue.Count>0)
            {
                if(sum+clothesQueue.Peek()==capacityRack)
                {
                    racksCount++;
                    clothesQueue.Pop();
                    sum = 0;
                    continue;
                }
                else if (sum + clothesQueue.Peek() > capacityRack)
                {
                    racksCount++;
                    sum = 0;
                    continue;
                }
                sum += clothesQueue.Pop();
            }
            if (sum > 0) racksCount++;
                Console.WriteLine(racksCount);
        }
    }
}
