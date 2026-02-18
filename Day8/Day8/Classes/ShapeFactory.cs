using System;
namespace Day8.Classes
{
    internal static class ShapeFactory
    {
        public static GeoShape CreateShape(string type, double d1, double d2)
        {
            switch (type.ToLower())
            {
                case "rectangle":
                    return new RectangleShape(d1, d2);
                case "triangle":
                    return new TriangleShape(d1, d2);
                default:
                    throw new ArgumentException($"Shape type '{type}' is not supported.");
            }
        }
    }
}
