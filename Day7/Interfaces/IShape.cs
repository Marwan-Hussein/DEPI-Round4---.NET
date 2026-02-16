using System;
using static System.Console;

namespace Day7.Interfaces
{
    internal interface IShape
    {
        public double Area { get; }
        public void Draw();
        public void PrintDetails()
        {
            WriteLine($"Area: {Area}");
        }
    }

    internal class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area => Width * Height;
        public void Draw()
        {
            Repeat(" -", (int)Width);
            for (int i = 1; i < Height; i++)
            {
                WriteLine();
                Write("|");
                Repeat("  ", (int)Width);
                Write("|");
            }
            WriteLine();
            Repeat(" -", (int)Width);
            WriteLine();
        }
        private void Repeat(string tar, int times)
        {
            for (int i = 0; i < times; i++)
                Write(tar);
        }
    }

    internal class Circle : IShape
    {
        const double pi = 3.14;
        public double Radius { get; set; }
        public Circle(double r) { Radius = r; }
        public double Area => Math.Round(pi * Radius * Radius,2);
        public void Draw()
        {
            WriteLine($"r = {Radius}");
        }
    }
}
