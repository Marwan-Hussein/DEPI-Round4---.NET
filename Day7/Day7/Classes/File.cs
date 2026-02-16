using Day7.Interfaces;
using static System.Console;
namespace Day7.Classes
{
    internal class File : IReadable, IWritable
    {
        public void Read()
        {
            WriteLine("Reading from file");
        }
        public void Write()
        {
            WriteLine("Writing to file");
        }
    }
}
