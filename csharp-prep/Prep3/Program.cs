using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Guess my number game: ");
        Console.WriteLine();

        Random randomObject = new Random();
        // 

        int magicNumber = randomObject.Next(1,100);

        int userGuess = 0;

        int count = 0;

        while (userGuess != magicNumber)
        {
        Console.WriteLine("What is your guess? ");
        userGuess = int.Parse(Console.ReadLine());
        // that line is taking what the user said and turning it into an integer
        count += 1;

        if (userGuess < magicNumber)
        {
            System.Console.WriteLine("Higher \n");
        }

        else if (userGuess > magicNumber)
        {
            System.Console.WriteLine("Lower\n");
        }

        else
        {
            System.Console.WriteLine("Awesome sauce, you guessed it.\n");
        }
        }

        System.Console.WriteLine($"It took you {count} guesses.");
        System.Console.WriteLine();
    }
}