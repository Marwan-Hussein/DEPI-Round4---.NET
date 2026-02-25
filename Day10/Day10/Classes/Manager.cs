using System;

namespace Day10.Classes
{
    internal class Manager : Employee, IComparable<Manager>
    {
        public Manager(int? _Id, string Name, double Salary)
        {
            //ctor : 
            // this : obj created 
            // dimmed >> meaningless
            Id = _Id;
            this.Name = Name;
            this.Salary = Salary;
        }
        public Manager(string Name, double Salary) : this(null, Name, Salary) { }
        public int CompareTo(Manager mnger)
        {
            return (int)(Salary - mnger.Salary);            
        }

        public static void Sort(Manager[] array)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length; j++)
                    if (array[i].CompareTo(array[j]) < 0)
                        Statics<Manager>.Swap(ref array[j], ref array[i]);

        }
        
    }
}
