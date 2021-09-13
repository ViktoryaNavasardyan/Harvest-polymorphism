using System;
using Dynamic_Polymorphism.Model;
using System.Collections.Generic;


namespace Dynamic_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var harvests = new List<Harvest> { new Fruit("apple", 2000, "kg", "sweet"), new Vegetable("tomatoes", 5.5, "kg", "normal"), new Berry("strawberry", 500, "g", "sweet and sour") };
            foreach (var harvest in harvests)
            {
                harvest.CheckMetric();
                harvest.Show();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("--------------Riping------------");
            Console.WriteLine();
            foreach (var harvest in harvests)
            {
                harvest.ToRipe();
                harvest.CheckMetric();
                harvest.Show();
                Console.WriteLine();
            }
            //Use IDried interface for fruits.
            Console.WriteLine("______________________Drying___________________________");
            Fruit fruit = new Fruit("grapes", 20, "kg");
            fruit.Show();
            fruit.Dried();
            fruit.ChangeName("raisins");
            fruit.Show();
            //Use IMarinate interface for vegetables.
            Console.WriteLine("_____________________Marinate__________________________");
            Vegetable vegetable = new Vegetable("cucumber", 3000, "g");
            vegetable.CheckMetric();
            vegetable.Show();
            vegetable.Marinate();
            vegetable.ChangeName("pickles");
            vegetable.Show();


            Console.ReadLine();
        }
    }
}
