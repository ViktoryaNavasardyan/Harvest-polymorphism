using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Polymorphism.Model
{
    class Berry : Harvest
    {
        public Berry(string name, double weight, Metric metric, Taste taste = Taste.sour, State state = State.growing) : base(name, weight, metric, taste, state) { }
        public override void Ripe()
        {
            base.Ripe();
            _taste = Taste.sweet;
            _weight += (1.5 * _weight) + 1;
        }
        public override void Marinate() => throw new NotSupportedInterfaceException();
        public override void Dry() => throw new NotSupportedInterfaceException();
        public override void Location() => Console.WriteLine("on the bush.");
        public override void Show()
        {
            Console.Write($"Berry name = {_name},  weight = {_weight} {_metric}, state = {_state}, taste = {_taste}, I am growing ");
            Location();
        }
    }
}
