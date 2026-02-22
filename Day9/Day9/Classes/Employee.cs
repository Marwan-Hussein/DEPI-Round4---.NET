using System;
namespace Day9.Classes
{
    internal class Employee : ICloneable, IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }


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
        public Employee(int _Id, string Name, double Salary)
        {
            //ctor : 
            // this : obj created 
            // dimmed >> meaningless
            Id = _Id;
            this.Name = Name;
            this.Salary = Salary;
        }


        public override string ToString()
        {
            return $"Emp Id is {Id}, EmpName is {Name}, EmpSalary is {Salary}";
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
            if(obj == null || GetType() != obj.GetType()) 
                return false;

            Employee other = (Employee)obj;
            return Id == other.Id &&
                Name == other.Name &&
                Salary == other.Salary;
        }

        
        }
    }
