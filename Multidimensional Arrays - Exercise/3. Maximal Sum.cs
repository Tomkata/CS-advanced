namespace _2.SquaresinMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = data[0];
            int cols = data[1];
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = line[j];
                }
            }
            int sumMax = 0;
            int max = int.MinValue;
            int[,] maxMatrix = new int[3,3];
            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < cols - 2; j++)
                {
                    sumMax = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                        + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                        matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if (sumMax > max)
                    {
                        max = sumMax;
                        maxMatrix[0, 0] = matrix[i, j];
                        maxMatrix[0, 1] = matrix[i, j + 1];
                        maxMatrix[0, 2] = matrix[i, j + 2];
                        maxMatrix[1, 0] = matrix[i + 1, j];
                        maxMatrix[1, 1] = matrix[i + 1, j + 1];
                        maxMatrix[1, 2] = matrix[i + 1, j + 2];
                        maxMatrix[2, 0] = matrix[i + 2, j];
                        maxMatrix[2, 1] = matrix[i + 2, j + 1];
                        maxMatrix[2, 2] = matrix[i + 2, j + 2];

                    }
                }   
            }
            Console.WriteLine($"Sum = {max}");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(string.Format("{0} ", maxMatrix[i, j]));
                }
                Console.WriteLine();
            }
        }
    }
}
