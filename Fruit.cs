using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Polymorphism.Model
{
    class Fruit : Harvest
    {
        public Fruit ( string name, double weight, Metric metric, Taste taste = Taste.sour, State state = State.growing ) : base(name, weight, metric, taste , state){ }
        public override void Ripe()
        {
            base.Ripe();
            _weight += 2 * _weight + 1;
            _taste = Taste.sweet;
        }
        public override void Marinate() => throw new NotSupportedInterfaceException();
        public override void Location() => Console.WriteLine("on the trees.");

        public override void Show()
        {
            Console.Write($"Fruit name = {_name},  weight = {_weight} {_metric}, state = {_state}, taste = {_taste}, I am growing ");
            Location();
        }

    }
}
