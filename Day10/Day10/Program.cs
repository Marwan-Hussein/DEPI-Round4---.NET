using Day10.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using static Day10.Classes.Statics<Day10.Classes.Employee>;
using static SharedLib.General;
using static System.Console;
namespace Day10
{
    internal class Program
    {
        public static void PrintStrings(List<string> strings, Action<string> action)
        {
            foreach (string s in strings)
                action(s);
        }

        // pb16
        public delegate bool StringDelegate(string str, string sub);
        public static List<string> FilterList(List<string> list, StringDelegate del, string sub="")
        {
            List<string> result = new List<string>();
            for(int i=0; i< list.Count; i++)
                if (del(list[i], sub))
                    result.Add(list[i]);
            return result;
        }

        // pb17
        public static bool StartWith(string str, string sub)
            => str.Substring(0, sub.Length).ToLower() == sub.ToLower();
        public static bool EndWith(string str, string sub)
            => str.Substring(str.Length - sub.Length, sub.Length).ToLower() == sub.ToLower();
        public static bool Contains(string str, string sub)
            => str.Contains(sub);

        // pb18
        public static int MathOp(int a, int b, Func<int, int, int> func)
            => func(a, b);
        static void Main(string[] args)
        {
            // delegates
            Statics<int>.CompareDelegate DescArr7 = new Statics<int>.CompareDelegate(Statics<int>.Greater);
            CompareDelegate del = new CompareDelegate(Smaller);
            Func<int, int, bool> descInt = (x, y) => x > y;
            Func<string, string, bool> ascStr = (x, y) => x.Length < y.Length;
            Func<Employee, Employee, bool> lessLen = (emp1, emp2) => emp1.Name.Length < emp2.Name.Length;
            Func<Employee, Employee, bool> Customized = (e1, e2) =>
            {
                if (e1.Salary == e2.Salary)
                    return lessLen(e1, e2);
                return e1.Salary < e2.Salary;
            };

            /*
            #region pb1
            problem(1);
            Employee[] emps =
            {
                new Employee("Marwanello", (int)4.5e4),
                new Employee("ahmed", 12500),
                new Employee("john", (int)2.5e3)
            };
            Sort(emps, del);
            Print(emps); 
            #endregion
            #region pb2
            problem(2);
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Statics<int>.SortingTwo(arr, descInt);
            Print(arr);
            #endregion

            #region pb3
            problem(3);
            string[] arr3 = { "maro", "hi", "I'm" };
            Statics<string>.SortingTwo(arr3, ascStr);
            Print(arr3); // hi i'm maro
            #endregion

            #region pb4
            problem(4);
            Manager[] mngers =
            {
                new Manager("zaki", 45000),
                new Manager("shan", (int)8e4),
                new Manager("ahmed", 8000)
            };
            Manager.Sort(mngers);
            Print(mngers);
            #endregion

            #region pb5
            problem(5);
            SortingTwo(emps, lessLen);
            Print(emps);
            #endregion

            #region pb6
            problem(6);
            Func<int, int, bool> ascInt = (x, y) => x < y;
            int[] arr6 = { 9, 8, 7, 6, 5, 4, 3, 2, 1};
            Statics<int>.SortingTwo(arr6, ascInt);
            Print(arr6);

            #endregion

            #region pb7
            problem(7);
            // it's already as this in Statics<T>
            int[] arr7 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Statics<int>.Sort(arr7, DescArr7);
            Print(arr7);
            #endregion

            #region pb8
            problem(8);
            Employee[] employees2 = 
            { 
                new Employee(1, "Alice", 5000), 
                new Employee(2, "Bobb", 6000), 
                new Employee(3, "Charlie", 6000), 
                new Employee(4, "Diana", 5500), 
                new Employee(5, "Eve", 6000) 
            };
            SortingTwo(employees2, Customized);
            Print(employees2);
            #endregion

            #region pb9
            problem(9);
            WriteLine($"default of int: {Statics<int>.GetDefault()}");
            WriteLine($"default of bool: {Statics<bool>.GetDefault()}");
            WriteLine($"default of string: {Statics<string>.GetDefault()}");

            #endregion

            #region pb10
            problem(10);
            Employee[] employees3 =
            {
                new Employee(1, "Alice", 5000),
                new Employee(2, "Bobb", 6000),
                new Employee(3, "Charlie", 6000),
                new Employee(4, "Diana", 5500),
                new Employee(5, "Eve", 6000)
            };
            Employee[] sortedEmps = Statics<Employee>.SortRetArr(employees3, Customized);
            WriteLine("Not Sorted:");
            Print(employees3);
            WriteLine("Sorted:");
            Print(sortedEmps);
            #endregion

            #region pb11
            problem(11);
            string[] StrList = {"Marwan", "hUssein", "MoHamed"};
            
            Statics<string>.TransformStrList( StrList, new Statics<string>.StringsDelegate(Upper));
            WriteLine("Upper:");
            Print(StrList);

            Statics<string>.TransformStrList( StrList, new Statics<string>.StringsDelegate(Lower));
            WriteLine("Lower:");
            Print(StrList);

            Statics<string>.TransformStrList( StrList, new Statics<string>.StringsDelegate(Reverse));
            WriteLine("Reverse:");
            Print(StrList);
            #endregion

            #region pb12
            problem(12);
            int a = 12, b = 6;
            Statics<int>.IntDelegate IntDel = new Statics<int>.IntDelegate(Add);
            WriteLine($"{a} + {b} = "+Statics<int>.OpInt(a,b, IntDel));

            IntDel = new Statics<int>.IntDelegate(Sub);
            WriteLine($"{a} - {b} = "+Statics<int>.OpInt(a, b, IntDel));

            IntDel = new Statics<int>.IntDelegate(Mult);
            WriteLine($"{a} * {b} = "+Statics<int>.OpInt(a, b, IntDel));

            IntDel = new Statics<int>.IntDelegate(Div);
            WriteLine($"{a} / {b} = "+Statics<int>.OpInt(a, b, IntDel));

            #endregion

            #region pb13
            problem(13);
            double[] dbles = { 4.45, 45.3, 54.21};
            int[] ints = Statics<double>.TransformList(dbles, n => (int)n);
            Print(ints);
            #endregion

            #region pb14
            problem(14);
            int[] arr14 = { 1, 2, 3, 4, 5, 6 };
            int[] res14 = Statics<int>.PerformFnc(arr14, (a) => a * a);
            Print(res14);
            #endregion

            #region pb15
            problem(15);
            List<string> strings = new List<string>{"hi", "Maro", "badrasheen","is", "a","dawla"};
            Action<string> action = (x) => Write($"{x} ");
            PrintStrings(strings,action);
            #endregion

            #region pb16
            problem(16);
            List<int> list = new List<int> { 1,2,3,4,5,6,7,8,9};
            Predicate<int> BaseAction = (x) => x % 2 == 0;
            List<int> result = FilterList(list,BaseAction);
            Print(result);
            #endregion

            #region pb17
            problem(17);
            List<string> strList = new List<string> {"alloc", "malloc","ant", "anydisk", "all"};
            StringDelegate starts = new StringDelegate(StartWith);
            
            List<string> startWith = FilterList(strList, starts, "an");
            Print(startWith); // ant, anydisk

            StringDelegate ends = new StringDelegate(EndWith);
            List<string> endWith = FilterList(strList, ends, "oc");
            Print(endWith); // alloc, malloc

             StringDelegate con = new StringDelegate(Contains);
            List<string> contains = FilterList(strList, con, "all");
            Print(contains); // alloc, malloc, all

            #endregion
            */
            
            #region pb18
            problem(18);
            WriteLine(MathOp(5, 4, (a, b) => a + b));               // 9
            WriteLine(MathOp(5, 4, (a, b) => a - b));               // 1
            WriteLine(MathOp(5, 4, (a, b) => a * b));               // 20
            WriteLine(MathOp(5, 4, (a, b) => a / b));               // 1
            WriteLine(MathOp(5, 3, (a, b) => (int)Math.Pow(a,b)));  // 125

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
