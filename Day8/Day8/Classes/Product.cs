using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Day8.Classes
{
    internal class Product : IComparable
    {
        #region properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        #endregion

        #region ctors
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public Product(Product other)
        {
            Id = other.Id;
            Name = other.Name;
            Price = other.Price;
        }
        #endregion
        public override string ToString()
        {
            return $"ID: {Id}\tName: {Name}\tPrice: {Price}";
        }
        public int CompareTo(object obj)
        {
            Product other = (Product)obj;
            return (int)(this.Price - other.Price);

        }
    }
}
