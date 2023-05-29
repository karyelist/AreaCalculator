﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Areas
{
    public class Circle:ShapeArea
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;    
        }

        public override double Area()
        {
            return Radius * Radius *Math.PI; 
        }
    }
}
