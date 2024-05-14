namespace _8.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string input;
            Queue<string> cars = new Queue<string>();
            int passedCount = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                string model = input;
                if (input == "green")   
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count == 0) break;
                        var carPassed = cars.Dequeue();
                        Console.WriteLine($"{carPassed} passed!");
                        passedCount++;
                    }
                    continue;
                }
                cars.Enqueue(model);
            }
            Console.WriteLine($"{passedCount} cars passed the crossroads.");
        }
    }
}
