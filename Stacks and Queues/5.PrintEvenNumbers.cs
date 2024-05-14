namespace PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> nums = new Queue<int>();
            foreach (var num in arr)
                nums.Enqueue(num);

            var even = nums.Where(x => x % 2 == 0).ToArray();
            Console.WriteLine(string.Join(", ",even));
        }
    }
}
