using System;
using System.Globalization;

namespace NotasEMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, moeda_total;
            string valor_str, input_txt;
            int nota_100, nota_50, nota_20, nota_10, nota_5, nota_2;
            int moeda_100, moeda_050, moeda_025, moeda_010, moeda_005, moeda_001;
            input_txt = Console.ReadLine();

            if (input_txt.Contains(','))
            {
                input_txt = input_txt.Replace(',', '.');
            }

            valor = double.Parse(input_txt, CultureInfo.InvariantCulture);
            valor_str = valor.ToString("F2", CultureInfo.InvariantCulture);
            moeda_total = double.Parse(valor_str.Split('.')[1]);
            
            nota_100 = (int)(valor/100);
            nota_50  = (int)((valor%100)/50);
            nota_20  = (int)(((valor%100)%50)/20);
            nota_10  = (int)((((valor%100)%50)%20)/10);
            nota_5   = (int)(((((valor%100)%50)%20)%10)/5);
            nota_2   = (int)((((((valor%100)%50)%20)%10)%5)/2);
            
            moeda_100   = (int)(((((((valor%100)%50)%20)%10)%5)%2)/1);
            moeda_050 = (int)(moeda_total/50);
            moeda_025 = (int)((moeda_total%50)/25);
            moeda_010 = (int)(((moeda_total%50)%25)/10);
            moeda_005 = (int)((((moeda_total%50)%25)%10)/5);
            moeda_001 = (int)(((((moeda_total%50)%25)%10)%5)/1);

            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{nota_100} nota(s) de R$ 100.00");
            Console.WriteLine($"{nota_50} nota(s) de R$ 50.00");
            Console.WriteLine($"{nota_20} nota(s) de R$ 20.00");
            Console.WriteLine($"{nota_10} nota(s) de R$ 10.00");
            Console.WriteLine($"{nota_5} nota(s) de R$ 5.00");
            Console.WriteLine($"{nota_2} nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{moeda_100} moeda(s) de R$ 1.00");
            Console.WriteLine($"{moeda_050} moeda(s) de R$ 0.50");
            Console.WriteLine($"{moeda_025} moeda(s) de R$ 0.25");
            Console.WriteLine($"{moeda_010} moeda(s) de R$ 0.10");
            Console.WriteLine($"{moeda_005} moeda(s) de R$ 0.05");
            Console.WriteLine($"{moeda_001} moeda(s) de R$ 0.01");
        }
    }
}
