using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10.Classes
{
    internal static class Statics<T> where T: IComparable
    {
    public delegate bool CompareDelegate(T a, T b);
        public static bool Greater(T a, T b) => a.CompareTo(b) > 0;
        public static bool Smaller(T a, T b) => a.CompareTo(b) < 0;

        public static void Swap(ref T a, ref T b)
        {
            (a, b) = (b, a);
        }
        public static void Sort(T[] array, CompareDelegate del)
        { 
            for(int i=0;i < array.Length;i++)
                for(int j=0; j< array.Length;j++)
                    if (del(array[i], array[j]))
                        Swap(ref array[j],ref array[i]);
        
        }
        public static void SortingTwo(T[] array, Func<T, T, bool> PrimaryDel)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length; j++)
                    if (PrimaryDel(array[i], array[j]))
                        Swap(ref array[j], ref array[i]);

        }
    }
}
