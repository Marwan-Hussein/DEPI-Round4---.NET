using System;
using static System.Console;
namespace Day05
{
    internal class Program
    {
        public static void problem(int problemNuber)
        {
            WriteLine($"\nProblem {problemNuber}: ");
        }

        public static void Main(string[] args)
        {
            WriteLine("\n==========   Part1   ==============\n");
            Part1.Run();
            WriteLine("Part1 finished. press any key to continue...");
            ReadKey();

            WriteLine("\n==========   Part2   ==============\n");
            Part2.Run();
        }
    }
}
