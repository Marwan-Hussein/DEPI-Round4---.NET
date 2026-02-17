using Day8.Interfaces;
using static System.Console;
using static System.Math;
namespace Day8.Classes
{
    internal class SquareSeries : IShapeSeries
    {
        public int Len { get; set; }
        public SquareSeries(int l = 1) {  Len = l; }
        public int CurrentShapeArea
        {
            get => Len*Len;
            set => Len = value;
        }

        public void GetNextShapeArea() {Len++;}
        public void ResetSeries(){ Len = 1; }
    }

    internal class CircleSeries : IShapeSeries
    {
        public static double Radius { get; set; }
        public CircleSeries(double r = 1) { Radius = r; }
        int IShapeSeries.CurrentShapeArea 
        { 
            get => (int)(PI*Pow(Radius,2));
            set => Radius = value;
        }
        void IShapeSeries.GetNextShapeArea(){Radius++;}
        void IShapeSeries.ResetSeries(){Radius = 1;}
    }
}
