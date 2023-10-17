using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14;
            Console.WriteLine("Introduce la medida del radio");
            double r = int.Parse(Console.ReadLine());

             double area = PI * Math.Pow(r, 2);

            Console.WriteLine("El area del circulo es " + area);
        }
    }
}
