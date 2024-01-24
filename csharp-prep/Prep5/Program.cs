using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = promptUserName();
        int userNumber = promptUserNumber();

        int squaredNumber = squareNumber(userNumber);

        displayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
        System.Console.WriteLine();
    }

    static string promptUserName()
    {
        System.Console.Write("Please enter your name: ");
        // asks the user to input there name
        
        string nameOfHuman = Console.ReadLine();
        // the info is being stored 

        string capitalizingName = nameOfHuman.First().ToString().ToUpper() + nameOfHuman.Substring(1);
        // creates a new string
        // the first letter capitalized, but this string is not used further

        Console.WriteLine(capitalizingName);
        // displays the capitalized name to the console, but it's not returned from the function.

        return nameOfHuman; 
    }

    static int promptUserNumber()
    {
        Console.Write("Please enter a number: ");
        // asks the user 
        int number = int.Parse(Console.ReadLine());
        // takes the input

        return number;
        // this returns what they said
    }

    static int squareNumber(int number)
    {
        int square = number * number; 
        // 
        return square;
    }

    static void displayResult(string name, int square)
    {
        System.Console.WriteLine($"{name}, the square of your number is {square} ");
    }

}

/*
 voids help return functions without using the word return. It is empty it doesn't give you anything back.

 return type FunctionName(dataType parameter1, dataType parameter2)
{
    //function body
}

 void DisplayMessage()
 {
    console.writeline ("Hello World!");
 }


 */