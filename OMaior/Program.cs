using System;

namespace OMaior
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, total;
            string total_str;
            string[] entrada_1;
            entrada_1 = Console.ReadLine().Split(' ');

            int[] entrada_1_int = new int[entrada_1.Length];
            for (int i = 0; i < entrada_1_int.Length; i++)
            {   
                entrada_1_int[i] = int.Parse(entrada_1[i]);
            }

            a = entrada_1_int[0];
            b = entrada_1_int[1];
            c = entrada_1_int[2];

            total = (a + b + Math.Abs(a-b))/2;
            total = (total + c + Math.Abs(total-c))/2;

            total_str = total.ToString();

            Console.WriteLine($"{total_str} eh o maior");

        }
    }
}
