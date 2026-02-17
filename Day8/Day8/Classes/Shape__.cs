using System;

namespace Day8.Classes
{
    internal class Shape__ : IComparable
    {
        public string Name { get; set; }
        public double Area { get; set; }
         public Shape__(string name, double area)
        {
            Name = name;
            Area = area;
        }

        public int CompareTo(object obj)
        {
            if (obj is Shape__ s)
            {
                int tar = Area.CompareTo(s.Area);
                return tar == 0? Name.CompareTo(s.Name) : tar;
            }
            else
            {
                throw new ArgumentException("Object is not a Shape__");
            }
        }

        public override string ToString()
        {
            return $"Shape: {Name}, Area: {Area}";
        }
    }
}
