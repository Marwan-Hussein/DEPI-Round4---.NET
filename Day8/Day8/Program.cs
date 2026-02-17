using static System.Console;
using Day8.Interfaces;
using Day8.Classes;
using SharedLib;
using System;
namespace Day8
{
    internal class Program
    {
        public static void Print<T>(T[] arr)
        {
            foreach(T x in arr)
                Write(x);
            WriteLine();
        }
        static void Main(string[] args)
        {
            #region part1
            Write("===  Part1  ====");
            /*#region pb1
            General.problem(1);
            IVehicle car = new Car();
            IVehicle bike = new Bike();

            car.StartEngine();
            car.StopEngine();

            bike.StartEngine();
            bike.StopEngine();
            #endregion

            #region pb2
            General.problem(2);
            Shape rec = new Rectangle(20, 5);
            rec.Display();
            WriteLine($"Rectangle Area = {rec.GetArea()}\n");

            Shape cir = new Circle(5.2);
            cir.Display();
            WriteLine($"Circle Area = {cir.GetArea()}");
            #endregion

            #region pb3
            General.problem(3);
            // Product p1 = new Product(1, "Lappy", 1e3);
            // Product p2 = new Product(2, "Ipad", 1e3+2);
            WriteLine(p1.CompareTo(p2)); // -2
            Product[] products = {
                new Product(1,"Lappy",3e4-300),
                new Product(2, "Cheavy", 0.75e6),
                new Product(3, "KIA", 0.75e6),
                new Product(4, "Chipsy", 1)
            };

            Array.Sort(products);
            Print(products);
            #endregion
            
            #region pb4
            General.problem(4);
            Student std1 = new Student(1, "Maro", 90.5);
            Student shallowStd = std1;
            WriteLine($"std1.GetHashCode() == shallowStd.GetHashCode(): {std1.GetHashCode() == shallowStd.GetHashCode()}");
            Student deepStd = new Student(std1);
            WriteLine($"std1.GetHashCode() == deepStd.GetHashCode(): {std1.GetHashCode() == deepStd.GetHashCode()}");

            #endregion
            #region pb5
            General.problem(5);
            Robot rob = new Robot();
            rob.Walk(); // robot is walking

            IWalkable Irob = new Robot();
            Irob.Walk(); // walking from iface
            #endregion*/
            #region pb6
            General.problem(6);

            #endregion

            #region pb7
            General.problem(7);

            #endregion
            #region pb8
            General.problem(8);

            #endregion

            #endregion

            #region part2
            WriteLine("===  Part2  ====");

            #endregion
        }
    }
}
