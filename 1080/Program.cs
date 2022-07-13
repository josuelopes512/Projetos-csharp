using System;

namespace _1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int pos = 0, temp = 0;
            for (int i = 0; i < 100; i++)
            {
                int data = int.Parse(Console.ReadLine());
                if (data > temp) 
                {
                    temp = data;
                    pos = i;
                }
            }
            Console.WriteLine($"{temp}");
            Console.WriteLine($"{pos}");
        }
    }
}
