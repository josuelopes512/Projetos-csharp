using System;

namespace _1973
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
            int j = 0, n = int.Parse(Console.ReadLine());
            int[] estrela = new int[n], carneiro = new int[n];

            double totalEstrela = 0, totalCarneiro = 0;

            carneiro = StringToIntVec(Console.ReadLine().Split(' '));
            for (int i = 0; i < n; i++) estrela[i] = 0;
            
            while (true)
            {
                if (j == 0 && carneiro[j] % 2 == 0)
                {
                    estrela[j] = 1;
                    if (carneiro[j] > 0) carneiro[j]--;
                    break;
                }
                else if (j == (n-1) && carneiro[j] % 2 == 1) 
                {
                    estrela[j] = 1;
                    if (carneiro[j] > 0) carneiro[j]--;
                    break;
                } 
                else if (carneiro[j] % 2 == 1) 
                {
                    if (carneiro[j] > 0) carneiro[j]--;
                    estrela[j] = 1;
                    j++;
                } 
                else if (carneiro[j] % 2 == 0) 
                {
                    estrela[j] = 1;
                    if (carneiro[j] > 0) carneiro[j]--;
                    j--;
                }
            }
            for (int i = 0; i < n; i++) {
                totalCarneiro += carneiro[i];
                totalEstrela += estrela[i];
            }
            Console.WriteLine($"{totalEstrela} {totalCarneiro}");
        }
    }
}
