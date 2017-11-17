using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cual es la medida de un lado del cubo: ");
            int cubo = int.Parse(Console.ReadLine());

            Console.WriteLine("Dimensiones: " + cubo + " alto, " + cubo + " ancho, " + cubo + " profundidad ");
            Console.WriteLine("Volumen. " + cubo * cubo * cubo);
            Console.ReadKey();
        }
    }
}
