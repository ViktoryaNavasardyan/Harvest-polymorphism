using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Polymorphism.Model
{
    class Vegetable : Harvest, IMarinate
    {
        public Vegetable(string name, double weight, string metric, string taste) : base(name, weight, metric, taste) { }

        public Vegetable(string name, double weight, string metric) : base(name, weight, metric, null) { }
        public override void ToRipe()
        {
            _weight += 2 * _weight + 5;
            Console.WriteLine("The vegetable has riped.");
        }
        public override void Place()
        {
            Console.WriteLine("In the ground.");
        }
        public void Marinate()
        {
            _taste = "sour";
        }
        public void ChangeName(string newName)
        {
            _name = newName;
        }
        public override void Show()
        {
            Console.Write($"Vegetable name = {_name},  weight = {_weight} {_metric},  taste = {_taste}, I am growing ");
            Place();
        }
        
    }
}
