using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_repos6
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Num1, Num2;
            int i = 0;
            Double Suma = 0, Multi = 0, Div = 0;
            Console.WriteLine("Ingrese el numero 1: ");
            Num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2: ");
            Num2 = Double.Parse(Console.ReadLine());
            Suma = Num1 + Num2;
            Multi = Num1 * Num2;
            Div = Num1 / Num2;
            Console.WriteLine("El resultado de la suma es de:{0} ", Suma);
            Console.WriteLine("El resultado de la Multiplicacion es: {1}", Multi);
            Console.WriteLine("El resultado de la Multiplicacion es: {2}", Div);
            Console.ReadKey();
        }
    }
}
