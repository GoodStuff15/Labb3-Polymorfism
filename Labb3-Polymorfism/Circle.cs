namespace Labb3_Polymorfism
{
    internal class Circle : Geometry
    {
        public double Radius { get; set; }
        static double pi { get; set; } = 3.141;

        public Circle()
        {
            Name = "Circle";
            Radius = 4;
        }

        public override double Area()
        {
            return Radius * Radius * pi;
        }
    }
}
