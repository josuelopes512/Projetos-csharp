using System;
using System.Globalization;
using System.Collections;

namespace AsMoedasdeRobbie
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

        static bool EhPrimo(int value){
            for (int i = 2; i < value; i++)
            {
                try
                {
                    if ((value % i) == 0)
                    {
                        return false;   
                    }
                    
                }
                catch (System.Exception)
                {
                    Console.WriteLine($"value: {value}, i: {i}");
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int[] lista = new int[30];
            ArrayList datas = new ArrayList(); 
            int k, s, ans, ok=0, notok=0;

            while (true)
            {
                string moedaString = Console.ReadLine();

                if (moedaString == String.Empty)
                {
                    break;
                }

                int moeda = int.Parse(moedaString);
                for (int i = 0; i < moeda; ++i)
                {
                    lista[i] = int.Parse(Console.ReadLine());
                }
                s = int.Parse(Console.ReadLine());
                ans = 0;
                k = moeda-1;
                while(k>=0)
                {
                    ans += lista[k];
                    k -= s;
                }
                if(EhPrimo(ans)){
                    datas.Add("You’re a coastal aircraft, Robbie, a large silver aircraft.");
                }
                else{
                    datas.Add("Bad boy! I’ll hit you.");
                }
            }

            foreach (var data in datas)
            {
                Console.WriteLine(data);
            }
        }
    }
}
