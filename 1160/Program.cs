using System;
using System.Collections;
using System.Globalization;


namespace _1160
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = int.Parse(Console.ReadLine());
            ArrayList output = new ArrayList();

            for (int i = 0; i < qtd; i++)
            {
                ArrayList inputs = new ArrayList();
                string[] values = Console.ReadLine().Split(' ');
                int count=0, PA=int.Parse(values[0]), PB=int.Parse(values[1]);
                double G1=double.Parse(values[2], CultureInfo.InvariantCulture), G2=double.Parse(values[3], CultureInfo.InvariantCulture);

                while (PA <= PB && count < 101)
                {
                    PA += (int)((PA*G1)/100);
                    PB += (int)((PB*G2)/100);
                    count++;
                }

                if (count > 100)
                {
                    output.Add("Mais de 1 seculo.");
                }
                else
                {
                    output.Add($"{count} anos.");
                }

                count = 0;
            }
            foreach (var item in output)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
