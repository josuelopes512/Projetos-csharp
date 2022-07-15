using System;
using System.Linq;
using System.Globalization;

namespace cw_missing_letter
{
    public class Kata
    {
        public static char FindMissingLetter(char[] array)
        {

            var dsdf = String.Join(",", array).ToLower().Split(',');
            foreach (var item in dsdf)
            {
                Console.WriteLine(item);
            }
            return " ".ToChar();
//             int indice_j= 0;
//             char[] alfabeto = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
//             for (int i = 0; i < array.Length; i++)
//             {
//                 // Console.WriteLine($"{indice_j}");
//                 if (indice_j == 0)
//                 {
//                     for (int j = 0; j < alfabeto.Length; j++)
//                     {
//                         if (Char.ToLower(array[i]) != alfabeto[j]) continue;
//                         else
//                         {
//                             indice_j = j;
//                             break;
//                         }
//                     }
//                 }
// //                 Console.WriteLine($"{array[i]} -- {alfabeto[indice_j]} --- {indice_j}");
//                 if((Char.ToLower(array[i]) != alfabeto[indice_j])){
//                     return alfabeto[indice_j];
//                     // Console.WriteLine($"{array[i]} -- {alfabeto[indice_j]} --- {indice_j}");
//                     // break;
//                 }
//                 indice_j++;
                
//                 // Console.WriteLine($"{array[i]} -- {indice_j}");
//                 // Console.WriteLine($"{array[i]} -- {alfabeto[indice_j++]} -- {indice_j}");
//             }
//             // foreach (var item in alfabeto)
//             // {
//             //     Console.WriteLine(item);
//             // }
//             return ' ';
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var lsdk = Kata.FindMissingLetter(new [] { 'O','Q','R','S' });
        }
    }
}
