// C# program to print all elements 
// of given matrix in diagonal order 
using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using System.Security;
using static System.Math;

class GFG
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[][] arr = new int[n][];

        for (int i = 0; i < arr.Length; i++)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            arr[i] = new int[input.Length];

            for (int j = 0; j < input.Length; j++)
            {
                arr[i][j] = input[j];
            }
        }

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] data = command.Split();
            int row = int.Parse(data[1]);
            int col = int.Parse(data[2]);
            int value = int.Parse(data[3]);
            if (row < 0 || row >= arr.Length ||
                col < 0 || col >= arr[row].Length)
            {
                Console.WriteLine("Invalid coordinates");
                continue;
            }

            if (data[0] == "Add")
            {
                arr[row][col] += value;
            }
            else if (data[0]== "Subtract")
            {
                arr[row][col] -= value;
            }
        }

        for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(string.Join(" ", arr[i]));
           

    }
}
