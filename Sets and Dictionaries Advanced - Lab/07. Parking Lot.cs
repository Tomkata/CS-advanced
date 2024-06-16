using System.Globalization;

namespace sasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carPlate = new HashSet<string>();
            
            string input;
            while ((input=Console.ReadLine())!="END")
            {
                string[] data = input.Split(", ");
                string direction = data[0];
                string plate= data[1];
                if (direction == "IN")
                {
                    carPlate.Add(plate);
                }
                else if (direction=="OUT")
                {
                    carPlate.Remove(plate);
                }
            }
            if (carPlate.Count is 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }
            foreach (var item in carPlate)
            {
                Console.WriteLine(item);
            }
        }
    }
}
