using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaPensarEj1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Ingrese 2 numeros para su suma");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El resultado de la suma de " + a.ToString() + " y " + b.ToString() + " es " + (a + b).ToString());
            Console.ReadKey();
        }
    }
}
