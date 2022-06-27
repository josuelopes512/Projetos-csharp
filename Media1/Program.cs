using System.Globalization;

namespace Media1
{
    class Program
    {
        static void Main(string[] args){
            double a, b, media, p1, p2;
            string result;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p1 = 3.5;
            p2 = 7.5;
            
            media = ((a * p1) + (b * p2))/(p1+p2);
            result = media.ToString("F5", CultureInfo.InvariantCulture);
            
            Console.WriteLine($"MEDIA = {result}");
        }
    }
}