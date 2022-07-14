using System;

namespace _2162
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
            int padrao = 0, tam = int.Parse(Console.ReadLine());
            int[] valores = new int[tam];
            valores = StringToIntVec(Console.ReadLine().Split(' '));
            if(tam > 2)
            {
                for (int i = 0; i < tam; i++)
                {
                    if ((valores[i-2] > valores[i-1] && valores[i-1] < valores[i]) || (valores[i-2] < valores[i-1] && valores[i-1] > valores[i]) )
                    {
                        padrao = 0;
                    }
                    else {
                        padrao = 1;
                        break;
                    }
                }
            }
            else{
                if (valores[0] != valores[1]) padrao = 1;
            }
            Console.WriteLine(padrao);
        }
    }
}
