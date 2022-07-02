using System;

namespace SomaDeImparesConsecutivosI
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, soma=0;
            valor1 = int.Parse(Console.ReadLine());
            valor2 = int.Parse(Console.ReadLine());

            if (valor1 < valor2) {
                for (int i = valor1 + 1; i < valor2; i++) {
                    if (i % 2 != 0) {
                        soma += i;
                    }
                }
            } 
            else {
                for (int i= valor2 + 1; i < valor1; i++) {
                    if (i % 2 != 0) {
                        soma += i;
                    }
                }
            }
            
            Console.WriteLine(soma);
        }
    }
}
