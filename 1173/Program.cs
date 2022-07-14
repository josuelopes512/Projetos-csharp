using System;

namespace _1173
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor =  new int[10];
            vetor[0] = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++) vetor[i] = vetor[i-1] * 2;
            for (int i=0; i <10; i++) Console.WriteLine($"N[{i}] = {vetor[i]}");
        }
    }
}
