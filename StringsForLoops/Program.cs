﻿using System;
using System.Runtime.CompilerServices;

namespace StringsForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string helloWorld = "Hello World!";

            Console.WriteLine(helloWorld[0]);
            Console.WriteLine(helloWorld[6]);

            int stringLength = helloWorld.Length;
            Console.WriteLine($"Your text is {stringLength}symbols long.");
            char searchCriteria = '0';
            int counter = 0;




            foreach (char letter in helloWorld)
            {
                if (letter == searchCriteria)
                {
                    counter = counter + 1;



                }
                
            }

            Console.WriteLine($"There are {counter} Os in your text");



        }
    }
}   
