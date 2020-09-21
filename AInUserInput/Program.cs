using Microsoft.VisualBasic;
using System;

namespace AInUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your name?");

            string UserInput = Console.ReadLine();
            int counter = 0;
            char searchCriteria = 'a';

            foreach (var letter in UserInput)
            {
                if (letter == searchCriteria)
                {
                    counter = counter + 1;

                }
                if (counter > 0)
                {
                    Console.WriteLine($"tHERE ARE {counter} as in your name");

                } else
                {

                    Console.WriteLine("There are no A in your name");


                }
            }
        }
    }
}


































