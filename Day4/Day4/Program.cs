using System;
using static System.Console;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
namespace Day4
{
    internal class Program
    {
        public static void problem(int problemNuber)
        {
            WriteLine($"\nProblem {problemNuber}: ");
        }

        public static void Print(ref int[] arr)
        {
            foreach(int x in arr)
                Write($"{x} ");
            WriteLine();
        }

        // part2
        public enum DayOfWeek
        {
            Monday=1,
            TuesDay,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday // 7
        }
        static void Main(string[] args)
        {
            WriteLine("\n\n========  Part 1  ======== ");
            #region p1
            problem(1);
            // new int[sz]
            int[] arr1 = new int[3];
            for (int i = 1; i <= arr1.Length; i++)
                arr1[i - 1] = i;

            // initializer list
            int[] arr2 = new int[] { 1, 2, 3 };

            // arr syntax sugar
            int[] arr3 = { 1, 2, 3 };
            WriteLine("Arr1 |\tArr2 |\tArr3");
            for (int i = 0; i < arr3.Length; i++)
                WriteLine($" {arr1[i]}   |\t {arr2[i]}   |\t {arr3[i]} ");

            try
            {
                //WriteLine(arr1[3]);
                WriteLine(arr2[-1]);
            }
            catch (IndexOutOfRangeException ex)
            {
                WriteLine(ex.Message);
            }
            #endregion

            #region p2
            problem(2);
            int[] a1 = { 1, 2, 3 };
            int[] a2 = a1;

            a2[0] = 555;
            WriteLine($"a1[0] = {a1[0]}, a2[0] = {a2[0]}");
            WriteLine($"hash codes: {a1.GetHashCode()}  {a2.GetHashCode()}\n");

            int[] a3 = (int[])a1.Clone();
            a3[0] = 123;
            WriteLine($"a1[0] = {a1[0]}, a3[0] = {a3[0]}");
            WriteLine($"hash codes: {a1.GetHashCode()}  {a3.GetHashCode()}");

            #endregion

            #region p3
            problem(3);
            int[,] grade_stu = new int[3, 3];
            for (int i = 0; i < grade_stu.GetLength(0); ++i)
            {
                WriteLine($"\nstudent{i}: ");
                for (int j = 0; j < grade_stu.GetLength(0);)
                {
                    Write($"\tsub{j}: ");
                    j = (int.TryParse(ReadLine(), out grade_stu[i, j]) ? ++j : j);
                }
            }

            for (int i = 0; i < grade_stu.GetLength(0); ++i)
            {
                Write($"\nstu{i}: ");
                for (int j = 0; j < grade_stu.GetLength(0); ++j)
                    Write($"{grade_stu[i, j]} ");
            }
            #endregion

            #region p4
            problem(4);
            int[] arr4 = { 9, 1, 5, 6, 20, -5 };

            // sort
            Array.Sort(arr4);
            Print(ref arr4); // -5 1 5 6 9 20

            // reverse
            Array.Reverse(arr4);
            Print(ref arr4); // 20 9 6 5 1 -5

            // indexOf
            WriteLine(Array.IndexOf(arr4, 6)); // 2

            // copy
            int[] toCopy = new int[7];
            Array.Copy(arr4, toCopy, 6);
            Print(ref toCopy);

            Array.Clear(toCopy, 0, toCopy.Length - 2);
            Print(ref toCopy); // all are zeros except the previous of the last
            #endregion

            #region p5
            problem(5);
            int[] arr5 = { 45, 12, 4, 8, 9 };
            Write("Using for:  ");
            for (int i = 0; i < arr5.Length; ++i)
                Write(arr5[i] + " ");

            Write("\nforeach:    ");
            foreach (int x in arr5)
                Write(x + " ");

            Write("\nusing while: ");
            int idx = arr5.Length;
            while (--idx >= 0)
                Write(arr5[idx] + " ");
            #endregion

            #region p6
            problem(6);
            do
            {
                Write("Enter an odd number: ");
            } while (int.TryParse(ReadLine(), out int n6) == false || n6 % 2 != 1);
            WriteLine("Thanks.");
            #endregion

            #region p7
            problem(7);
            int[,] mat =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            for (int i = 0; i < mat.GetLength(0); ++i)
            {
                for (int j = 0; j < mat.GetLength(1); ++j)
                    Write($"{mat[i, j]} ");
                WriteLine();
            }
            #endregion

            #region p8
            problem(8);
            Write("enter a month number: ");
            int.TryParse(ReadLine(), out int month);
            WriteLine("usning if-else:");
            if (month == 1) WriteLine("January");
            else if (month == 2) WriteLine("February");
            else if (month == 3) WriteLine("March");
            else if (month == 4) WriteLine("April");
            else if (month == 5) WriteLine("May");
            else if (month == 6) WriteLine("June");
            else if (month == 7) WriteLine("July");
            else if (month == 8) WriteLine("August");
            else if (month == 9) WriteLine("September");
            else if (month == 10) WriteLine("October");
            else if (month == 11) WriteLine("November");
            else if (month == 12) WriteLine("December");
            else WriteLine("Invalid month number.");

            WriteLine("\nusing switch:");
            switch (month)
            {
                case 1:
                    WriteLine("January");
                    break;
                case 2:
                    WriteLine("February");
                    break;
                case 3:
                    WriteLine("March");
                    break;
                case 4:
                    WriteLine("April");
                    break;
                case 5:
                    WriteLine("May");
                    break;
                case 6:
                    WriteLine("June");
                    break;
                case 7:
                    WriteLine("July");
                    break;
                case 8:
                    WriteLine("August");
                    break;
                case 9:
                    WriteLine("September");
                    break;
                case 10:
                    WriteLine("October");
                    break;
                case 11:
                    WriteLine("November");
                    break;
                case 12:
                    WriteLine("December");
                    break;
                default:
                    WriteLine("Invalid month number.");
                    break;
            }
            #endregion

            #region p9
            problem(9);
            int[] arr9 = { 9, 10, 8, 5, 1, 6, 5 };
            Array.Sort(arr9);
            Print(ref arr9); // 1 5 5 6 8 9 10

            WriteLine(Array.IndexOf(arr9, 5));
            WriteLine(Array.LastIndexOf(arr9, 5));
            #endregion

            #region p10
            problem(10);
            int[] arr10 = { 9, 15, 16, 52, 13, 47, 50 };
            int sm = 0;
            for (int i = 0; i < arr10.Length; ++i)
                sm += arr10[i];
            WriteLine($"sum (for) = {sm}");
            sm = 0;
            foreach (int x in arr10)
                sm += x;
            WriteLine($"sum (foreach) = {sm}");
            #endregion

            #region part2
            WriteLine("\n\n========  Part 2  ======== ");
            Write("Enter a day num: ");
            if (int.TryParse(ReadLine(), out int day)
                && day > 0 && day <= 7)
            {
                DayOfWeek dayOfWeek =
                    (DayOfWeek)Enum.Parse(typeof(DayOfWeek), day.ToString());
                WriteLine($"The day is: {dayOfWeek}");
            }
            else
                 WriteLine("Invalid day number.");
            #endregion

        }
    }
}
