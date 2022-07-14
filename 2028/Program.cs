using System;
using System.Collections;
using System.Globalization;

namespace _2028
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList valores = new ArrayList(); 
            int numeros = 0, caso = 1;
            string input;
            while ((input = Console.ReadLine()) != String.Empty)
            {
                string num = "";
                int n = int.Parse(input);
                numeros = 1;

                for (int i = 0; i <= n; i++) numeros += i;
                valores.Add($"Caso {caso}: {numeros} numero{(numeros == 1 ? "" : "s")}");

                for (int i = 0; i <= n; i++) {
                    if (i == 0) num += $"{(n > 0 ? "0 ": "0")}";
                    for (int j = 0; j < i; j++) {
                        if (i == n && j == n-1) num += $"{i}";
                        else num += $"{i} ";
                    }
                }
                valores.Add(num.Trim());
                valores.Add(" ");
                caso++;
            }
            foreach (var valor in valores) Console.WriteLine(valor);
        }
    }
}
