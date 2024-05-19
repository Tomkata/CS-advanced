using System;
using System.Linq;

namespace ConsoleApp67
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[data[0], data[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = line[j];
                }
            }
            int sum = 0;
            Console.WriteLine(data[0]);
            Console.WriteLine(data[1]);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
