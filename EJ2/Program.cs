using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double masa, masasobran, cajasR, envolR, moldesR, cajas, envol, molde;

            Console.WriteLine("Ingrese cantidad de masa total");
            masa = Convert.ToDouble(Console.ReadLine());

            cajas = 20;
            envol = 12;
            molde = 55;

            moldesR = Math.Truncate(masa / molde);
            envolR = Math.Truncate(moldesR / envol);
            cajasR = Math.Truncate(envolR / cajas);
            masasobran = Math.Truncate(masa - (moldesR * molde));

            Console.WriteLine("Cantidad budines {0}", moldesR);
            Console.WriteLine("Cantidad envoltorios {0}", envolR);
            Console.WriteLine("Cantidad cajas {0}", cajasR);
            Console.WriteLine("Cantidad masa sobrante {0}", masasobran);
        }
    }
}
