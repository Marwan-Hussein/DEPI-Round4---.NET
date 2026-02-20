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
        public virtual int Salary { get; set; } = 5000;
        public Department Dept { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}\t Name: {Name}\t Age: {Age}\t Department: {Dept}";
        }
    }

    internal class  Child:Person
    {
        public sealed override int Salary { get; set; }
        public void DisplaySalary()
        {
            Console.WriteLine($"Salary: {Salary}");
        } 
    }
}
