// C# program to print all elements 
// of given matrix in diagonal order 
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.Arm;
using System.Security;
using static System.Math;

class GFG
{
    public static void Main()
    {
        int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

        int[,] matrix = new int[data[0], data[1]];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int[] line = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = line[j];
            }
        }

        int sum = 0;
        for (int i = 0; i < data[1]; i++)
        {
            for (int j = 0; j < data[0]; j++)
            {
                  sum+= matrix[j, i];   
            }
            Console.WriteLine(sum);
            sum = 0;
        }
       
    }
}
