namespace Labb3_Polymorfism
{
    internal class Rectangle : Geometry
    {
        public int SideLengthX { get; set; }
        public int SideLengthY { get; set; }


        public Rectangle()
        {
            Name = "Rectangle";
            SideLengthX = 4;
            SideLengthY = 5;
        }
        public override double Area()
        {
            return SideLengthX * SideLengthY;
        }

    }
}
