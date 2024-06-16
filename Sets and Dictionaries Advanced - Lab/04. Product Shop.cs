using System;
using System.Collections.Generic;
using System.Linq;

namespace productShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops =
                new SortedDictionary<string, Dictionary<string, double>>();

            string input = Console.ReadLine();

            while (input != "Revision")
            {
                string[] splitted = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (!shops.ContainsKey(splitted[0]))
                {
                    shops[splitted[0]] = new Dictionary<string, double>();
                }
                if (!shops[splitted[0]].ContainsKey(splitted[1]))
                {
                    shops[splitted[0]].Add(splitted[1], double.Parse(splitted[2]));
                }


                input = Console.ReadLine();
            }



            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {(item.Value)}");
                }
            }
        }
    }
}
