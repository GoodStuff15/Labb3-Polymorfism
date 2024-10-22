namespace Labb3_Polymorfism
{
    internal class Geometry
    {
        public string Name { get; set; }
        public Geometry()
        {

        }

        public virtual double Area()
        {
            return 1;
        }
    }
}
