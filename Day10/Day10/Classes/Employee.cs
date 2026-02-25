using System;
using System.Xml.Linq;
namespace Day10.Classes
{
    internal class Employee : ICloneable, IComparable
    {
        #region properties
        public int? Id { get; set; }
        public string Name { get; set; }
        public double? Salary { get; set; }
        #endregion

        //Generic type >> object
        //1- generate new obj with same data 
        //2- new and diff identity(address)
        public object Clone()
        {
            // this in fun :
            //this : Caller obj 
            return new Employee()
            {
                Id = Id,
                Name = Name,
                Salary = Salary,
            };
        }

        #region ctors
        //Copy Ctor :
        // special ctor :> take one parameter of same type class 
        public Employee(Employee Copy)
        {
            Id = Copy.Id;
            Name = Copy.Name;
            Salary = Copy.Salary;
        }
        public Employee()
        {

        }
        //public object Clone()
        //{
        //    // this in fun :
        //    //this : Caller obj 
        //    return new Employee(this)
        //    {
        //        //Id = this.Id,
        //        //Name = this.Name,
        //        //Salary = this.Salary
        //    };
        //}
        public Employee(int? _Id, string Name, double Salary)
        {
            //ctor : 
            // this : obj created 
            // dimmed >> meaningless
            Id = _Id;
            this.Name = Name;
            this.Salary = Salary;
        }
        public Employee(string Name, double Salary):this(null, Name, Salary) { }
        #endregion

        public override string ToString()
        {
            return $"Id: {Id ?? null}\t" +
                $" Name: {Name ?? null}\t" +
                $" Salary: {Salary ?? null}\t";
        }


        //Returns:
        //A value that indicates the relative order of the objects being compared.The
        //return value has these meanings:


        //Value – Meaning
        //Less than zero – This instance precedes obj in the sort order.
        //Zero – This instance occurs in the same position in the sort order as obj.
        //Greater than zero – This instance follows obj in the sort order.

        // +ve : this.slary > obj.salary  >> 1
        // -ve : this.slary<obj.salary>> -1
        // 0 : this.slary = obj.salary >> 0
        public int CompareTo(object obj)
        {
            Employee PassedEmp = (Employee)obj;
            // unsafe casting
            // Generics (object)
            // violate type safety 

            if (Salary > PassedEmp.Salary)
                return 1;
            else if (Salary < PassedEmp.Salary)
                return -1;
            else
                return 0;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Employee other = (Employee)obj;
            //return Id == other.Id &&
            //    Name == other.Name &&
            //    Salary == other.Salary &&
            //    Department.Equals (other.Department);
            if (Id == null && Name == null && Salary == null)
                return false;

            //if(Id != null && other.Id != null && Id != other.Id) return false;
            //return Id.Equals(other.Id)
            //    && Name.Equals(other.Name)
            //    && Salary.Equals(other.Salary)
            //    &&(Department == null || Department.Equals(other.Department));
            if (Id != null && other.Id != null && Id != other.Id)
                return false;
            if (Name != null && other.Name != null && Name != other.Name)
                return false;
            if (Salary != null && other.Salary != null && Salary != other.Salary)
                return false;
            return true;

        }


    }
}
