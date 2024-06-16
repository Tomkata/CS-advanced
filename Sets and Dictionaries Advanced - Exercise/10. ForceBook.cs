using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> forceUsers = new Dictionary<string, string>();

        string input;
        while ((input = Console.ReadLine()) != "Lumpawaroo")
        {
            string[] tokens = input.Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries);
            string forceUser = tokens[1];
            string forceSide = tokens[0];

            if (input.Contains("|"))
            {
                if (!forceUsers.ContainsKey(forceUser))
                {
                    forceUsers.Add(forceUser, forceSide);
                }
            }
            else if (input.Contains("->"))
            {
                forceUser = tokens[0];
                 forceSide = tokens[1];

                if (forceUsers.ContainsKey(forceUser))
                {
                    forceUsers[forceUser] = forceSide;
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
                else
                {
                    forceUsers.Add(forceUser, forceSide);
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
            }
        }

        var sides = forceUsers.GroupBy(pair => pair.Value)
                              .OrderByDescending(group => group.Count())
                              .ThenBy(group => group.Key);

        foreach (var side in sides)
        {
            Console.WriteLine($"Side: {side.Key}, Members: {side.Count()}");
            foreach (var forceUser in side.OrderBy(pair => pair.Key))
            {
                Console.WriteLine($"! {forceUser.Key}");
            }
        }
    }
}
