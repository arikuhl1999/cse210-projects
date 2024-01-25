class Resume
{
    public string _name;

    public List<Job> _jobs = new List<Job>();

    public void display()
    {
        System.Console.WriteLine($"Name: {_name}");
        System.Console.WriteLine("Jobs: ");
        foreach (var item in _jobs)
        {
           item.display();
        }
    }
}