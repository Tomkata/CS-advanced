using System.Collections.Generic;
using System.Diagnostics;

namespace _7._HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] playersName = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            Queue<string> players = new Queue<string>();
            foreach (var item in playersName)
                players.Enqueue(item);

            while (players.Count>1)
            {
                for (int i = 0; i < n-1; i++)
                {
                   var patatoKid = players.Dequeue();
                    players.Enqueue(patatoKid);
                }
                var removedKid = players.Dequeue();
                Console.WriteLine($"Removed {removedKid}");
            }
            Console.WriteLine($"Last is {players.Dequeue()}");
        }
    }
}
