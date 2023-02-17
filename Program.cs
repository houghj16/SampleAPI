using System;
using MathLibrary; // Importing Math Library

namespace MathApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare class from MathLibrary
            Class1 math = new Class1();

            // Declare variables and use methods from MathLibrary
            float substract = math.Substract(5, 2);
            float multiply = math.Multiply(5, 2);
            float divide = math.Devide(5, 2);
            float power = math.Power(5);

            // Print results on screen
            Console.WriteLine(substract);
            Console.WriteLine(multiply);
            Console.WriteLine(divide);
            Console.WriteLine(power);

            Console.ReadLine();
        }
    }

    class AnotherClass 
    {
        public void Print()
        {
            Console.WriteLine("hello");
        }
    }

    class AndAnotherClass
    {
        public void Print()
        {
            // Pull Request
            Console.WriteLine("hello");

            // Bug fix
            Console.WriteLine("hello");
            Console.WriteLine("wow!");
            Console.WriteLine("wow!");
        }
    }
}
