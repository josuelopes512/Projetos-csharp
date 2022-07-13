using System;
using System.Collections;
using System.Globalization;

namespace _1023
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
            int[] arr = new int[300];
            int c = 1;
            string saida;

            ArrayList datas_1 = new ArrayList(); 

            while (true)
            {
                int ta = 0, tp = 0, fp = 0, a, b, valor = int.Parse(Console.ReadLine());
                double ip;
                ArrayList datas_2 = new ArrayList(); 
                if(valor == 0) break;

                ta = tp = 0;
                for (int i = 0; i < arr.Length; i++) 
                {
                    arr[i] = 0;
                }

                for (int i = 0; i < valor; ++i)
                {
                    int[] data = StringToIntVec(Console.ReadLine().Split(' '));
                    a=data[0];
                    b=data[1];
                    if(!((a >= 1 && a <= 10) && (b >= 1 && b <= 200))) continue;
                    ta += b;
                    tp += a;
                    arr[b/a] += a;
                }
                datas_2.Add($"Cidade# {c}:");
                c++;
                saida = "";
                for(int i = 0, j = 0; i < arr.Length; i++)
                {
                    if(arr[i] > 0)
                    {
                        if(j != 0) saida += " ";
                        saida += $"{arr[i]}-{i}";
                        j++;   
                    }  
                }
                datas_2.Add(saida.Trim());

                ip = Math.Floor((double)(ta/tp));

                double fpd = (double)ta/(double)tp;
                fpd = ((fpd - ip)*100);
                fp = (int)fpd;
                
                
                if (fp < 10) datas_2.Add($"Consumo medio: {(int)ip}.0{(int)fp} m3.");
                else datas_2.Add($"Consumo medio: {(int)ip}.{(int)fp} m3.");
                datas_2.Add("");
                datas_1.Add(datas_2);
            }
            ArrayList obj = (ArrayList)datas_1[datas_1.Count - 1];
            obj.RemoveAt((obj.Count - 1));

            foreach (ArrayList items in datas_1)
            {
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
