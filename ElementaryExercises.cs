using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingProblems
{
    public class ElementaryExercises
    {
        public static void SumNumbers(int inputNumber)
        {
            int sumNumber = 0;
            for (int i = inputNumber; i >= 0; i--)
            {
                sumNumber += i;
            }
            Console.WriteLine($"The sum from 1 to {inputNumber} is {sumNumber}");
        }

        public static void ProductOfNumbers(int inputNumber)
        {
            int productOfNumber = 1;
            for (int i = inputNumber; i > 0; i--)
            {
                productOfNumber *= i;
            }
            Console.WriteLine($"The product of numbers from 1 to {inputNumber} is {productOfNumber}");
        }

        public static void SumMultiples(int enteredNumber, int multipleOne, int multipleTwo)
        {
            int sumNumber = 0;
            for (int i = enteredNumber; i >= 0; i--)
            {
                if (i % multipleOne == 0 || i % multipleTwo == 0)
                {
                    sumNumber += i;
                }

            }
            Console.WriteLine($"The summed of numbers between 0 and {enteredNumber} that are multiples of {multipleOne} or {multipleTwo} is {sumNumber}");
        }

        public static void Greeting(string userName)
        {
            if (userName == "alice" || userName == "bob")
            {
                Console.WriteLine($"Hello, {userName}!");
            }
            else
            {
                Console.WriteLine("Hello, World!");
            }
        }

        public static bool IsPalindrome(string inputString)
        {
            var convertedString = inputString.ToLower().Replace(" ","").Trim();
            Console.WriteLine(convertedString);
            var maxIterations = inputString.Length / 2;
            var lastIndex = inputString.Length - 1;
            var isPalindrome = true;

            for (int i = 0; i < maxIterations; i++)
            {
                if (convertedString[i] != convertedString[lastIndex])
                {
                    isPalindrome = false;
                }
                lastIndex--;
            }
            return isPalindrome;

        }
    }
}
