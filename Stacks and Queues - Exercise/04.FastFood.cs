namespace _4.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> ordersQueue = new Queue<int>();
            foreach (var order in orders)
                ordersQueue.Enqueue(order);

            Console.WriteLine(ordersQueue.Max());
            while (ordersQueue.Count > 0)
            {
                if(quantityFood>= ordersQueue.Peek())
                {
                    quantityFood -= ordersQueue.Peek();
                    ordersQueue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ",ordersQueue)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
