using System;

class Job
{
    public string _company;
    
    public string _jobTitle;

    public int _startYear;

    public int _endYear;

    public void display()
    {
        System.Console.WriteLine();
        System.Console.WriteLine($"{_jobTitle} ({_company}) ({_startYear} - {_endYear}).");
        System.Console.WriteLine();
    }
}