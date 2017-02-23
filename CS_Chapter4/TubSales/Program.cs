using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubSales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which sales person did you have?");

            String inputString = Console.ReadLine();

            while (inputString != "A")
            {
                int a = 0;
                Console.WriteLine("How much was the sales worth?");
                int cost = Console.Read();
                Console.WriteLine(cost);

            }


            
           

        }
    }
}
