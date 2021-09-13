using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Polymorphism.Model
{
    abstract class Harvest: IMarinate, IDry
    {
        protected string _name;
        protected double _weight;
        protected Metric _metric;
        protected Taste _taste;
        protected State _state;
        public Harvest (string name, double weight, Metric metric, Taste taste = Taste.unknown, State state = State.unknown)
        {
            if (weight >= 0
                && (metric == Metric.g || metric == Metric.kg || metric == Metric.t)
                && (taste == Taste.acrid || taste == Taste.salty || taste == Taste.sour || taste == Taste.sweet || taste == Taste.unknown)
                && (state == State.unknown || state == State.dried || state == State.growing || state == State.marinated || state == State.riped))
            {
                _name = name;
                _weight = weight;
                _metric = metric;
                CheckMetric();
                _taste = taste;
                _state = state;
            }
            else
            {
                throw new InvalidParameterException();
            }
        }
        private void AdjustMetric(Metric currentMetric, Metric resultMetric)
        {
            if (_metric == currentMetric)
            {
                if (_weight >= 1000)
                {
                    _weight = _weight / 1000;
                    _metric = resultMetric;
                }
            }
        }
        private void CheckMetric()
        {
            AdjustMetric(Metric.g, Metric.kg);
            AdjustMetric(Metric.kg , Metric.t);
        }
        public virtual void Ripe() => _state = State.riped;
        public abstract void Location();
        public virtual void Show()
        {
            Console.Write($"Harvest = {_name},  weight = {_weight} {_metric}, state = {_state},  taste = {_taste}, I am growing ");
            Location();
        }
        public virtual void Marinate()
        {
            _taste = Taste.sour;
            _state = State.marinated;
        }
        public virtual void Dry()
        {
            _weight = _weight / 2;
            _state = State.dried;

        }
    }
    enum Metric
    {
        g,
        kg,
        t,
        piece
    }
    enum Taste
    {
        unknown,
        sweet,
        sour,
        acrid,
        salty
    }
    enum State
    {
        unknown,
        growing,
        riped,
        dried,
        marinated
    }
}
