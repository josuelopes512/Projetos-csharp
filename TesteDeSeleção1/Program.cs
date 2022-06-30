using System;

namespace TesteDeSeleção1
{
    class Program
    {
        static int[] StringToIntVec(string[] value){
            int[] new_value = new int[value.Length];
            for (int i = 0; i < new_value.Length; i++)
            {
                new_value[i] = int.Parse(value[i]);
            }
            return new_value;
        }

        static void Main(string[] args)
        {
            int[] input;
            input = StringToIntVec(Console.ReadLine().Split(' '));
            int A, B, C, D;
            A = input[0];
            B = input[1];
            C = input[2];
            D = input[3];

            if (B > C && D > A && (C+D) > (A+B) && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
