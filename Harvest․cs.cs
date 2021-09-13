using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Polymorphism.Model
{
    abstract class Harvest
    {
        protected double _weight;
        protected string _taste; //qaxcr, ttu, dary
        public Harvest (double w)
        {
            _weight = w;
        }
        public abstract void ToRipe();
        public virtual void Place()
        {
            Console.WriteLine("From mainland.");
        }
    }
}
