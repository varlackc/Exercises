using System;

namespace Exercise12_10
{
    class Sphere : ThreeDimensionalShape
    {
        public Sphere(double a) : base(a) { }

        public override double Area
        {
            get { return Math.PI * 4 * Math.Pow(base.Side,2); }
        }

        public override double Volume
        {
            get { return (4 * Math.PI * Math.Pow(base.Side,3)) / 3; }
        }

        public override string ToString()
        {
            return string.Format("Sphere") + base.ToString();
        }
    }
}
