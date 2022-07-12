using System;
using System.Collections;
using System.Globalization;

namespace _1146
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList inputs = new ArrayList();
            
            while (true)
            {
                int data = int.Parse(Console.ReadLine());
                if (data == 0) break;
                inputs.Add(data);
            }
            foreach (int item in inputs)
            {
                string output = "";
                for (int i = 0; i < item; i++)
                {
                    output += $"{i+1} ";
                }
                Console.WriteLine(output.Trim());
            }
        }
    }
}
