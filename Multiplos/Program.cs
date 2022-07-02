using System;
using System.Globalization;

namespace Multiplos
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
            if(vetor[0] % vetor[1] == 0 || vetor[1] % vetor[0] == 0){
                Console.WriteLine("Sao Multiplos");
            }
            else{
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
