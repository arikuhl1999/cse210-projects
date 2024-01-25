using System;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
       job1._jobTitle = "Software Engineer";
       job1._company = "Tiki's Vet Clinic";
       job1._startYear = 2007;
       job1._endYear = 2023;
       
    //    job1.display();

       Job job2 = new Job();
       job2._jobTitle = "Cybersecurity";
       job2._company = "Jasper's gun shop";
       job2._startYear = 2010;
       job2._endYear = 2023;

    //    job2.display();


       Resume resume = new Resume();
       resume._name = "Tiki Kuhlmann";
       resume._jobs.Add(job1);
       resume._name = "Irelynd Kelly";
       resume._jobs.Add(job2);
       resume.display();
    }
}