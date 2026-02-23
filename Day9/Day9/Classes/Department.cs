namespace Day9.Classes
{
    public enum DepartmentType
    {
        IT,
        Backend,
        Frontend,
        CyberSecurity,
        HR
    }

    internal class DepartmentEmp
    {
        public DepartmentType Dept {  get; set; }
        public DepartmentEmp(DepartmentType dept)
        {
            Dept = dept;
        }

        public override bool Equals(object obj)
        {
            if(obj is DepartmentEmp demp)
                return demp.Dept == Dept;
            return false;
        }
        public override string ToString()
        {
            return Dept.ToString();
        }
    }
}

