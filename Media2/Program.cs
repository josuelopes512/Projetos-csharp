using System.Globalization;

namespace Media2
{
    class Program
    {
        static void Main(string[] args){
            double a, b, c, media, p1, p2, p3;
            string result;

            p1 = 2;
            p2 = 3;
            p3 = 5;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            media = ((a * p1) + (b * p2)+ (c * p3))/(p1+p2+p3);
            result = media.ToString("F1", CultureInfo.InvariantCulture);
            
            Console.WriteLine($"MEDIA = {result}");
        }
    }
}