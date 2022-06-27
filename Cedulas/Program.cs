using System;
using System.Globalization;

namespace Cedulas
{
    public class Program
    {
        static void Main(string[] args){
            int valor, nota_100, nota_50, nota_20, nota_10, nota_5, nota_2, nota_1;
            valor = int.Parse(Console.ReadLine());

            //Solução A
            // nota_100 = valor / 100;
            // nota_50 = (valor%100) / 50;
            // nota_20 = (valor-((nota_100*100)+(nota_50*50)))/20;
            // nota_10 = (valor-((nota_100*100)+(nota_50*50)+(nota_20*20)))/10;
            // nota_5  = (valor-((nota_100*100)+(nota_50*50)+(nota_20*20)+((nota_10*10))))/5;
            // nota_2  = (valor-((nota_100*100)+(nota_50*50)+(nota_20*20)+((nota_10*10))+(nota_5*5)))/2; 
            // nota_1  = (valor-((nota_100*100)+(nota_50*50)+(nota_20*20)+((nota_10*10))+(nota_5*5)+(nota_2*2)));

            //Solução B
            nota_100 = valor/100;
            nota_50 = (valor%100)/50;
            nota_20 = ((valor%100)%50)/20;
            nota_10 = (((valor%100)%50)%20)/10;
            nota_5  = ((((valor%100)%50)%20)%10)/5;
            nota_2  = (((((valor%100)%50)%20)%10)%5)/2;
            nota_1  = ((((((valor%100)%50)%20)%10)%5)%2)/1;

            Console.WriteLine($"{valor}");
            Console.WriteLine($"{nota_100} nota(s) de R$ 100,00");
            Console.WriteLine($"{nota_50} nota(s) de R$ 50,00");
            Console.WriteLine($"{nota_20} nota(s) de R$ 20,00");
            Console.WriteLine($"{nota_10} nota(s) de R$ 10,00");
            Console.WriteLine($"{nota_5} nota(s) de R$ 5,00");
            Console.WriteLine($"{nota_2} nota(s) de R$ 2,00");
            Console.WriteLine($"{nota_1} nota(s) de R$ 1,00");

            // Solução Inspirada Por mim Josué Lopes
        }
    }
}