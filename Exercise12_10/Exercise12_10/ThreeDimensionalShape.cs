using System;

namespace Exercise12_10
{
    abstract class ThreeDimensionalShape : Shape
    {
        public ThreeDimensionalShape(double a) : base(a)
        {

        }

        public override abstract double Area { get; }
        public abstract double Volume { get; }

        public override string ToString()
        {
            return string.Format(" is a 3D Shape.");
        }
    }
}
