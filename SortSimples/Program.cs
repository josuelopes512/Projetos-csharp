using System;
using System.Globalization;

namespace SortSimples
{
    class Program
    {
        static int[] StringToIntVec(string[] value){
            int[] new_value = new int[value.Length];
            for (int i = 0; i < new_value.Length; i++){
                new_value[i] = int.Parse(value[i]);
            }
            return new_value;
        }
        static void Main(string[] args)
        {
            int[] vetor = StringToIntVec(Console.ReadLine().Split(' '));
            int[] new_vect = (int[])vetor.Clone();

            for (int i = 0; i < new_vect.Length-1; i++){
                for (int j = i+1; j < new_vect.Length; j++){
                    if (new_vect[i] > new_vect[j]){
                        int tmp = new_vect[i];
                        new_vect[i] = new_vect[j];
                        new_vect[j] = tmp;
                    }
                }
            }

            for (int i = 0; i < new_vect.Length; i++)
            {
                Console.WriteLine($"{new_vect[i]}");
            }
            Console.WriteLine("");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"{vetor[i]}");
            }
        }
    }
}
