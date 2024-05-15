namespace _03.MaximumandMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> sequence = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] commands = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                int commandNumber = commands[0];
               

                switch (commandNumber)
                {
                    case 1:
                        int number = commands[1];
                        sequence.Push(number);
                        break;
                    case 2:
                        if (sequence.Count is 0)
                            continue;
                        sequence.Pop();
                        break;
                    case 3:
                        if (sequence.Count is 0)
                            continue;
                        Console.WriteLine(sequence.Max());
                        break;
                    case 4:
                        if (sequence.Count is 0)
                            continue;
                        Console.WriteLine(sequence.Min());
                        break;
                }
            }
            Console.WriteLine(string.Join(", ",sequence));

        }
    }
}
