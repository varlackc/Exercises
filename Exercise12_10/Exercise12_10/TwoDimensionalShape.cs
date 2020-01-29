using System;

namespace Exercise12_10
{
    abstract class TwoDimensionalShape : Shape
    {
        public TwoDimensionalShape(double a) : base(a)
        {

        }

        public override abstract double Area { get; }
        public override string ToString()
        {
            return string.Format(" is a 2D Shape.");
        }
    }
}
