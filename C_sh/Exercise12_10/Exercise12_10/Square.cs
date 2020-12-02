using System;

namespace Exercise12_10
{
    class Square : TwoDimensionalShape
    {
        public Square(double a) : base(a) { }

        public override double Area
        {
            get { return Math.Pow(base.Side, 2); }
        }

        public override string ToString()
        {
            return string.Format("Square") + base.ToString();
        }
    }
}
