using System.Globalization;

namespace sasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reservation = new HashSet<string>();
            string input;
            while ((input=Console.ReadLine())!="PARTY")
            {
                reservation.Add(input);
            }
            string INPUT2;
            while ((INPUT2 = Console.ReadLine()) != "END")
            {
                reservation.Remove(INPUT2);
            }
            
            var reservationOrder = new HashSet<string>();
            foreach (var item in reservation)
            {
                char a = item[0];
                if (char.IsDigit(a))
                {
                    reservationOrder.Add(item);
                    reservation.Remove(item);
                }
            }
            int cout = reservation.Count + reservationOrder.Count;
            Console.WriteLine(cout);

            foreach (var item in reservationOrder)
            {
                Console.WriteLine(item);
            }
            foreach (var item in reservation)
            {
                Console.WriteLine(item);
            }
        }
    }
}
