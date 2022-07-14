using System;

namespace _1132
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma=0, v1 = int.Parse(Console.ReadLine()), v2 = int.Parse(Console.ReadLine());
            
            if (v1 < v2) {
                for (int i = v1; i <= v2; i++) 
                {
                    if (i % 13 != 0) soma += i;
                }
            }
            else {
                for (int i = v2; i <= v1; i++) 
                {
                    if (i % 13 != 0) 
                    {
                        soma += i;
                    }
                }
            }
            Console.WriteLine(soma);
        }
    }
}
