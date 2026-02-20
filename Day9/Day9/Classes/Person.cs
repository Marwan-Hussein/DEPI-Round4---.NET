using System;
namespace Day9.Classes
{
    enum Department
    {
        HR,
        IT,
        Sales,
        Marketing
    }
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Department Dept { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}\t Name: {Name}\t Age: {Age}\t Department: {Dept}";
        }
    }
}
