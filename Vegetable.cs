﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Polymorphism.Model
{
    class Vegetable : Harvest
    {
        string _name;
        string Taste
        {
            get => _taste;
            set => _taste = value;
        }
        public Vegetable(double weight, string name, string taste) : base(weight)
        {
            _name = name;
            Taste = taste;
        }
        public override void ToRipe()
        {
            _weight += 2 * _weight + 5;
            Console.WriteLine("The vegetable has riped.");
        }
        public override void Place()
        {
            Console.WriteLine("In the ground.");
        }

    }
}
