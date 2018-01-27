using System;
using System.Collections.Generic;


namespace CarSets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an empty HashSet named Showroom that will contain strings.
            //Add four of your favorite car model names to the set.
            var Showroom = new HashSet<string>
            {

                "Shelby GT",
                "911",
                "Model 3",
                "Model 4"

            };

            //Print to the console how many cars are in your show room
            Console.WriteLine($"You have {Showroom.Count} cars in your show room");

            foreach (var car in Showroom)
            {
                Console.WriteLine($"The cars in your showroom are {car}");
            }

            //Pick one of the items in your show room and add it to the set again.
            Showroom.Add("Shelby GT");

            //Print your showroom again, and notice how there's still only one representation of that model in there.
            Console.WriteLine($"You now have {Showroom.Count} cars in your show room now");
            foreach (var car in Showroom)
            {
                Console.WriteLine($"The cars in your showroom now are {car}");
            }

            //Create another set named UsedLot and add two more car model strings to it.
            var UsedLot = new HashSet<string>
            {
                "Used Car 1",
                "Used Car 2"
            };

            //Use the UnionWith() method on Showroom to add in the two models you added to UsedLot.
            Showroom.UnionWith(UsedLot);

            foreach (var car in Showroom)
            {
                Console.WriteLine(car);
            }

            //You've sold one of your cars. Remove it from the set with the Remove() method.
            Showroom.Remove("Used Car 2");

            //Now create another HashSet of cars in a variable Junkyard. 
            //Someone who owns a junkyard full of old cars has approached you about buying the entire inventory. 
            //In the new set, add some different cars, but also add a few that are the same as in the Showroom set.
            var JunkYard = new HashSet<string>
            {
                "Model 5",
                "Model 6",
                "911",
                "Used Car 1"
            };

            //Use the IntersectWith() method to see which cars exist in both the show room and the junkyard.
            Showroom.IntersectWith(JunkYard);

            //Now you're ready to buy the cars in the junkyard. 
            //Use the UnionWith() method to combine the junkyard into your showroom.
            Showroom.UnionWith(JunkYard);

            JunkYard.Remove("911");
            JunkYard.Remove("Model 5");

            foreach (var car in Showroom)
            {
                Console.WriteLine($"This is a car: {car}");
            }

            Console.ReadLine();
        }
    }
} 
