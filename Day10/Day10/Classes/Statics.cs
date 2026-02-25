using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10.Classes
{
    internal static class Statics<T> where T: IComparable
    {
        #region for Comparisson delegates
        public delegate bool CompareDelegate(T a, T b);
        public static bool Greater(T a, T b) => a.CompareTo(b) > 0;
        public static bool Smaller(T a, T b) => a.CompareTo(b) < 0;
        #endregion

        #region for strings delegates pb11
        public delegate string StringsDelegate(string s);
        public static string Upper(string str) => str.ToUpper();
        public static string Lower(string str) => str.ToLower();
        public static string Reverse(string str) 
        {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length-1; i >= 0; i--)
                sb.Append(str[i]);
            return sb.ToString();        
        }

        public static void TransformStrList(string[] list, StringsDelegate strDelegate)
        {
            for(int i=0; i < list.Length; i++)
                list[i] = strDelegate(list[i]);
        }
        #endregion

        #region int to int pb12
        public delegate int IntDelegate(int a, int b);
        public static int Add(int a,int b) => a + b;
        public static int Sub(int a, int b) => a - b;
        public static int Mult(int a, int b) => a * b;
        public static int Div(int a, int b) => a / b;
        public static int OpInt(int a, int b, IntDelegate del) => del(a,b);
        #endregion

        #region delegate T to R
        public delegate R Transformer<T, R>(T item);
        public static R[] TransformList<R>(T[] arr, Transformer<T,R> transformer)
        {
            R[] res = new R[arr.Length];
            for(int i= 0; i<arr.Length; ++i)
                res[i] = transformer(arr[i]);
            return res;
        }
        #endregion

        #region squaring
        public static T[] PerformFnc<T>(T[] arr, Func<T, T> func)
        {
            T[] res = new T[arr.Length];
            for(int i=0; i<arr.Length; i++)
                res[i] = func(arr[i]);
            return res;
        }
        #endregion
        public static void Swap(ref T a, ref T b)
        {
            (a, b) = (b, a);
        }
        #region sorting
        public static void Sort(T[] array, CompareDelegate del)
        { 
            for(int i=0;i < array.Length;i++)
                for(int j=0; j< array.Length;j++)
                    if (del(array[i], array[j]))
                        Swap(ref array[j],ref array[i]);
        
        }
        public static T[] SortRetArr(T[] arr, Func<T, T, bool> del)
        {
            T[] res = (T[])arr.Clone();
            for (int i = 0; i < res.Length; i++)
                for (int j = 0; j < res.Length; j++)
                    if (del(res[i], res[j]))
                        Swap(ref res[j], ref res[i]);
            return res;
        }
        public static void SortingTwo(T[] array, Func<T, T, bool> PrimaryDel)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length; j++)
                    if (PrimaryDel(array[i], array[j]))
                        Swap(ref array[j], ref array[i]);

        }
        #endregion

        public static T GetDefault()
        {
            return default(T);
        }
    }
}
