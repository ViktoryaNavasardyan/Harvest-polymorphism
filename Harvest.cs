using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Polymorphism.Model
{
    abstract class Harvest
    {
        protected string _name;
        protected double _weight;
        protected string _metric;
        protected string _taste; //qaxcr, ttu, dary
        public Harvest (string name, double w, string m, string taste)
        {
            _name = name;
            _weight = w;
            _metric = m;
            _taste = taste;
        }
        private void HelpFunction(string currentMetric, string resultMetric)
        {
            if (_metric.Equals(currentMetric))
            {
                if (_weight >= 1000)
                {
                    _weight = _weight / 1000;
                    _metric = resultMetric;
                }
            }
        }
        public virtual void CheckMetric()
        {
            HelpFunction("g", "kg");
            HelpFunction("kg", "t");
        }
        public abstract void ToRipe();
        public abstract void Place();
        public virtual void  Show()
        {
            Console.Write($"Harvest = {_name},  weight = {_weight} {_metric},  taste = {_taste}, I am growing ");
            Place();
        }
    }
}
