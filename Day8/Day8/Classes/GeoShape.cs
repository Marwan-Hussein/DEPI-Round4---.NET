using System;
using static System.Math;
namespace Day8.Classes
{
    internal abstract class GeoShape : IComparable<GeoShape>
    { 
        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }
        
        public abstract double CalculateArea();
        public abstract double Permeter { get; }

        public override string ToString()
        {
            return $"{GetType().Name}: (d1 , d2) = ({Dimension1} , {Dimension2})\tArea={CalculateArea()}";
        }

        public int CompareTo(GeoShape shape)
        {
            if (shape == null)
                return 1;
            return (int)(CalculateArea() - shape.CalculateArea());
        }
        //public static bool operator <(GeoShape a, GeoShape b) { return a.CalculateArea() < b.CalculateArea(); }
        //public static bool operator >(GeoShape a, GeoShape b) { return a.CalculateArea() > b.CalculateArea(); }

    }

    internal class RectangleShape : GeoShape
    {
        public override double CalculateArea() => Round(Dimension1 * Dimension2,2);
        public override double Permeter 
        { 
            get => Round(2 * (Dimension1 + Dimension2),2);
        }

        public RectangleShape(double d1, double d2)
        {
            Dimension1 = d1;
            Dimension2 = d2;
        }
    }

    internal class TriangleShape : GeoShape
    {
        public double Dimension3 { get; set; }
        public override double CalculateArea() => Round(0.5 * Dimension1 * Dimension2,2);
        public override double Permeter
        {
            get => Round(Dimension1 + Dimension2 + Dimension3, 2);
        }

        public TriangleShape(double d1, double d2, double d3=1)
        {
            Dimension1 = d1;
            Dimension2 = d2;
            Dimension3 = d3;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: (d1 , d2, d3) = ({Dimension1} , {Dimension2}, {Dimension3})\tArea={CalculateArea()}";
        }
    }
}
