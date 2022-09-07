using System;
using System.Drawing;
using System.Reflection;

namespace MethodExercise
{
    class Program

        ///------Exercise 2----------
        
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }


        static void Main(string[] args)
        {
            var amountOfBooks = Sum(55, 45);
            var amountOfCookies = Multiply(5, 6, 2);
            var amountOfKittens = Subtract(12, 10);
            var amountOfSteaks = Divide(25, 5);





            //-----------------Exercise 1-------------
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

            Console.WriteLine($"Thanks {userName}, here is your profile!");
            Console.WriteLine("----------");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite color: {color}");
            Console.WriteLine($"Favorite animal: {animal}");
            Console.WriteLine($"Favorite band: {band}");

            //exercise 2


        }
    }
}

