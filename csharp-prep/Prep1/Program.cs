using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep1 World!");
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();
        
        // string concation
        Console.WriteLine("Your name is "+ lastname + ", " + firstname + " " + lastname +"." );

        // string interpolation
        Console.WriteLine($"your name is {lastname}, {lastname} {firstname}");
    }
}