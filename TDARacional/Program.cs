using System;

namespace TDARacional
{
    class Program
    {
        static int mdc(int a, int b){
            if(a<0)
                a = -a;
            if(b<0)
                b = -b;
            if(a%b == 0)
                return b;
            else
                return mdc(b,a%b);
        }
        
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            string[] result = new string[valor];
            for (int i = 0; i < valor; i++)
            {
                int num=0, den=0, div, n1, d1, n2, d2;
                string[] entrada = Console.ReadLine().Split(' ');
                string oper = entrada[3];
                n1 = int.Parse(entrada[0]);
                d1 = int.Parse(entrada[2]);
                n2 = int.Parse(entrada[4]);
                d2 = int.Parse(entrada[6]);
                if (oper.Equals("+"))
                {
                    num = (n1*d2 + n2*d1);
                    den = (d1*d2);
                }
                else if(oper.Equals("-")){
                    num = (n1*d2 - n2*d1);
                    den = (d1*d2);
                }

                else if(oper.Equals("*")){
                    num = (n1*n2);
                    den = (d1*d2);
                }

                else if(oper.Equals("/")){
                    num = (n1*d2);
                    den = (n2*d1);
                }
                div = mdc(num,den);
                result[i] = $"{num}/{den} = {num/div}/{den/div}";
            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"{result[i]}");
            }

        }
    }
}
