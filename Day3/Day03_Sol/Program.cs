using System;
using System.Text;
using static System.Console;
namespace Day03_Sol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem1
            WriteLine("Problem 1:");
            Write("enter a number: ");
            string in1 = ReadLine();
            try
            {
                int n1 = int.Parse(in1);
                int n2 = Convert.ToInt32(in1);
                WriteLine($"Parsed number: {n1}\n Converted number: {n2}");
            }
            catch
            {
                WriteLine("Invalid INTEGER!");
            }
            WriteLine();
            #endregion

            #region problem2
            WriteLine("Problem 2:");
            Write("enter a number: ");
            string in2 = ReadLine();
            bool flag2 = int.TryParse(in2, out int n);
            WriteLine(flag2 ? n : "Invalid INTEGER!");

            WriteLine();
            #endregion

            #region problem3
            WriteLine("Problem 3:");
            Object obj3 = 45;
            WriteLine(obj3.GetHashCode());

            obj3 = 45.45;
            WriteLine(obj3.GetHashCode());


            obj3 = "Maro";
            WriteLine(obj3.GetHashCode());
            WriteLine();
            #endregion

            #region problem4
            WriteLine("Problem 4:");
            Point p1 = new Point();
            p1.X = 10;
            p1.Y = 5;
            Point p2 = p1;
            p2.X = 5;
            WriteLine($"P1.x: {p1.X}");
            WriteLine();
            #endregion

            #region problem5
            WriteLine("Problem 5:");
            string s5 = "Hi";
            WriteLine($"HashCode() before concat: {s5.GetHashCode()}");
            s5 += " Willy";
            WriteLine($"HashCode() after  concat: {s5.GetHashCode()}");

            WriteLine();
            #endregion

            #region problem6
            WriteLine("Problem 6:");
            StringBuilder s6 = new StringBuilder("Hi");
            WriteLine($"HashCode() before concat: {s6.GetHashCode()}");
            s6.Append(" Willy");
            WriteLine($"HashCode() after  concat: {s6.GetHashCode()}");

            WriteLine();
            #endregion

            #region problem7
            WriteLine("Problem 7:");
            Write("n1 = ");
            int n7 = int.Parse(ReadLine());

            Write("n2 = ");
            int n8 = int.Parse(ReadLine());
            WriteLine("Using Concatenation: ");
            WriteLine(n7 + " + " + n8 + " = " + (n7 + n8));

            WriteLine("\nUsing formatting: ");
            WriteLine(string.Format("{0} + {1} = {2}", n7, n8, n7 + n8));

            WriteLine("\nUsing Interpolation: ");
            WriteLine($"{n7} + {n8} = {n7 + n8}");

            WriteLine();
            #endregion

            #region problem8
            WriteLine("Probelm 8:");
            StringBuilder sb8 = new StringBuilder("ahlan ");
            WriteLine(sb8);

            sb8.Append("ya wa74 elkon");
            WriteLine(sb8);

            sb8.Replace("elkon", "elmagarra");
            WriteLine(sb8);

            sb8.Insert(sb8.Length - 1, " wy elkon bardo");
            WriteLine(sb8);

            sb8.Remove(0, "ahlan ".Length);
            WriteLine(sb8);
            WriteLine();
            #endregion

            ReadLine();
        }
    }
}
