using System;

namespace _1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0, input = int.Parse(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                string data = "";
                for (int j = 0; j < 4; j++)
                {
                    count++;
                    if(j == 3)
                    {
                        data += "PUM";
                    }
                    else
                    {
                        data += $"{count} ";
                    }
                }
                Console.WriteLine(data);
            }
        }
    }
}
