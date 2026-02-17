namespace Day8.Interfaces
{
    internal interface IShapeSeries
    {
        public int CurrentShapeArea { get; set; }
        void GetNextShapeArea();
        void ResetSeries();
    }
}
