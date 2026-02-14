using static System.Console;
using SharedLib;
using static Day7.Calculator;
namespace Day7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region p1
            General.problem(1);
            Car def = new Car();
            WriteLine();

            Car withId = new Car(5);
            WriteLine();

            Car IdBrand = new Car(7, "BMW");
            WriteLine();

            Car all = new Car(9, "Mercedes", 50000);
            WriteLine();

            #endregion

            #region p2
            General.problem(2);
            WriteLine(Sum(4, 5));
            WriteLine(Sum(4, 5,6));
            WriteLine(Sum(4.5, 5.2));

            #endregion

            #region p3
            General.problem(3);
            
            #endregion

            #region p4
            General.problem(4);
            
            #endregion

            #region p5
            General.problem(5);
            
            #endregion

            #region p6
            General.problem(6);
            
            #endregion

            #region p7
            General.problem(7);
            
            #endregion

            #region p8
            General.problem(8);
            
            #endregion

            #region p9
            General.problem(9);
            
            #endregion

            #region p10
            General.problem(10);
            
            #endregion

        }
    }
}
