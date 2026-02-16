using System;
namespace Day7.Classes
{
    internal abstract class Shape
    {
        public virtual void Draw()
        {
            System.Console.WriteLine("Drawing a shape");
        }

        public abstract double CalculateArea();
    }

    internal class RectanglePb10 : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public RectanglePb10(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override void Draw()
        {
            System.Console.WriteLine($"Drawing a rectangle with width {Width} and height {Height}");
        }
        public override double CalculateArea()
        {
            return Math.Round(Width * Height,2);
        }
    }
}
