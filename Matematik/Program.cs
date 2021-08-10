using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Geben Sie eine Zahl");
            Mathe.Zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Geben Sie eine 2 Zahl");
            Mathe.Zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" Die Lösung ist = {Mathe.Plus(Mathe.Zahl1, Mathe.Zahl2)}");

            Console.ReadLine();
        }
     }
}

