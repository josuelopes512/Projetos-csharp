using System;
using System.Collections;
using System.Globalization;

namespace _1114
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            ArrayList inputs = new ArrayList();
            
            while (true)
            {
                int data = int.Parse(Console.ReadLine());
                inputs.Add(data);
                if (data == 2002) break; 
            }
            foreach (int item in inputs)
            {
                if (item == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                }
            }
        }
    }
}
