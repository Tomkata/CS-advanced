namespace matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = sizeOfMatrix[0];
            int[,] matrix = new int[n, n];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            string[] coordinates = Console.ReadLine().Split();
            //Find the coordinates
            List<int[]> coordinate = new List<int[]>();
            foreach (var item in coordinates)
            {
                int row1 = int.Parse(item[0].ToString());
                int col1 = int.Parse(item[2].ToString());

                coordinate.Add(new int[] { row1, col1 });
            }
            foreach (var item in coordinate)
            {
                int row = item[0];
                int col = item[1];
                if (matrix[row,col]<0)
                {
                    continue;
                }
                if (IsInside(matrix, row + 1, col) && matrix[row + 1, col] > 0)//up
                {
                    matrix[row + 1, col] -= matrix[row,col];
                }
                if (IsInside(matrix, row - 1, col) && matrix[row - 1, col] > 0)//up
                {
                    matrix[row - 1, col] -= matrix[row, col]; ;//down
                }
                if (IsInside(matrix, row, col - 1) && matrix[row, col - 1] > 0)//left
                {
                    matrix[row, col - 1] -= matrix[row, col]; ;
                }
                if (IsInside(matrix, row, col + 1) && matrix[row, col + 1] > 0)//right
                {
                    matrix[row, col + 1] -= matrix[row, col];
                }
                if (IsInside(matrix, row + 1, col + 1) && matrix[row + 1, col + 1] > 0)//right up diagonal
                {
                    matrix[row + 1, col + 1] -= matrix[row, col];
                }
                if (IsInside(matrix, row + 1, col - 1) && matrix[row + 1, col - 1] > 0)//left up diagonal
                {
                    matrix[row + 1, col - 1] -= matrix[row, col];
                }
                if (IsInside(matrix, row - 1, col - 1) && matrix[row - 1, col - 1] > 0)//left down diagonal
                {
                    matrix[row - 1, col - 1] -= matrix[row, col];
                }
                if (IsInside(matrix, row - 1, col + 1) && matrix[row - 1, col + 1] > 0)//right down diagonal
                {
                    matrix[row - 1, col + 1] -= matrix[row, col];
                }
                matrix[row, col] = 0;
            }
            int countCells = 0;
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        countCells++;
                        sum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {countCells}");
            Console.WriteLine($"Sum: {sum}");
            Print(matrix);
        }
        private static bool IsInside(int[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                col >= 0 && col < matrix.GetLength(1);
        }
        private static void Print(int[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();    
            }
        }
    }
}
