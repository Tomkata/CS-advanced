using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[][] matrix = new int[n][];
        for (int i = 0; i < n; i++)
        {
            int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            matrix[i] = new int[line.Length];
            for (int j = 0; j < line.Length; j++)
            {
                matrix[i][j] = line[j];
            }
        }
            
        for (int i = 0; i < matrix.Length-1; i++)
        {
            if (matrix[i].Length == matrix[i + 1].Length)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] *= 2;
                    matrix[i + 1][j] *= 2;
                }
            }
            else
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] /= 2;
                }
                for (int k = 0; k < matrix[i+1].Length; k++)
                {
                    matrix[i + 1][k] /= 2;
                }
            }
        }
        string input;

        while ((input=Console.ReadLine())!="End")
        {
            string[] data = input.Split();
            switch (data[0])
            {
                case "Add":
                    int row = int.Parse(data[1]);
                    int col = int.Parse(data[2]);
                    int value = int.Parse(data[3]);
                    if (row < 0 || row > matrix.Length ||
                        col < 0 || col >= matrix[row].Length)
                        continue;

                    matrix[row][col] += value;
                    break;
                case "Subtract":
                     row = int.Parse(data[1]);
                     col = int.Parse(data[2]);
                     value = int.Parse(data[3]);
                    if (row < 0 || row > matrix.Length ||
                        col < 0 || col >= matrix[row].Length)
                        continue;

                    matrix[row][col] -= value;
                    break;
            }
        }

        foreach (var item in matrix)
        {
            Console.WriteLine(string.Join(" ",item));
        }   


    }
}
