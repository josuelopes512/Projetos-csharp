using System;
using System.Globalization;

namespace _1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());

            int totalCobaia=0, totalCoelho=0, totalRatos=0, totalSapos=0;

            for (int i = 0; i < valor; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                totalCobaia += int.Parse(input[0]);

                if (input[1].Equals("R"))
                {
                    totalRatos+= int.Parse(input[0]);
                }
                else if (input[1].Equals("C"))
                {
                    totalCoelho+= int.Parse(input[0]);
                }
                else if (input[1].Equals("S"))
                {
                    totalSapos+= int.Parse(input[0]);
                }
            }

            Console.WriteLine($"Total: {totalCobaia} cobaias");
            Console.WriteLine($"Total de coelhos: {totalCoelho}");
            Console.WriteLine($"Total de ratos: {totalRatos}");
            Console.WriteLine($"Total de sapos: {totalSapos}");
            Console.WriteLine($"Percentual de coelhos: {(((double)totalCoelho/(double)totalCobaia)*100).ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de ratos: {(((double)totalRatos/(double)totalCobaia)*100).ToString("F2", CultureInfo.InvariantCulture)} %");
            Console.WriteLine($"Percentual de sapos: {(((double)totalSapos/(double)totalCobaia)*100).ToString("F2", CultureInfo.InvariantCulture)} %");
        }
    }
}
