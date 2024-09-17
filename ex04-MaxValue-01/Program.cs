using System;

namespace Project04
{

    class Program
    {

        static void Main(string[] args)
        {
            // -  Finding   upper value  using class Math with method  Max.

            int firstValue = 500;
            int secondValue = 600;
            int largerValue;

        largerValue = Math.Max(firstValue, secondValue);
        Console.WriteLine($" Maior valor entre {firstValue} e {secondValue} é: {largerValue}");

        }
    }
}