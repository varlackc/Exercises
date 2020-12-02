using System;

namespace Exercise12_10
{
    class Circle : TwoDimensionalShape
    {
        public Circle(double a) : base(a) { }

        public override double Area
        {
            get { return Math.PI * Math.Pow(base.Side,2); }
        }

        public override string ToString()
        {
            return string.Format("Circle") + base.ToString();
        }
    }
}
