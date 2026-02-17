using System;
namespace Day8.Classes
{
    internal class Student
    {
        #region properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }
        #endregion

        #region ctors
        public Student(int  id, string name, double grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }
        public Student(Student other)
        {
            Id = other.Id;
            Name = other.Name;
            Grade = other.Grade;
        }
        #endregion

    }
}
