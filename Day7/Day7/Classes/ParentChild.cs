using static System.Console;

namespace Day7.Classes
{
    internal class Parent
    {
        public int X { get; set; }
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
        public Child(int x, int y, int z) : base(x, y)
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
}
