using static System.Console;
using System;
namespace Day7
{
    internal class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public Car(int id, string brand, double price)
        {
            Id = id;
            Brand = brand;
            Price = price;
            WriteLine("Id + Brand + Price");
        }
        public Car(): this(new Random().Next(1,1000))
        { WriteLine("Default"); }
        
        public Car(int id): this(id,"Kia") 
        { WriteLine("only id"); }
        
        public Car(int id, string brand): this(id,brand, 700_000) 
        { WriteLine("Id + Brand"); }
        
        public override string ToString()
        {
            return $"Id: {Id}\t Brand: {Brand}\t Price: {Price}";
        }
    }
}
