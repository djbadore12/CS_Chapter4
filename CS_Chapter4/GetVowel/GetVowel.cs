using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVowel
{
    class GetVowel
    {
        static void Main(string[] args)
        {

            /*
            while (true)
            {
                char ch = Console.ReadKey().KeyChar;

                Console.WriteLine("You typed '{0}'", ch);

                if (ch == '!')
                    break;
            }
            */

            Console.Write("Enter a letter: ");
            string sentence = Console.ReadLine().ToLower();


            while (sentence != "!")
            {
                if ("aeiou".Contains(sentence))
                {
                   
                    Console.WriteLine("ok");

                }
                else 
                {
                    Console.WriteLine("error");
                }


                Console.Write("Enter a letter: ");
                sentence = Console.ReadLine().ToLower();
            }


            /* for (int i = 0; i < sentence.Length; i++)
             {
                 if (sentence.Contains("a") || sentence.Contains("e") || sentence.Contains("i") || sentence.Contains("o") || sentence.Contains("u"))
                 {
                     Console.WriteLine("ok");
                 }
                else  Console.WriteLine("error");
                 */
        }

    }

}

