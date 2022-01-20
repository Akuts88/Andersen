using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                string name = "";
                Console.WriteLine("VVedite imya:");
                name = Console.ReadLine();
                if (name == "Вячеслав")
                {
                    Console.WriteLine("Привет,Вячеслав!");
                }
                else
                {
                    Console.WriteLine("Нет такого имени");
                }
               






            }
        }
    }
}
