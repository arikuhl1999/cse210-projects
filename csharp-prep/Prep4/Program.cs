using System; 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a series of numbers and to stop press 0.");
        Console.WriteLine();

        var numbers = new List<int>();
        // numbers.Add(8);
        // Console.WriteLine(numbers[0]);
        int userNumbers = 1;
        
        while (userNumbers != 0)
        { 
        System.Console.Write("Enter a number: ");
        userNumbers = int.Parse(Console.ReadLine()); 
        // reading the numbers to be an int to userNumbers

        numbers.Add(userNumbers);
        // System.Console.WriteLine($"{numbers.Last()}");

        }
        
        numbers.Remove(0);
        System.Console.WriteLine();
        Console.WriteLine($"The sum is: {numbers.Sum()}");
        System.Console.WriteLine();
        System.Console.WriteLine($"The average is: {Math.Round(numbers.Average(),2)}");
        System.Console.WriteLine();
        System.Console.WriteLine($"The largest number is: {numbers.Max()}");
        System.Console.WriteLine();
    }
}