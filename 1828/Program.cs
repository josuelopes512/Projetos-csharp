using System;
using System.Collections;
using System.Globalization;

namespace _1828
{
    class Program
    {
        static void Main(string[] args)
        {
            int count=0, qtd = int.Parse(Console.ReadLine());
            ArrayList outputs = new ArrayList();

            for (int i = 0; i < qtd; i++)
            {
                string[] jogada = Console.ReadLine().Split(' ');
                string sheldon=jogada[0], raj=jogada[1];

                count++;
                if (sheldon.Equals(raj, StringComparison.OrdinalIgnoreCase))
                {
                    outputs.Add($"Caso #{count}: De novo!");
                }
                else if (
                    sheldon.Equals("Spock", StringComparison.OrdinalIgnoreCase) && raj.Equals("pedra", StringComparison.OrdinalIgnoreCase) ||
                    sheldon.Equals("lagarto", StringComparison.OrdinalIgnoreCase) && raj.Equals("Spock", StringComparison.OrdinalIgnoreCase) ||
                    sheldon.Equals("tesoura", StringComparison.OrdinalIgnoreCase) && raj.Equals("lagarto", StringComparison.OrdinalIgnoreCase) ||
                    sheldon.Equals("papel", StringComparison.OrdinalIgnoreCase) && raj.Equals("Spock", StringComparison.OrdinalIgnoreCase) ||
                    sheldon.Equals("tesoura", StringComparison.OrdinalIgnoreCase) && raj.Equals("papel", StringComparison.OrdinalIgnoreCase) ||
                    sheldon.Equals("papel", StringComparison.OrdinalIgnoreCase) && raj.Equals("pedra", StringComparison.OrdinalIgnoreCase) ||
                    sheldon.Equals("lagarto", StringComparison.OrdinalIgnoreCase) && raj.Equals("papel", StringComparison.OrdinalIgnoreCase) ||
                    sheldon.Equals("pedra", StringComparison.OrdinalIgnoreCase) && raj.Equals("lagarto", StringComparison.OrdinalIgnoreCase) ||
                    sheldon.Equals("Spock", StringComparison.OrdinalIgnoreCase) && raj.Equals("tesoura", StringComparison.OrdinalIgnoreCase) ||
                    sheldon.Equals("pedra", StringComparison.OrdinalIgnoreCase) && raj.Equals("tesoura", StringComparison.OrdinalIgnoreCase)
                )
                {
                    outputs.Add($"Caso #{count}: Bazinga!");
                }
                else
                {
                    outputs.Add($"Caso #{count}: Raj trapaceou!");
                }
            }

            foreach (string item in outputs)
            {
                Console.WriteLine($"{item}");

            }

        }
    }
}
