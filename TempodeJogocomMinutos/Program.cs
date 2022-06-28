using System;
using System.Globalization;

namespace TempodeJogocomMinutos
{
    public class Program
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
            int s1, s2, tempo, hr, min;
            int[] entrada;
            entrada = StringToIntVec(Console.ReadLine().Split(' ')); // h1 m1 h2 m2

            if (entrada[2] <= entrada[0] && entrada[3] <= entrada[1])
            {
                entrada[2] += 24;
            }
            else if (entrada[3] <= entrada[1])
            {
                entrada[3] += 60;
                entrada[2]--;
            }
            s1 = (entrada[0] * 3600) + (entrada[1] * 60);
            s2 = (entrada[2] * 3600) + (entrada[3] * 60);
            tempo = s2 - s1;
            hr = tempo/3600;
            min=(tempo-(hr*3600))/60;
            Console.WriteLine($"O JOGO DUROU {hr} HORA(S) E {min} MINUTO(S)");
        }
    }
}