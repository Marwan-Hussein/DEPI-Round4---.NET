using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static Day05.Program;
namespace Day05
{
    internal class Part1
    {
        public static int TestDefensiveCode()
        {
            int X, Y, Z;
            bool flag;
            do
            {
                Console.WriteLine("Enter first Number : ");
            }
            while (!int.TryParse(Console.ReadLine(), out X) || X <= 0);
            do
            {
                Console.WriteLine("Enter Second Number : ");
            }
            while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 1);

            Z = X / Y;
            return Z;
        }

        public static void SumAndMultiply(int x,int y, out int sm, out int mlt)
        {
            sm = x + y;
            mlt = x * y;
        }

        public static void Repeat(string target, int times=5)
        {
            for (int i = 0; i < times; ++i)
                Write(target);
            WriteLine();
        }

        // problem 13
        public static int SumArr(params int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
                sum += num;
            return sum;
        }

        public static void Run()
        {
            #region p1
            problem(1);
            Write("n1: ");
            int.TryParse(ReadLine(), out int n1);
            Write("n2: ");
            int.TryParse(ReadLine(), out int n2);

            try
            {
                WriteLine($"{n1} / {n2} = {n1 / n2}");
            }
            catch (DivideByZeroException)
            {
                WriteLine("You can't divide by zero!");
            }
            finally
            {
                WriteLine("Operation complete");
            }
            #endregion

            #region p2
            problem(2);
            WriteLine(TestDefensiveCode());
            #endregion

            #region p3
            problem(3);
            int? x1 = null;
            int x2 = x1 ?? -1;
            WriteLine(x2);
            WriteLine(x1.HasValue ? x1.Value : "x1 is null value");
            #endregion

            #region p4
            problem(4);
            int[] arr1 = new int[5];
            try
            {
                WriteLine(arr1[7]);
            }
            catch
            {
                WriteLine("Out of the range ya rayes!");
            }
            #endregion

            #region p5
            problem(5);
            int[,] _2dArr = new int[3, 3];
            WriteLine("enter your Values as 3x3 matrix: ");
            for (int i = 0; i < 3; ++i)
            {
                int[] row = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
                for (int j = 0; j < 3; ++j)
                    _2dArr[i, j] = row[j];
            }
            WriteLine();

            int[] colSum = new int[_2dArr.GetLength(0)];
            for (int i = 0; i < _2dArr.Length / _2dArr.GetLength(0); ++i)
            {
                int rowSum = 0;
                for (int j = 0; j < _2dArr.GetLength(0); ++j)
                {
                    Write(_2dArr[i, j] + " ");
                    rowSum += _2dArr[i, j];
                    colSum[j] += _2dArr[i, j];
                }
                WriteLine(" | " + rowSum);
                rowSum = 0;
            }
            WriteLine("_ _ _ _");
            foreach (int sm in colSum)
                Write(sm + " ");
            #endregion

            #region p6
            problem(6);
            int[][] jagArr = new int[3][];
            for (int i = 0; i < 3; ++i)
            {
                Write($"elements row{i}: ");
                jagArr[i] = Array.ConvertAll(ReadLine().Split(' '), int.Parse);
            }
            WriteLine();

            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < jagArr[i].Length; j++)
                    Write(jagArr[i][j] + " ");
                WriteLine();
            }
            #endregion

            #region p7
            problem(7);
            Write("enter a string (or press enter to skip): ");
            string? str1 = ReadLine();
            string? str2 = string.IsNullOrEmpty(str1) ? null : str1;
            WriteLine($"with (!): {str2!}");
            #endregion

            #region p8
            problem(8);
            int val = 42;
            object obj = val; // boxing
            WriteLine($"Boxed value: {obj}");

            try
            {
                int unboxedVal = (int)obj; // unboxing
                WriteLine($"Unboxed value: {unboxedVal}");

                object obj2 = "Hello";
                int invalidUnbox = (int)obj2; // This will throw an exception
            }
            catch (InvalidCastException ex)
            {
                WriteLine($"Invalid cast: {ex.Message}");
            }
            #endregion

            #region p9
            problem(9);
            int sum9, mult;
            SumAndMultiply(4, 5, out sum9, out mult);
            WriteLine($"Sum = {sum9}\nProduct = {mult}");
            #endregion

            #region p10
            problem(10);
            Repeat("Maro ");
            Repeat("not Maro ", 4);

            #endregion

            #region p11
            problem(11);
            int[]? nums = null;
            int? len = nums?.Length;
            WriteLine($"Length = {len}");
            #endregion

            #region p12
            problem(12);
            Write("enter a day number from 1 (monday) to 7 (sunday): ");
            int.TryParse(ReadLine(), out int dayNo);
            string dayStr = dayNo switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                6 => "Saturday",
                7 => "Sunday",
                _ => "InvalidDay"
            };
            WriteLine(dayStr);

            #endregion

            #region p13
            problem(13);
            WriteLine(SumArr(1, 2, 3, 4, 5));
            int[] arr13 = { 1, 2, 3, 4, 5 };
            WriteLine(SumArr(arr13));
            #endregion
        }
    }
}
