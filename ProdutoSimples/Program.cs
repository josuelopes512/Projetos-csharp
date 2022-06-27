namespace ProdutoSimples
{
    class Program
    {
        static void Main(string[] args){
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"PROD = {a*b}");
        }
    }
}