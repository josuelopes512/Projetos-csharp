
namespace Diferenca
{
    class Program
    {
        static void Main(string[] args){
            int a, b, c, d, diferenca;
            string result;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            
            diferenca = ((a*b) - (c*d));
            result = diferenca.ToString();
            
            Console.WriteLine($"DIFERENCA = {result}");
        }
    }
}