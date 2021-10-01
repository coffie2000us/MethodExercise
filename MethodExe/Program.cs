using System;

namespace MethodExe
{
    class Program
    {
        public static void Main(string[] args)
        {
            Exercise1();
            Console.WriteLine(Sum(3, 5));
            Console.WriteLine(Multiply(2, 3));
        }

        public static void Exercise1()
        {
            Console.WriteLine("Hi what is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hello {userName}, What is the name of your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine("Good Job! Look at your profile");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
            
        }
        public static int Multiply(int x, int y)
        {
            return x * y;

        }

    }
    
}
