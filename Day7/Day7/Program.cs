using static System.Console;
using SharedLib;
using static Day7.Calculator;
using Day7.Interfaces;
namespace Day7
{
    internal class Parent
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public Parent(int x, int y)
        {
            X = x;
            Y = y;
            WriteLine("ctor from parent");
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
        public virtual int Product() { return X * Y; }
        public int Sum() { return X + Y; }
    }

    internal class Child : Parent
    {
        public int Z { get; set; }
        public Child(int x, int y, int z) : base(x,y)
        {
            Z = z;
            WriteLine("ctor from child");
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
        public new int Product() { return base.Product() * Z; }
        //public override int Product() { return base.Product() * Z; }

        //public override int Sum() { return base.Sum() + Z; } ERR: no virtual keyword
        public new int Sum() { return base.Sum() + Z; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region p1
            General.problem(1);
            Car def = new Car();
            WriteLine();

            Car withId = new Car(5);
            WriteLine();

            Car IdBrand = new Car(7, "BMW");
            WriteLine();

            Car all = new Car(9, "Mercedes", 50000);
            WriteLine();

            #endregion

            #region p2
            General.problem(2);
            WriteLine(Sum(4, 5));
            WriteLine(Sum(4, 5,6));
            WriteLine(Sum(4.5, 5.2));

            #endregion

            #region p3
            General.problem(3);
            Parent p = new Parent(1, 2);
            Child c = new Child(3, 4, 5);
            
            #endregion

            #region p4
            General.problem(4);
            WriteLine("Parent Product: " + p.Product()); // 2
            WriteLine("Child Product: " + c.Product()); // 60

            WriteLine("\nParent Sum: " + p.Sum()); // 3
            WriteLine("Child Sum: " + c.Sum()); // 12
            #endregion

            #region p5
            General.problem(5);
            WriteLine($"P: {p}");
            WriteLine($"C: {c}");
            #endregion

            #region p6
            General.problem(6);
            IShape rec = new Rectangle(5.2, 7);
            rec.Draw();
            WriteLine($"Area = {rec.Area}");
            #endregion

            #region p7
            General.problem(7);
            IShape cir = new Circle(3);
            cir.Draw();
            cir.PrintDetails();
            #endregion
            
            #region p8
            General.problem(8);
            
            #endregion

            #region p9
            General.problem(9);
            
            #endregion

            #region p10
            General.problem(10);
            
            #endregion

        }
    }
}
