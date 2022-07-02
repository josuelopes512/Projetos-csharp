using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = new string[3];
            for (int i = 0; i < data.Length; i++){
                data[i] =  Console.ReadLine();
            }
            if (data[0] == "vertebrado"){
                if (data[1] == "ave")
                {
                    if (data[2] == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (data[2] == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (data[1] == "mamifero")
                {
                    if (data[2] == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (data[2] == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else if (data[0] == "invertebrado"){
                if (data[1] == "inseto")
                {
                    if (data[2] == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (data[2] == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (data[1] == "anelideo")
                {
                   if (data[2] == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (data[2] == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    } 
                }
            }
        }
    }
}
