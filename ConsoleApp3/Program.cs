using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ВВедите количество элементов массива:\t");
            int elementCount = int.Parse(Console.ReadLine());
            int[] myArray = new int[elementCount];


            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"ВВедите элемент массива под индексом {i}:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Вывод числел, кратных 3-ем");
            for (int i = 0; i < myArray.Length; i++)

            {
                if (myArray[i]%3 ==0)
                {
                    Console.WriteLine(myArray[i]);
                }
            }Console.ReadLine();
        }
    }
}
