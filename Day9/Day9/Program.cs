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
        public static T[] Reverse<T>(T[] arr){
            int i = arr.Length;
            T[] rev = new T[arr.Length];
            foreach (T x in arr)
                rev[--i] = x;
            return rev;
        }
        public static void Swap<T>(ref T[] arr, int i, int j)
        {
            (arr[i], arr[j]) = (arr[j], arr[i]);
        }

        // p2-pb4
        public static T MaxElement<T>(T[] arr) where T: IComparable<T>
        {
            T max = arr[0];
            foreach (T x in arr)
                if (x.CompareTo(max) > 0)
                    max = x;
            return max;
        }
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
            WriteLine(sizeof(Gender)); // 1 byte
            WriteLine(sizeof(int)); // 4 (the default)
            #endregion
            #region pb8
            problem(8);
            WriteLine(Utility.Fehrenheit(10.5)); // 50.9
            WriteLine(Utility.Celsius(73.45)); // 23.03
            #endregion

            #region pb9
            problem(9);
            Write("Enter a grade (A - F): ");
            string input = Console.ReadLine();
            WriteLine(Enum.TryParse<Grades>(input.ToUpper(), out Grades grade) ?
                $"grade: {grade}" : "Invalid Grade");
            #endregion

            #region pb10
            problem(10);
            Employee[] employees = {
                new Employee(1, "Maro", (int)2e4),
                new Employee(2, "Dola", (int)2.5e4),
                new Employee(3, "Ahmed", (int)1.5e4),
                new Employee(4, "Ali", (int)2.8e4),
                new Employee(5, "Shawky", (int)9e3)
            };
            //Print(employees);
            WriteLine(Utility.SearchArray(employees, new Employee(2, "Dola", 25000))); // 1
            #endregion

            #region pb11
            problem(11);
            WriteLine(Utility.Max("Maro", "Zero"));

            #endregion

            */
            #region pb12
            problem(12);
            int[] arr12 = { 1, 2, 5, 2, 5, 3, 2, 4 };
            Utility.Replace(arr12, 2, 5);
            Print(arr12); // 1 5 5 5 5 3 5 4
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

            /*#region part2
            WriteLine("\n===========    Day 9 - Part 2    ===========");

            #region pb1
            problem(1);
            int[] intArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print(Reverse(intArr));

            string[] strArr = { "Maro", "dola", "john", "doe" };
            Print(Reverse(strArr));

            #endregion

            #region pb2
            problem(2);
            Stack<int> st = new Stack<int>();
            int[] arr6 = { 10, 5, 6, 15, 7, -9, 0 };
            foreach (int x in arr6)
                st.Push(x);
            WriteLine(st.Peek());
            while (!st.isEmpty())
                WriteLine(st.Pop()); // reversed arr6
            #endregion
            #region pb3
            problem(3);
            int[] intArr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Swap(ref intArr2, 5, 8); // 1, 2, 3, 4, 5, 9, 7, 8, 6
            Print(intArr2);
            #endregion
            #region pb4
            problem(4);
            WriteLine(MaxElement(intArr2));
            #endregion

            #endregion*/

        }
    }
}
