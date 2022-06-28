using System;
using System.Globalization;

namespace NotasEMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            int nota_100, nota_50, nota_20, nota_10, nota_5, nota_2, nota_1;
            double moeda_100, moeda_050, moeda_025, moeda_010, moeda_005, moeda_001;
            double moeda_total;
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            moeda_total = double.Parse(valor.ToString().Split(',')[1]);

            nota_100 =(int)(valor/100);
            nota_50 = (int)((valor%100)/50);
            nota_20 = (int)(((valor%100)%50)/20);
            nota_10 = (int)((((valor%100)%50)%20)/10);
            nota_5  = (int)(((((valor%100)%50)%20)%10)/5);
            nota_2  = (int)((((((valor%100)%50)%20)%10)%5)/2);
            nota_1  = (int)(((((((valor%100)%50)%20)%10)%5)%2)/1);

            moeda_050 = (int)(moeda_total/0.5);




            Console.WriteLine($"{moeda_total}");
            

            Console.WriteLine($"{valor}");
            Console.WriteLine($"{nota_100} nota(s) de R$ 100,00");
            Console.WriteLine($"{nota_50} nota(s) de R$ 50,00");
            Console.WriteLine($"{nota_20} nota(s) de R$ 20,00");
            Console.WriteLine($"{nota_10} nota(s) de R$ 10,00");
            Console.WriteLine($"{nota_5} nota(s) de R$ 5,00");
            Console.WriteLine($"{nota_2} nota(s) de R$ 2,00");
            Console.WriteLine($"{nota_1} nota(s) de R$ 1,00");
        }
    }
}
