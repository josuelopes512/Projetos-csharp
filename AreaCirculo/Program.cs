
using System.Globalization;



namespace AreaCirculo
{
    class Program
    {
        static void Main(string[] args){
            double raio, area, pi;
            string result;

            pi = 3.14159;
            // Console.WriteLine("Digite o valor de um raio: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = pi * Math.Pow(raio, 2);
            result = area.ToString("F4", CultureInfo.InvariantCulture);
            Console.WriteLine($"A={result}");
        }
    }
}