using System;

namespace ParesEntreCincoNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int par=0, impar=0, pos=0, neg=0;
            for (int i = 0; i < 5; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                if (valor % 2 == 0) par++;
                else impar++;
                if (valor > 0) pos++;
                else if (valor == 0) continue;
                else neg++;
            }

            Console.WriteLine($"{par.ToString()} valor(es) par(es)");
            Console.WriteLine($"{impar.ToString()} valor(es) impar(es)");
            Console.WriteLine($"{pos.ToString()} valor(es) positivo(s)");
            Console.WriteLine($"{neg.ToString()} valor(es) negativo(s)");
        }
    }
}
