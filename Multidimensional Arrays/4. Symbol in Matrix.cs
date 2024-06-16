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
        int n = int.Parse(Console.ReadLine());
        char[,] matrix = new char[n,n];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            char[] line = Console.ReadLine().ToCharArray();
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = line[j];
            }
        }


        char symbol = char.Parse(Console.ReadLine());
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {

                if (symbol == matrix[i, j])
                {
                    Console.WriteLine($"({i}, {j})");
                    return;
                }
            }
        }
        Console.WriteLine($"{symbol} does not occur in the matrix");

    }
}
