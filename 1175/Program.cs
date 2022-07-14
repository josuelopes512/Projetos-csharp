using System;

namespace _1175
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] entrada = new int[20];
            int temp = 0;
            for (int i = 0; i < entrada.Length; i++)
            {
                entrada[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0, j=(entrada.Length-1); i<(entrada.Length/2); i++, j--)
            {
                temp=entrada[i];
                entrada[i]=entrada[j];
                entrada[j]=temp;
            }

            for (int i = 0; i < entrada.Length; i++)
            {
                Console.WriteLine($"N[{i}] = {entrada[i]}");
            }
            
        }
    }
}
