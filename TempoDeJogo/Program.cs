using System;
using System.Globalization;

namespace TempoDeJogo
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
        
        static void Main(string[] args){
            int hr;
            int[] entrada = StringToIntVec(Console.ReadLine().Split(' ')); // h1 m1 h2 m2
            if (entrada[0] > entrada[1])
            {
                hr = 24 - (entrada[0] - entrada[1]);
            }
            else if (entrada[0] < entrada[1])
            {
                hr = (entrada[1] - entrada[0]);
            }
            else{
                hr = 24;
            }
            
            Console.WriteLine($"O JOGO DUROU {hr} HORA(S)");
        }
    }
}
