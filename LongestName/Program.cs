using System;

namespace LongestName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("enter the first name");
            string nameOne = Console.ReadLine();
            string nameTwo = Console.ReadLine();
            int lengthOne = 0;
            int lenghtTwo = 0;

            // lenght nameOne
            foreach (char letter in nameOne)
            {
                lengthOne = lengthOne + 1;

            }
            foreach (char letter in nameTwo)
            {
                lenghtTwo = lenghtTwo + 1;

            }
            if (lengthOne > lenghtTwo)

            {
                Console.WriteLine("Name One is the longest");
            } else if (lengthOne > lenghtTwo)
            {
                Console.WriteLine("Name One is the longest");
            } else
            {
                Console.WriteLine("Both name are of the same lenght.");

            }

        }
    }
}
