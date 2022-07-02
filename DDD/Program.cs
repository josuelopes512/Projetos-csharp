using System;

namespace DDD
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            string estado;

            if(valor == 61) estado = "Brasilia";
            else if(valor == 71) estado = "Salvador";
            else if(valor == 11) estado = "Sao Paulo";
            else if(valor == 21) estado = "Rio de Janeiro";
            else if(valor == 32) estado = "Juiz de Fora";
            else if(valor == 19) estado = "Campinas";
            else if(valor == 27) estado = "Vitoria";
            else if(valor == 31) estado = "Belo Horizonte";
            else estado = "DDD nao cadastrado";
            Console.WriteLine($"{estado}");
        }
    }
}
