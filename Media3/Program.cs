using System;
using System.Globalization;

namespace Media3
{
    class Program
    {
        static double[] StringToDoubleVec(string[] value){
            double[] new_value = new double[value.Length];
            for (int i = 0; i < new_value.Length; i++)
            {
                try
                {
                    new_value[i] = double.Parse(value[i], CultureInfo.InvariantCulture);
                }
                catch (System.Exception)
                {
                    Console.WriteLine("ERROR");
                }
            }
            return new_value;
        }

        static void Main(string[] args)
        {
            double[] notas = StringToDoubleVec(Console.ReadLine().Split(' '));
            double a, b, c, d, media, mf;

            a = notas[0];
            b = notas[1];
            c = notas[2];
            d = notas[3];

            media = Math.Truncate(((a * 2) + (b * 3)+ (c * 4) + d)/(2+3+4+1));

            if (media >= 7)
            {
                Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Aluno aprovado.");
            }
            else if(media < 5){
                Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Aluno reprovado.");
            }
            else if(media >= 5 && media < 7){
                mf = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
                media = (media + mf)/2;
                Console.WriteLine("Aluno em exame.");
                Console.WriteLine($"Nota do exame: {mf.ToString("F1", CultureInfo.InvariantCulture)}");
                if (media >= 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine($"Media final: {media.ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
