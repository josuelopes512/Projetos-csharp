using System;
using System.Globalization;

namespace TiposDeTriangulos
{
    class Program
    {
        static double[] StringToDoubleVec(string[] value){
            double[] new_value = new double[value.Length];
            for (int i = 0; i < new_value.Length; i++){
                new_value[i] = double.Parse(value[i], CultureInfo.InvariantCulture);
            }
            return new_value;
        }

        static void Main(string[] args)
        {
            double[] inputs = StringToDoubleVec(Console.ReadLine().Split(' '));
            double a=inputs[0], b=inputs[1], c=inputs[2], aux, a2, bc;

            if (b > a)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if (c > a)
            {
                aux = a;
                a = c;
                c = aux;
            }
            
            a2 = Math.Pow(a, 2);
            bc = Math.Pow(b, 2) + Math.Pow(c, 2);

            if (a >= (b+c)){
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else{
                if (a2 > bc){
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else if (a2 < bc){
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                else{
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                if (a == b && b == c){
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (a == b || a == c || b == c){
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}
