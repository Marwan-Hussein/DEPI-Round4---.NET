using System;
using static System.Console;
namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem1
                //int x = 10;
                //int y = 20;
                //int sum = x + y;
                //Console.WriteLine(sum);

                /*int x = 10;
                int y = 20;
                int sum = x + y;
                Console.WriteLine(sum);*/

                /*  purpose: to clarify some segment the program
                    without passing through CPU to be processed */
            #endregion

            #region problem2
            WriteLine("Problem 2:");
                int x = 10, y=0;
                WriteLine(x + y);
                // the error was in declaration an int (x) with a string "10"
            WriteLine();
            #endregion

            #region problem3
            WriteLine("Problem 3:");
            string fullName;
                int age;
                double salary;
                bool isStudent;
            WriteLine();
            #endregion

            #region problem4
            WriteLine("Problem 4:");
                Point p1 = new Point();
                p1.x = 10;
                p1.y = 20;

                Point p2 = p1;
                p2.x = 5;
                WriteLine(p1.x); // 5
            WriteLine();
            #endregion

            #region problem5
            WriteLine("Problem 5:");
                int x2 = 15, y2 = 4;
                WriteLine(x2 + y2); // sum
                WriteLine(x2 - y2); // difference
                WriteLine(x2 * y2); // product
                WriteLine(x2 / y2); // division
                WriteLine(x2 % y2); // remainder
            WriteLine();
            #endregion

            #region problem6
            WriteLine("Problem 6:");
                Write("enter a number: ");
                int num = int.Parse(ReadLine());
                WriteLine(num % 2 == 0 & num > 10 ? "True" : "False");
            WriteLine();
            #endregion

            #region problem7
            WriteLine("Problem 7:");
                Write("enter a double: ");
                double d = double.Parse(ReadLine());
                int toIntD1 = (int)d;
                //int toIntD2 = d;
                WriteLine("explicit: " + toIntD1);
            WriteLine("we can't convert from double to int implicitly!" +
                "\nbut we can cast int to double implicitly.");
            WriteLine();
            #endregion

            #region problem8
            WriteLine("Probelm 8:");
                Write("Enter your age: ");
                string age2Str = ReadLine();
                int age2 = int.Parse(age2Str);
                WriteLine(age2 > 0 ? "Valid" : "Invalid");
            WriteLine();
            #endregion

            #region problem9
            WriteLine("Probelm 9:");
                int x9 = 5;
                WriteLine("X++ = " + x9++); // 5
                WriteLine("++X = " + ++x9); // 7
            WriteLine();
            #endregion

        }
    }
}
