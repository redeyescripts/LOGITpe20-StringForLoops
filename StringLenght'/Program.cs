using System;

namespace StringLenght
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //The program asks the users name and displays the length of the name without using the length property
            Console.WriteLine("Enter your name :");
            string UserInput = Console.ReadLine();
            int counter = 0;

            foreach(char letter in UserInput)
            {
                //Console.WriteLine(letter);
                counter = counter + 1;
                Console.WriteLine($"Letter {letter}is at {counter}");


            }
            Console.WriteLine($"Your name is {counter} characters long.");
        }
    }
}
