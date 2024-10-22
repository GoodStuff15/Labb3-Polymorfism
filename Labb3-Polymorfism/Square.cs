namespace Labb3_Polymorfism
{
    internal class Square : Geometry
    {
        public int SideLength { get; set; }
        
        public Square()
        {
            Name = "Square";
            SideLength = 4;
        }
        public override double Area()
        {
            return SideLength * SideLength;
        }
    }
}
