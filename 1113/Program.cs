using System;

namespace _1113
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

            int[] input = StringToIntVec(Console.ReadLine().Split(' '));

            int a=input[0], b=input[1];

            while (a != b)
            {
                if (a < b)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }
                input = StringToIntVec(Console.ReadLine().Split(' '));
                a=input[0];
                b=input[1];
            }            
        }
    }
}
