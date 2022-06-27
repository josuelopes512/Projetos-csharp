using System;
using System.Globalization;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada_1;
            double triangulo, circulo, trap, quad, retang;
            string triangulo_str, circulo_str, trap_str, quad_str, retang_str;
            double a, b, c, pi=3.14159;


            entrada_1 = Console.ReadLine().Split(' ');

            double[] entrada_1_double = new double[entrada_1.Length];
            for (int i = 0; i < entrada_1_double.Length; i++)
            {   
                entrada_1_double[i] = double.Parse(entrada_1[i], CultureInfo.InvariantCulture);
            }

            a = entrada_1_double[0];
            b = entrada_1_double[1];
            c = entrada_1_double[2];

            triangulo = (a * c)/2;
            circulo = pi * Math.Pow(c, 2);
            trap = ((a+b)*c)/2;
            quad = Math.Pow(b, 2);
            retang = a * b;

            triangulo_str = triangulo.ToString("F3", CultureInfo.InvariantCulture);
            circulo_str = circulo.ToString("F3", CultureInfo.InvariantCulture);
            trap_str = trap.ToString("F3", CultureInfo.InvariantCulture);
            quad_str = quad.ToString("F3", CultureInfo.InvariantCulture);
            retang_str = retang.ToString("F3", CultureInfo.InvariantCulture);

            
            Console.WriteLine($"TRIANGULO: {triangulo_str}");
            Console.WriteLine($"CIRCULO: {circulo_str}");
            Console.WriteLine($"TRAPEZIO: {trap_str}");
            Console.WriteLine($"QUADRADO: {quad_str}");
            Console.WriteLine($"RETANGULO: {retang_str}");
        }
    }
}
