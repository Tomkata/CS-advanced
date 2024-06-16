using System.Diagnostics.CodeAnalysis;

namespace matric2x2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];
            int max = int.MinValue;
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            int[,] maxMatix = new int[2, 2];
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    int currSum = matrix[row, col] + matrix[row + 1, col] 
                        + matrix[row, col + 1] + matrix[row + 1, col + 1];

                    if (currSum > max)
                    {

                        maxMatix[0, 0] = matrix[row, col];
                        maxMatix[0, 1] = matrix[row + 1, col];
                        maxMatix[1, 0] = matrix[row, col + 1];
                        maxMatix[1, 1] = matrix[row + 1, col + 1];
                        max = currSum;
                    }
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(maxMatix[j, i]+" "); 
                }
                Console.WriteLine();
            }
            Console.WriteLine(max);
        }
    }
}
