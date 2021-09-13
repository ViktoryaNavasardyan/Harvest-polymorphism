using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Polymorphism.Model
{
    class Fruit : Harvest, IDried
    {
        public Fruit ( string name, double weight, string metric, string taste) : base(name, weight, metric, taste){ }
        public Fruit(string name, double weight, string metric) : base(name, weight, metric, null) { }
        public override void ToRipe()
        {
            _weight += 2 * _weight + 1;
            Console.WriteLine("The fruit has riped.");
        }
        public override void Place()
        {
            Console.WriteLine("On the trees.");
        }
        public void Dried()
        {
            _weight -= _weight / 2;
        }
        public void ChangeName(string newName)
        {
            _name = newName;
        }
        public override void Show()
        {
            Console.Write($"Fruit name = {_name},  weight = {_weight} {_metric},  taste = {_taste}, I am growing ");
            Place();
        }
    }
}
