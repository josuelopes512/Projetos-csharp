using System;

namespace _1837
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int q=0, r=0, a=int.Parse(inputs[0]), b=int.Parse(inputs[1]);
            if (a >= 0)
            {
                q = a / b;
                r = a % b;
            }
            else
            {
                int x = 0, y=0;
                if (b < 0) x = b * -1;
                else x = b;

                for (r = 0; r < x; r++)
                {
                    y = a - r;
                    if (y % b == 0) break;
                }
                q = y/b;
            }
            Console.WriteLine($"{q} {r}");

        }
    }
}
