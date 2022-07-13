using System;

namespace _1847
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
            int[] dias = StringToIntVec(Console.ReadLine().Split(' '));
            int dia_1=dias[0], dia_2=dias[1], dia_3=dias[2];

            if (dia_1 > dia_2)
            {
                if (dia_2 > dia_3)
                {
                    if ((dia_2-dia_3) < (dia_1-dia_2)) Console.WriteLine(":)");
                    else Console.WriteLine(":(");
                }
                else Console.WriteLine(":)");
            }
            else if (dia_2 > dia_1)
            {
                if (dia_3 > dia_2)
                {
                    if ((dia_3-dia_2) < (dia_2-dia_1)) Console.WriteLine(":(");
                    else Console.WriteLine(":)");
                }
                else Console.WriteLine(":(");
            }
            else if (dia_3 > dia_2) Console.WriteLine(":)");
            else Console.WriteLine(":(");
        }
    }
}
