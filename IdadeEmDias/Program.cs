using System;
using System.Globalization;

namespace IdadeEmDias
{
    class Program
    {
        static void Main(string[] args)
        {
            int dias, ano, mes, dia;
            dias = int.Parse(Console.ReadLine());
            ano = dias/365;
            mes = (dias%365)/30;
            dia = (dias%365)%30;
            Console.WriteLine($"{ano} ano(s)");
            Console.WriteLine($"{mes} mes(es)");
            Console.WriteLine($"{dia} dia(s)");


        //     double dias, ano, mes, dia;
        //     string ano_str, mes_str, dia_str;

        //     dias = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        //     ano = dias/365;
        //     mes = (dias%365)/30;
        //     dia = (dias%365)%30;

        //     ano_str = ano.ToString("F0", CultureInfo.InvariantCulture);
        //     mes_str = mes.ToString("F0", CultureInfo.InvariantCulture);
        //     dia_str = dia.ToString("F0", CultureInfo.InvariantCulture);

        //     Console.WriteLine($"{ano_str} ano(s)");
        //     Console.WriteLine($"{mes_str} mes(es)");
        //     Console.WriteLine($"{dia_str} dia(s)");
        }
    }
}
