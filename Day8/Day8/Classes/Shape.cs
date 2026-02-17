using System;
using static System.Math;
namespace Day8.Classes
{
    internal abstract class Shape
    {
        public abstract double GetArea();
        public virtual void Display()
        {
            Console.WriteLine("SHAPE IS DRAWN...");
        }
    }

    internal class Rectangle : Shape
    {
        public double W { get; set; }
        public double H { get; set; }

        public Rectangle(double w, double h) { W = w; H = h; }
        public override double GetArea() 
        { 
            return Round(W * H,2); 
        }
        public override void Display()
        {
            //Console.WriteLine($"Rectangle is drawn with {{W= {W}, H= {H}}}");
            for(int i = 0; i < H; ++i)
            {
                for(int j = 0; j < W; ++j)
                    Console.Write('*');
                Console.WriteLine();
            }
        }
    }

    internal class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius) { Radius = radius; }
        public override double GetArea() 
        { 
            return Round(PI * Pow(Radius, 2), 2);
        }
        public override void Display()
        {
            Console.WriteLine($"Circle is drawn with {{Radius= {Radius}}}");
        }
        }
    }
