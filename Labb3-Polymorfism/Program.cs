using System.Linq;

namespace Labb3_Polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry circle = new Circle();
            Geometry square = new Square();
            Geometry rectangle = new Rectangle();

            Geometry[] shapes = [circle, square, rectangle];

            

            foreach(Geometry g in shapes)
            {
                Console.WriteLine($"Area of {g.Name}: {g.Area()}");
            }

            SortBySize(shapes);


        }


        public static void SortBySize(Geometry[] shapes)
        {
            var qry = from s in shapes
                      orderby s.Area()
                      select s;

            Array.ForEach<Geometry>(qry.ToArray<Geometry>(),
                s => Console.WriteLine(s.Area()));
        }
    }


}
