using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("enter a number :");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num != 999)
            {
                Console.Write("enter a number :");
                num = Convert.ToInt32(Console.ReadLine());

                sum = sum + num;

            }
            Console.WriteLine(sum);
        }

    }
}
