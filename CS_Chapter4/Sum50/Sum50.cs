using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum50
{
    class Sum50
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                sum = sum + i;

                Console.WriteLine(sum);
            }

        } 
    }
}
