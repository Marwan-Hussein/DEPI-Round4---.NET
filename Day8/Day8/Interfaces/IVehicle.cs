
using static System.Console;
namespace Day8.Interfaces
{
    internal interface IVehicle
    {
        public bool IsActive { set; get; }
        public void StartEngine()
        {
            IsActive = true;
            string[] parts = this.ToString().Split('.');
            WriteLine($"{parts[parts.Length -1]} Engine Started.");
        }
        public void StopEngine()
        {
            IsActive = false;
            string[] parts = this.ToString().Split('.');
            WriteLine($"{parts[parts.Length - 1]} Engine Stopped.");
        }
    }
}
