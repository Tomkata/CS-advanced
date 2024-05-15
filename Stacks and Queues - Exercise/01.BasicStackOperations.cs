namespace _1.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsCommands = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Stack<int> numbersStack = new Stack<int>();
            int pusheItems = numsCommands[0];
            int popItems = numsCommands[1];
            int isContainedItem = numsCommands[2];
            for (int i = 0; i < pusheItems; i++)
                numbersStack.Push(numbers[i]);

            for (int i = 0; i < popItems; i++)
                numbersStack.Pop();

            if (numbersStack.Count is 0) 
            {
            Console.WriteLine(0);
                return;
            }
            if (numbersStack.Contains(isContainedItem))
                Console.WriteLine("true");

            else Console.WriteLine(numbersStack.Min());
        }
    }
}
