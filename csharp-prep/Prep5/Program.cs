using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = promptUserName();
        int userNumber = promptUserNumber();
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
        System.Console.WriteLine();
    }

    static string promptUserName()
    {
        System.Console.WriteLine("Please enter your name: ");
        string nameOfHuman = Console.ReadLine();

        return nameOfHuman; 
    }

    static int promptUserNumber()
    {
        Console.Write("Please enter a number: ");
        int 
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