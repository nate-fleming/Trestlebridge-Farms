using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class chooseDuckHouse
    {
        public static void CollectInput(List<DuckHouse> houses, Duck duck)
        {
            Console.Clear();

            for (int i = 0; i < houses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. DuckHouse: {houses[i].Name}");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the duck where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            houses[choice - 1].AddResource(duck);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}