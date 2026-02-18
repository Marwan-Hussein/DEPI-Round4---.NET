using static System.Math;
namespace Day8.Classes
{
    internal abstract class GeoShape
    { 
        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }
        
        public abstract double CalculateArea();
        public abstract double Permeter { get; }

        public override string ToString()
        {
            return $"{GetType().Name}: (d1 , d2) = ({Dimension1} , {Dimension2}).";
        }
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

        public TriangleShape(double d1, double d2, double d3)
        {
            Dimension1 = d1;
            Dimension2 = d2;
            Dimension3 = d3;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: (d1 , d2, d3) = ({Dimension1} , {Dimension2}, {Dimension3}).";
        }
    }
}
