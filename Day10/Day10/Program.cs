using Day10.Classes;
using System;
using static Day10.Classes.Statics<Day10.Classes.Employee>;
using static SharedLib.General;
using static System.Console;
namespace Day10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*#region pb1
            problem(1);
            Employee[] emps =
            {
                new Employee("Maro", (int)4.5e4),
                new Employee("ahmed", 12500),
                new Employee("john", (int)2.5e3)
            };
            CompareDelegate del = new CompareDelegate(Smaller);
            Sort(emps, del);
            Print(emps); 
            #endregion
            */
            #region pb2
            problem(2);
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Func<int, int, bool> desc = (x, y) => x > y;
            Statics<int>.SortingTwo(arr, desc);
            Print(arr);
            #endregion

            #region pb3
            problem(3);
            string[] arr3 = { "maro", "hi", "I'm" };
            Func<string, string, bool> asc = (x, y) => x.Length < y.Length;
            Statics<string>.SortingTwo(arr3, asc);
            Print(arr3); // hi i'm maro
            #endregion

            #region pb4
            problem(4);

            #endregion

            #region pb5
            problem(5);

            #endregion

            #region pb6
            problem(6);

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

            #region pb16
            problem(16);

            #endregion

            #region pb17
            problem(17);

            #endregion

            #region pb18
            problem(18);

            #endregion

            #region pb19
            problem(19);

            #endregion

            #region pb20
            problem(20);

            #endregion
        }
    }
}
