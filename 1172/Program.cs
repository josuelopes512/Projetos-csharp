using System;

namespace _1172
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];
            for (int i = 0; i < data.Length; i++) data[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < data.Length; i++) if(data[i] <= 0) data[i] = 1;
            for (int i = 0; i < data.Length; i++) Console.WriteLine($"X[{i}] = {data[i]}");
        }
    }
}
