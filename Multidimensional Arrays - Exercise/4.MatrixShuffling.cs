namespace _4.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = data[0];
            int cols = data[1];
            string[,] matrix = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string swapCommand = commands[0];

                if (swapCommand == "swap")
                {
                    if (commands.Length!=5)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    int row1 = int.Parse(commands[1]);
                    int col1 = int.Parse(commands[2]);
                    int row2 = int.Parse(commands[3]);
                    int col2 = int.Parse(commands[4]);
                    if (row1 < 0 || row1 >= rows ||
                    col1 < 0 || col1 >= cols ||
                      row2 < 0 || row2 >= rows ||
                    col2 < 0 || col2 >= cols)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    string value = matrix[row2, col2];
                    string value2 = matrix[row1, col1];
                    matrix[row2, col2] = value2;
                    matrix[row1, col1] = value;

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            Console.Write(string.Format("{0} ", matrix[i, j]));
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
            }


        }
    }
}
