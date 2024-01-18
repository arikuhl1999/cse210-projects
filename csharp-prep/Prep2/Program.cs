using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        
        string answer = Console.ReadLine();

        int percentage = int.Parse(answer);

        string gradeLetter = "";

        if (percentage >= 90)
        {
            gradeLetter = "A";
        }

        else if (percentage >= 80)
        {
            gradeLetter = "B";
        }

        else if (percentage >= 70)
        {
            gradeLetter = "C";
        }

        else if (percentage >= 60)
        {
           gradeLetter = "D";
        }

        else
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"You have the grade of: {gradeLetter}");
        Console.WriteLine();

        if (percentage >= 70)
        {
            Console.WriteLine("You are doing great, don't lose sight of your goal. You got this.");
            Console.WriteLine();
        }

        else 
        {
            Console.WriteLine("Keep trying, you can do it.");
            Console.WriteLine();
        }
    }
}

// example of if statement in C# is: 

// always put the {curly braces} on there own line

// if (x > y)
// {
//    Console.writeline("greater than");
// }

// if (x > y)
// {
//     if (x > z)
//     {
//         Console.WriteLine("greater than both");
//     }
// }

// if (X > y)
// {
//     Console.WriteLine("greater than");
// }
// else
// {
//     Console.WriteLine("Less than");
// }

// In python it adds elif but in C# it is else if

// In C#, the and operator is && the or operator is || and the not operator is ! which can be combined together with other expressions and parentheses.
//  examples would be:

// if (name == "Peter" || name == "James" || name == "John")
// {
//     Console.WriteLine("This is a biblical name.");
// }

// if (firstName == "Brigham" && lastName == "Young")
// {
//     Console.WriteLine("Welcome Brother Brigham!");
// }

// if (!(name == "Peter" || name == "James" || name == "John"))
// {
//     Console.WriteLine("This is a not one of those three");
// }

