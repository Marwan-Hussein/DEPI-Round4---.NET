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
                WriteLine(x);
        }

        //pb6
        public struct Account
        {
            #region attrs
            int accId;
            string accHolder;
            double balance;
            #endregion
            #region properties
            public int AccountId 
            {   get { return accId; } 
                set { accId = value; }
            }
            public string AccountHolder
            {
                get { return accHolder; }
                set { accHolder = value; }
            }
            public double Balance
            {
                get { return balance; }
                set { balance = value; }
            }
            #endregion
            public override string ToString()
            {
                return $"ID: {accId}\t Holder: {accHolder}\t Balance: {balance}";
            }
        }

        // part2
        public static void PrintTenShapes(IShapeSeries series)
        {
            for(int i=0;i<10; ++i)
            {
                WriteLine(series.CurrentShapeArea);
                series.GetNextShapeArea();
            }
            series.ResetSeries();
        }

        // selection sort
        private static int minIndex(int[] arr, int start)
        {
            int minIdx = start;
            for(int i=start+1; i<arr.Length; ++i)
                if(arr[i] < arr[minIdx])
                    minIdx = i;
            return minIdx;
        }
        public static void SelectionSort(ref int[] arr)
        {
            for(int i=0; i < arr.Length; ++i)
            {
                int min = minIndex(arr, i);
                General.Swap(ref arr[i], ref arr[min]);
            }

        }
        static void Main(string[] args)
        {
            /*#region part1
            Write("===  Part1  ====");
            #region pb1
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
            //WriteLine(p1.CompareTo(p2)); // -2
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
            #endregion
            #region pb6
            General.problem(6);
            Account acc = new Account();
            acc.AccountId = 1;
            acc.Balance = 2e4;
            acc.AccountHolder = "Maro";
            WriteLine(acc);
            WriteLine(acc.Balance);
            #endregion
            #region pb7
            General.problem(7);
            ILogger logger = new ConsoleLogger();
            logger.Log();
            #endregion
            #region pb8
            General.problem(8);
            Book b1 = new Book();
            WriteLine(b1);

            Book b2 = new Book("Safwat al Tafaseer");
            WriteLine(b2);

            Book b3 = new Book("Safwat al Tafaseer", "Mohamed Aly Al-Saboni");
            WriteLine(b3);

            #endregion

            #endregion
            */
            #region part2
            /*WriteLine("===  Part2  ====");

            #region shape series
            WriteLine("Square:");
            IShapeSeries sq = new SquareSeries();
            PrintTenShapes(sq);
            WriteLine();

            WriteLine("Circle:");
            IShapeSeries cir = new CircleSeries();
            PrintTenShapes(cir);
            #endregion
            #region sort shapes
            Shape__[] shapes =
            {
                new Shape__("Square",16),
                new Shape__("Rect", 24),
                new Shape__("Triangle", 96),
                new Shape__("Circle", 24),
                new Shape__("Ellipse", 96)
            };
            Array.Sort(shapes);
            Print(shapes);
            #endregion
            */
            #region Shape hierarchy
            GeoShape rec5 = new RectangleShape(5.5,6.25);
            WriteLine(rec5);
            WriteLine($"Area of Rectangle = {rec5.CalculateArea()}"); // 34.38
            WriteLine($"Perimeter of Rectangle = {rec5.Permeter}"); // 23.5
            WriteLine();

            GeoShape tri5 = new TriangleShape(2, 5, 10);
            WriteLine(tri5);
            WriteLine($"Area of Triangle = {tri5.CalculateArea()}"); // 3.5
            WriteLine($"Perimeter of Triangle = {tri5.Permeter}"); // 17
            #endregion

            /*#region sorting
            int[] arr = { 5, 2, 9, 1, 5, 6 };
            SelectionSort(ref arr);
            Print(arr);
            #endregion
            */
            #endregion
        }
    }
}
