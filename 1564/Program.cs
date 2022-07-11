using System;
using System.Collections;

namespace _1564
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList datas = new ArrayList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == String.Empty) break; 
                try
                {
                    int valor = int.Parse(input);
                    if (valor == 0) datas.Add("vai ter copa!");
                    else datas.Add("vai ter duas!");
                }
                catch
                {
                    break;
                }
                
            }
            foreach (var data in datas) Console.WriteLine(data);
        }
    }
}
