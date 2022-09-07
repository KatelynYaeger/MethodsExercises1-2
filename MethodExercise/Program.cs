using System;
using System.Drawing;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            //Your Name
            //Your Favorite Color
            //Your Favorite Animal
            //Your Favorite Band

            Console.WriteLine("Hello friend! What is your name?");

            var userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}! What is your favorite color?");

            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an amazing color! What is your favorite animal?");

            var animal = Console.ReadLine();

            Console.WriteLine("Another good choice! What about your favorite band?");

            var band = Console.ReadLine();
        }
    }
}

