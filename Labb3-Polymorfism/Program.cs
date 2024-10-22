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

            Console.WriteLine("\nSorting by Area, starting with the lowest number:");
            Array.ForEach(qry.ToArray(),
                s => Console.WriteLine($"Area of {s.Name}: {s.Area().ToString("# 'cm3'")}"));
        }
    }


}
