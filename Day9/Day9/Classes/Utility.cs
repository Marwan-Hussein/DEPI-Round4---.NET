using System;
using static System.Math;
namespace Day9.Classes
{
    internal static class Utility<T> where T : IComparable<T>
    {
        public static int RecPermeter(int w, int l) => 2 * (w + l);
        public static double Fehrenheit(double C) => Round(C * (9 / 5d) + 32 ,2);
        public static double Celsius(double F) => Round((F - 32) * (5 / 9d) ,2);
        public static T Max<T>(T x, T y)=> x.CompareTo(y) > 0 ? x : y;
    }
}
