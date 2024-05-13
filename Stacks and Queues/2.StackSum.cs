namespace _2.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stackNums = new Stack<int>();

            foreach (var number in numbers)
                stackNums.Push(number);

            string input;
            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] commands = input.Split();
                string function = commands[0];
                switch (function)
                {
                    case "add":
                        int num1 = int.Parse(commands[1]);
                        int num2 = int.Parse(commands[2]);
                        stackNums.Push(num1);
                        stackNums.Push(num2);
                        break;
                    case "remove":
                        int n = int.Parse(commands[1]);
                        while (n != 0 && n<=stackNums.Count)
                        {
                            stackNums.Pop();
                            n--;
                        }
                        break;
                }
            }
            Console.WriteLine($"Sum: {stackNums.Sum()}");

        }
    }
}
