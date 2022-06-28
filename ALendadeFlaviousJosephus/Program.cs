using System;
using System.Globalization;

namespace ALendadeFlaviousJosephus
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

        static int VerSobrevivente(int pessoas, int salto){
            if (pessoas == 1)
            {
                return 1;
            }
            return (VerSobrevivente(pessoas-1, salto) + salto-1) % pessoas + 1;
        }

        static void Main(string[] args){
            int n;
            int[] pessoas_salto, sobrevive;

            n = int.Parse(Console.ReadLine());
            sobrevive = new int[n];

            for (int i = 0; i < n; i++)
            {
                pessoas_salto = StringToIntVec(Console.ReadLine().Split(' '));
                sobrevive[i] = VerSobrevivente(pessoas_salto[0], pessoas_salto[1]);
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Case {i+1}: {sobrevive[i]}");
            }         
        }
    }
}