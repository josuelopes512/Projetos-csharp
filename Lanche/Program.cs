using System;
using System.Globalization;

namespace Lanche
{
    class Program
    {
        static int[] StringToIntVec(string[] value){
            int[] new_value = new int[value.Length];
            for (int i = 0; i < new_value.Length; i++)
            {
                try
                {
                    new_value[i] = int.Parse(value[i], CultureInfo.InvariantCulture);
                }
                catch (System.Exception)
                {
                    Console.WriteLine("ERROR");
                }
            }
            return new_value;
        }
        static void Main(string[] args)
        {
            int[] input = StringToIntVec(Console.ReadLine().Split(' '));
            double result = 0;

            if (input[0] == 1)
            {
                result = 4.00 * input[1];
            }
            else if (input[0] == 2)
            {
                result = 4.50 * input[1];
            }
            else if (input[0] == 3)
            {
                result = 5.00 * input[1];
            }
            else if (input[0] == 4)
            {
                result = 2.00 * input[1];
            }
            else if (input[0] == 5)
            {
                result = 1.50 * input[1];
            }
            
            Console.WriteLine($"Total: R$ {result.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
