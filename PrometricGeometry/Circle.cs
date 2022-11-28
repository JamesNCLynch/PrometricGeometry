﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrometricGeometry
{
    public class Circle : Shape
    {
        private const decimal Pi = 3.14m;
        public decimal Radius { get; set; }

        public Circle(decimal r) { Radius = r; }

        public override decimal Area()
        {
            return Pi * Radius * Radius;
        }

        public override string Name()
        {
            return this.GetType().Name;
        }

        public override decimal Perimeter()
        {
            return 2 * Pi * Radius;
        }
    }
}
