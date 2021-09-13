using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Polymorphism.Model
{
    class Berry : Harvest
    {
        public Berry(string name, double weight, string metric, string taste) : base(name, weight, metric, taste){ }
        public override void ToRipe()
        {
            _weight += 1.5 * _weight + 1;
            Console.WriteLine("The berry has riped.");
        }
        public override void Place()
        {
            Console.WriteLine("On the bush");
        }
        public override void Show()
        {
            Console.Write($"Berry name = {_name},  weight = {_weight} {_metric},  taste = {_taste}, I am growing ");
            Place();
        }
    }
}
