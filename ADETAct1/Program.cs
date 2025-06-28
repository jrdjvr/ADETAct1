// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    
    static int AddNumbers(int a, int b)
    {
        return a + b;
    }

  
    static void Main(string[] args)
    {
        // Call and display AddNumbers function
        int sum = AddNumbers(5, 7);
        Console.WriteLine("Sum: " + sum);

       
    }
}