using System;

namespace Intervalo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int vin=0, vout=0, qtd = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtd; i++){
                int valor = int.Parse(Console.ReadLine());
                if (valor >= 10 && valor <= 20) vin++;
                else vout++;
            }
            Console.WriteLine($"{vin} in");
            Console.WriteLine($"{vout} out");
        }
    }
}
