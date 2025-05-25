using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double monto, m1, m2, m3, m4, p1,p2,p3,p4;
            int e1, e2, e3, e4,suma;

            Console.WriteLine("Ingrese monto a repartir");
            monto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese edad niña 1");
            e1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese edad niña 2");
            e2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese edad niña 3");
            e3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese edad niña 4");
            e4 = Convert.ToInt32(Console.ReadLine());

            suma = e1 + e2 + e3 + e4;

            p1 = ((double)e1 / suma) * 100;
            p2 = ((double)e2 / suma) * 100;
            p3 = ((double)e3 / suma) * 100;
            p4 = ((double)e4 / suma) * 100;

            m1 = (p1 * monto)/100;
            m2 = (p2 * monto)/100;
            m3 = (p3 * monto)/100;
            m4 = (p4 * monto)/100;

            Console.WriteLine(("Monto niña 1: {0}// Porcentaje:{1}"), m1, p1);
            Console.WriteLine(("Monto niña 1: {0}// Porcentaje:{1}"), m2, p2);
            Console.WriteLine(("Monto niña 1: {0}// Porcentaje:{1}"), m3, p3);
            Console.WriteLine(("Monto niña 1: {0}// Porcentaje:{1}"), m4, p4);



        }
    }
}
