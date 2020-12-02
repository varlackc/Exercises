using System;

namespace Exercise12_10
{
    class Cube : ThreeDimensionalShape
    {
        public Cube(double a) : base(a) { }

        public override double Area
        {
            get { return 6 * Math.Pow(base.Side,2); }
        }

        public override double Volume
        {
            get { return Math.Pow(base.Side,3); }
        }

        public override string ToString()
        {
            return string.Format("Cube") + base.ToString();
        }
    }
}
