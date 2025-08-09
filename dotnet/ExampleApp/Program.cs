using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        var version = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "unset";
        Console.WriteLine($"Example {version}");
    }
}