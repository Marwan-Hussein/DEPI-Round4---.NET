using Day8.Interfaces;
using static System.Console;

namespace Day8.Classes
{
    internal class Car : IVehicle
    {
        public bool IsActive { get; set; }
        public void StartEngine()
        {
            IsActive = true;
            WriteLine("Car Engine started.");
        }
        public void StopEngine()
        {
            IsActive = false;
            WriteLine("Car Engine stopped");
        }

    }
    internal class Bike : IVehicle
    {
        public bool IsActive { get; set; }
        public void StartEngine()
        {
            IsActive = true;
            WriteLine("Bike Engine started.");
        }
        public void StopEngine()
        {
            IsActive = false;
            WriteLine("Bike Engine stopped");
        }
    }
}
