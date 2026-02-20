using static System.Console;
using static SharedLib.General;
using Day9.Enums;
using System;
using Day9.Classes;
using Day9.Classes;
namespace Day9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1
            WriteLine("\n===========    Day 9 - Part 1    ===========");
            /*#region pb1
            problem(1);
            foreach(WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                WriteLine($"Day: {day}\t Value: {(int)day}");
            }
            #endregion
            #region pb2
            problem(2);
            foreach(Grades g in Enum.GetValues(typeof(Grades)))
            {
                WriteLine($"Grade: {g}\t Value: {(short)g}");
            }
            #endregion
            #region pb3
            problem(3);
            Person p1 = new Person { Id = 1, Name = "Maro", Age = 20, Dept = Department.IT };
            Person p2 = new Person { Id = 2, Name = "john doe", Age = 25, Dept = Department.HR };
            WriteLine(p1);
            WriteLine(p2);
            #endregion
            #region pb4
            problem(4);
            Child c1 = new Child();
            c1.Salary = (int)15e3;
            c1.DisplaySalary();

            #endregion
            #region pb5
            problem(5);
            WriteLine(Utility.RecPermeter(10, 20));
            #endregion
            */
            #region pb6
            problem(6);
            ComplexNumber comp1 = new ComplexNumber(4, 2);
            ComplexNumber comp2 = new ComplexNumber(1, 5);

            WriteLine($"({comp1}) + ({comp2}) = {comp1 + comp2}"); // 5 + 7i
            WriteLine($"({comp1}) - ({comp2}) = {comp1 - comp2}"); // 3 - 3i
            WriteLine($"({comp1}) * ({comp2}) = {comp1 * comp2}"); // -2 + 24i


            #endregion
            #region pb7
            problem(7);

            #endregion
            #region pb8
            problem(8);

            #endregion

            #region pb9
            problem(9);

            #endregion

            #region pb10
            problem(10);

            #endregion

            #region pb11
            problem(11);

            #endregion

            #region pb12
            problem(12);

            #endregion

            #region pb13
            problem(13);

            #endregion

            #region pb14
            problem(14);

            #endregion

            #region pb15
            problem(15);

            #endregion

            #endregion

            #region part2
            WriteLine("\n===========    Day 9 - Part 2    ===========");

            #region pb1
            problem(1);

            #endregion

            #region pb2
            problem(2);

            #endregion
            #region pb3
            problem(3);

            #endregion
            #region pb4
            problem(4);

            #endregion

            #endregion

        }
    }
}
