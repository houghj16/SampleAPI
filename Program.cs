using System;
using MathLibrary; // Importing Math Library

namespace MathApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare class from MathLibrary.dll
            Class1 math = new Class1();

            // Declare variables and use methods from MathLibrary
            float substract = math.Substract(5, 2);
            float multiply = math.Multiply(5, 2);
            float devide = math.Devide(5, 2);
            float power = math.Power(5);

            Console.WriteLine("This Application uses functions from MathLibrary.dll todo simple calculations");

            // Print results on screen
            Console.WriteLine(substract);
            Console.WriteLine(multiply);
            Console.WriteLine(devide);
            Console.WriteLine(power);

            Console.ReadLine();
        }
    }
}
