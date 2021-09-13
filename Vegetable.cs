using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Polymorphism.Model
{
    class Vegetable : Harvest
    {
        public Vegetable(string name, double weight, Metric metric, Taste taste = Taste.unknown, State state = State.growing) : base(name, weight, metric, taste, state) { }

        public override void Ripe()
        {
            base.Ripe();
            _weight += 2 * _weight + 5;
        }
        public override void Dry() => throw new NotSupportedInterfaceException();
        public override void Location() => Console.WriteLine("in the ground.");

        public override void Show()
        {
            Console.Write($"Vegetable name = {_name},  weight = {_weight} {_metric}, state = {_state}, taste = {_taste}, I am growing ");
            Location();
        }
        
    }
}
