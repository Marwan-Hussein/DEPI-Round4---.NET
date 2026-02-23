using System;
using static System.Math;
namespace Day9.Classes
{
    internal static class Utility
    {
        public static int RecPermeter(int w, int l) => 2 * (w + l);
        public static double Fehrenheit(double C) => Round(C * (9 / 5d) + 32 ,2);
        public static double Celsius(double F) => Round((F - 32) * (5 / 9d) ,2);
        public static T Max<T>(T x, T y) where T : IComparable<T>
            => x.CompareTo(y) > 0 ? x : y;
        public static T[] SearchArray<T>(T[] arr, T item)
        {
            T[] res = new T[arr.Length];
            for (int i = 0,j=0; i < arr.Length; i++)
                if (arr[i].Equals(item))
                    res[j++] = arr[i];
            return res??null;
        }

        public static void Replace<T>(T[] arr, T oldItem, T newItem)
        {
            for(int i=0; i< arr.Length; i++)
                if(arr[i].Equals(oldItem))
                    arr[i] = newItem;
        }
    }
}
