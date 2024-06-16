using System.ComponentModel.Design;

namespace MatrixExersiseSoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] demenssions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            int row = demenssions[0];
            int col = demenssions[1];
            string[,] matrix = new string[row, col];
            string word = input;
            string letter = string.Empty;
            int j = 0;
            int k = 0;
            bool isTrue = false;
            for (int i = 0; i < row; i++)
            {

                while (true)
                {
                    if (i % 2 == 0)
                    {

                        if (k == word.Length)
                        {
                            k = 0;
                        }
                        if (col == j)
                        {
                            j = matrix.GetLength(1);
                            break;
                        }
                        letter = word[k++].ToString();

                        matrix[i, j++] = letter;
                    }
                    else
                    {
                        if (j==0)
                        {
                            break;
                        }

                        if (k == word.Length)
                        {
                            k = 0;
                        }
                        letter = word[k++].ToString();

                        matrix[i, j-1] = letter;
                        j--;
                    }
                }
                
            }

            for (int i = 0; i < row; i++)
            {
                for (int d = 0; d < col; d++)
                {
                    Console.Write($"{matrix[i, d]}");
                }
                Console.WriteLine();
            }
        }
    }

}
