// See https://aka.ms/new-console-template for more information


using ProgrammingProblems;
using System.ComponentModel;


internal class Program
{
    private static void Main(string[] args)
    {

        //Console.Write("Enter your name: ");
        //var userName = Console.ReadLine()?.ToLower();
        //ElementaryExercises.Greeting(userName);


        //Console.Write("Enter a number: ");
        //var inputNumber = Convert.ToInt32(Console.ReadLine());
        //ElementaryExercises.SumNumbers(inputNumber);


        //Console.WriteLine(
        //    "Enter a number and two multiples. \n" +
        //    "Numbers between 0 and your input number will be summed only if \n" + 
        //    "they are multiples of the two values you've entered as multiples. \n");
        //Console.Write("Enter a number: ");
        //var enteredNumber = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Enter your first multiple: ");
        //var multipleOne = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Enter your second multiple: ");
        //var multipleTwo = Convert.ToInt32(Console.ReadLine());
        //ElementaryExercises.SumMultiples(enteredNumber, multipleOne, multipleTwo);

        var word = Console.ReadLine();
        var functionOutput = ElementaryExercises.IsPalindrome(word);
        Console.WriteLine($"The word you've entered is a palindrome: {functionOutput}");
        Console.ReadLine();

        //Console.Write("Enter a number: ");
        //var inputNumber = Convert.ToInt32(Console.ReadLine());
        //string userChoice;

        //do
        //{
        //    Console.WriteLine(
        //        "Would you like to compute the sum (a) or the product (b) of the numbers from 1 to your input number? \n" +
        //        "Please type a or b: ");
        //    userChoice = Console.ReadLine()?.ToLower();

        //    if (userChoice == "a")
        //    {
        //        ElementaryExercises.SumNumbers(inputNumber);
        //    }
        //    else if (userChoice == "b")
        //    {
        //        ElementaryExercises.ProductOfNumbers(inputNumber);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input. Please type a or b.");

        //    }
        //} while (userChoice != "a" && userChoice != "b");

    }
}