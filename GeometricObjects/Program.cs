using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(-10, 5, 7);

            Console.WriteLine($"Radius = {c1.Radius}");
            Console.WriteLine($"Y Koordinaten = {c1.XCoordinate}");
            Console.WriteLine($"X Koordinaten = {c1.YCoordinate}");
            Console.WriteLine($"Flache = {c1.GetArea()}");
            Console.WriteLine($"Umfang = {c1.GetCircumference()}");

            Console.WriteLine("Move wird ausgefürt");

            c1.Move(5, -2, 20);

            Console.WriteLine($"Radius = {c1.Radius}");
            Console.WriteLine($"Y Koordinaten = {c1.XCoordinate}");
            Console.WriteLine($"X Koordinaten = {c1.YCoordinate}");
            Console.WriteLine($"Flache = {c1.GetArea()}");
            Console.WriteLine($"Umfang = {c1.GetCircumference()}");

            Console.ReadLine();
            
        }
    }
}
