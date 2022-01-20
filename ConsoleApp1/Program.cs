using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       public static void Main(string[] args)
        {

            while (true)
            {
                string str;
                int a;
                Console.WriteLine("vvedite chislo ");

                str = Console.ReadLine();
                a = Convert.ToInt32(str);




                if (a > 7)
                {
                    Console.WriteLine("Привет!");
                }
            }
             
          
        }
    }
}
