using static System.Console;
namespace SharedLib
{
    public static class General
    {
        public static void problem(int problemNuber)
        {
            WriteLine($"\nProblem {problemNuber}: ");
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            (a, b) = (b, a);
        }
    }
}
