using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep1 World!");
        Console.WriteLine("What is your first name? ");
        string firstname = Console.ReadLine();

        Console.WriteLine("What is your last name? ");
        string lastname = Console.ReadLine();
        
        
        System.Console.WriteLine("Your name is "+ lastname + ", " + firstname + " " + lastname +"." );
    }
}