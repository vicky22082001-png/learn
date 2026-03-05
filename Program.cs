using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello from CI/CD Pipeline!");
        Console.WriteLine($"Machine: {Environment.MachineName}");
        Console.WriteLine($"Time: {DateTime.Now}");
    }
}