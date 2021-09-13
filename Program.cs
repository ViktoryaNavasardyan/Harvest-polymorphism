using System;
using Dynamic_Polymorphism.Model;
using System.Collections.Generic;


namespace Dynamic_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating harvests and checking Dry and Marinate methods
            CreatingHarvests();

            //checking exceptions
            ChechkingExceptions();

            Console.ReadLine();
        }

        static void CreatingHarvests()
        {
            //creating harvests
            var harvests = new List<Harvest>()
            {
                new Fruit("Apples", 200, Metric.kg),
                new Fruit("Grapes", 20, Metric.kg, Taste.sweet, State.riped),
                new Vegetable ("Tomatoes", 5, Metric.kg, Taste.unknown, State.unknown),
                new Vegetable ("Cucumbers", 10, Metric.kg),
                new Berry("Raspberrys", 500, Metric.g, Taste.sweet),
                new Berry("Strawberryս", 700, Metric.g)
            };
            Console.WriteLine("All harvest---->");
            foreach (var item in harvests)
            {
                item.Show();
            }
            Console.WriteLine();

            //checking Dry method
            harvests[0].Dry();
            harvests[1].Dry();
            Console.WriteLine("Dried fruits:");
            harvests[0].Show();
            harvests[1].Show();
            Console.WriteLine();
            //checking Marinate method
            harvests[2].Marinate();
            harvests[3].Marinate();
            Console.WriteLine("Marinate vegetables:");
            harvests[2].Show();
            harvests[3].Show();
            Console.WriteLine();
            //checking Rise method
            Console.WriteLine("Rised harvests:");
            foreach(var harvest in harvests)
            {
                harvest.Ripe();
                harvest.Show();
            }
            Console.WriteLine();
        }
        static void ChechkingExceptions()
        {
            Console.WriteLine("_________________________________Exeptions______________________________________________");
            try
            {
                Harvest harvest2 = new Fruit("Banana", -2, Metric.piece);
                harvest2.Show();
            }
            catch (InvalidParameterException)
            {
                Console.WriteLine("Invalid parametr.");
            }
            try
            {
                Harvest harvest3 = new Vegetable("Onion", 5, Metric.kg);
                harvest3.Show();
                harvest3.Dry();
            }
            catch (NotSupportedInterfaceException)
            {
                Console.WriteLine("This operation was not supported.");
            }
        }
    }
}
