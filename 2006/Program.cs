using System;

namespace _2006
{
    class Program
    {
        static void Main(string[] args)
        {
            int count=0, valor = int.Parse(Console.ReadLine());
            int[] array = Array.ConvertAll(Console.ReadLine().TrimEnd().Split(' '), int.Parse);
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == valor) count++;
            }
            Console.WriteLine(count);
        }
    }
}
