using System;
using System.Globalization;

namespace _1183
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.0;
            double[,] M = new double[12, 12];
            string T = Console.ReadLine().Split(' ')[0];
            int p=1;             
            for(int x=0;x<12;x++)
            {
                for(int y=0; y<12; y++)
                {
                    M[x, y] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            }
            
            for(int z=0; z<12;z++)
            {
                for(int c=p; c<12;c++)
                    a+=M[z, c];
                p++;
            }

            // if(T=="S"){}
            if(T=="M") a=a/66.0;
            
            Console.WriteLine($"{a.ToString("F1", CultureInfo.InvariantCulture)}");
            
        }
    }
}
