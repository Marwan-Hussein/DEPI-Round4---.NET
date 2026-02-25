using System.Collections;
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

        public static void Print<T>(T[] arr)
        {
            foreach (T t in arr)
                WriteLine(t);
            WriteLine();
        }

        public static void InitFile(int pbInit, int pbFinal, int part=0)
        {
            string prt = part == 0 ? "" : $"Part {part} - ";
            for(int i = pbInit; i <= pbFinal; i++)
            {
                WriteLine($"#region {prt}pb{i}");
                WriteLine($"problem({i});");
                WriteLine();
                WriteLine("#endregion\n");
            }
        }
    }
}
