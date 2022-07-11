using System;

namespace _1101
{
    class Program
    {
        static int[] StringToIntVec(string[] value){
            int[] new_value = new int[value.Length];
            for (int i = 0; i < new_value.Length; i++)
            {
                new_value[i] = int.Parse(value[i]);
            }
            return new_value;
        }

        static void Main(string[] args)
        {
            string[] saida = new string[200];
            int cont = 0;

            while (true)
            {
                string input = Console.ReadLine();
                try
                {
                    if (input == String.Empty) break; 
                    int[] valor = StringToIntVec(input.Split(' '));
                    string str = "";
                    int maior, menor, sum = 0;
                    if(valor[0] <= 0 || valor[1] <= 0) break;
                    if (valor[0] > valor[1])
                    {
                        maior = valor[0];
                        menor = valor[1];
                    }
                    else
                    {
                        maior = valor[1];
                        menor = valor[0];
                    }
                    for (int j = menor; j < maior+1; j++)
                    {
                        str += $"{j} ";
                        sum += j;
                    }
                    str += $"Sum={sum}";
                    saida[cont] = str;

                }
                catch (System.Exception)
                {
                    
                    break;
                }
                
                cont++;
            }



            // for (int i = 0; i < 3; i++)
            // {
            //     int[] valor = StringToIntVec(Console.ReadLine().Split(' '));
            //     string str = "";
            //     int maior, menor, sum = 0;
            //     if(valor[0] <= 0 || valor[1] <= 0) break;
            //     if (valor[0] > valor[1])
            //     {
            //         maior = valor[0];
            //         menor = valor[1];
            //     }
            //     else
            //     {
            //         maior = valor[1];
            //         menor = valor[0];
            //     }
            //     for (int j = menor; j < maior+1; j++)
            //     {
            //         str += $"{j} ";
            //         sum += j;
            //     }
            //     str += $"Sum={sum}";
            //     saida[i] = str;
            // }
            foreach (string str in saida) Console.WriteLine(str);
        }
    }
}
