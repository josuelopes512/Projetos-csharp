using System;
using System.Collections;
using System.Globalization;

namespace _1026
{
    class Program
    {
        static int[] StringToIntVec(string[] value){
            // List<int> list = new List<int>(value);
            var search = value.Where(x => x != null).ToList();
            list.AddRange(value);

            // list<int> new_list;
            // int[] new_value = new int[value.Length];
            // if(!(value.Length == 0))
            // {
            //     for (int i = 0; i < new_value.Length; i++)
            //     {
            //         new_value[i] = int.Parse(value[i]);
            //     }
            // }
            // return new_value;
        }

        static void Main(string[] args)
        {
            
            StringToIntVec(Console.ReadLine().Split(' ').Where(x => x != null));
            
            // int[] new_value = new int[3];
            // Console.WriteLine(new_value.Length);
            
            
            // ArrayList datas = new ArrayList(); 



            // try
            // {
            //     while (true)
            //     {
            //         string input = Console.ReadLine().Trim();

            //         if (input.Equals(String.Empty))
            //         {
            //             break;
            //         }
            //         int[] values = StringToIntVec(input.Split(' '));
            //         if(!(values.Length == 0)) break;
            //         int a=values[0], b=values[1], tam_a=0, tam_b=0, mofiz=0, bin=1;
            //         while (a != 0 || b != 0)
            //         {
            //             tam_a = a % 2;
            //             a /= 2;
            //             tam_b = b % 2;
            //             b /= 2;
            //             if ((tam_a+tam_b) == 1)
            //             {
            //                 mofiz += (tam_a+tam_b) * bin;
            //             }
            //             bin *= 2;	
            //         }
            //         datas.Add($"{mofiz}");
            //     }
            // }
            // catch (System.Exception e)
            // {
            //     Console.WriteLine("Error: " + e.StackTrace);
            // }

            // foreach (var data in datas)
            // {
            //     Console.WriteLine(data);
            // }
        }
    }
}
