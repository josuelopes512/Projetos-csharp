using System;

namespace FormulaDeBaskara
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
        }
    }
}
