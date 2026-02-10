using Day6;

namespace Day05
{
    internal class forDay6
    {
        public void Run()
        {
            TypeA a1 = new TypeA();
            a1.H = 1; // allowed
            //a1.G = 4; // not allowed -> can be accessed only from the same project
        } 
    }
}
