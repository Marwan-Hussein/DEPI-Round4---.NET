using System;
using static System.Console;
namespace Day6
{
    // problem 1
    struct Point
    {
        public int x;
        public int y;

        #region constructors
        //public Point()
        //{
        //    x = 0;
        //    y = 0;
        //}

        public Point(int x_, int y_)
        {
            x = x_;
            y = y_;
        }

        public Point(int x_) { x = x_; y = 0; }
        #endregion

        public override string ToString()
        {
            return $"x={x}\ty={y}";
        }
    }

    // problem 3
    public struct Employee
    {
        private int EmpId;
        private string EmpName;
        private double EmpSalary;

        public int Id {get; set;}
        public double Salary { 
            get { return EmpSalary; } 
            set{ EmpSalary = Math.Max(value,0); } 
        }
        public void SetName(string name) { EmpName = name; }
        public string GetName() { return EmpName; }
        public override string ToString()
        {
            return $"Id: {Id}\tName: {EmpName}\tSalary: {Salary}";
        }
    }
    internal class Program
    {
        public static void problem(int problemNuber)
        {
            WriteLine($"\nProblem {problemNuber}: ");
        }
        static void Main(string[] args)
        {
            #region p1
            Point p1 = new Point();
            WriteLine(p1); // 0 0

            Point p2 = new Point(1, 2);
            WriteLine(p2); // 1 2
            #endregion

            #region p2
            problem(2);
            TypeA a1 = new TypeA();
            ////a1.F; error: inaccessible
            a1.G = 1; // internal
            a1.H = 2; // public
                      //a1.F = 3; // error: inaccessible
                      // you can see accessing G in Day05 > forDay6.cs
            #endregion

            #region p3
            problem(3);
            Employee emp1 = new Employee();
            emp1.Id = 1;
            emp1.Salary = 1000f;
            emp1.SetName("Maro");
            WriteLine(emp1);
            #endregion

            #region p4
            problem(4);
            Point pnt1 = new Point(1, 2);
            Point pnt2 = new Point(3);
            WriteLine(pnt1);
            WriteLine(pnt2);
            #endregion

            #region p5
            problem(5);
            Point pnt3 = new Point(4, 5);
            Point pnt4 = new Point(-5, 5);
            WriteLine(pnt3);
            WriteLine(pnt4);
            #endregion

            #region p6
            problem(6);
            Point pp = new Point(4, 5);
            Point pp2 = pp;
            pp.x = 100;
            WriteLine(pp); // 100 5
            WriteLine(pp2); // 4 5
            WriteLine($"HC(p1) = {pp.GetHashCode()}\tHC(p2) = {pp2.GetHashCode()}");

            Employee emp2 = new Employee();
            Employee emp3 = emp2;
            WriteLine($"HC(emp1) = {emp2.GetHashCode()}\tHC(emp2) = {emp3.GetHashCode()}");

            #endregion
        }
    }
}
