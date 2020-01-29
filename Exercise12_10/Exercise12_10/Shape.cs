using System;

namespace Exercise12_10
{
    abstract class Shape
    {

        public Shape (double sideSize)
        {
            Side = sideSize;
        }

        public double Side { get; set; }

        public abstract double Area { get; }
        public abstract override string ToString();
    }
}
