// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    
    static int AddNumbers(int num1, int num2)
    {
        return num1 + num2;
    }

  
    static void Main(string[] args)
    {
        // Call and display AddNumbers function
        int sum = AddNumbers(34, 29);
        Console.WriteLine("Sum: " + sum);

       
    }
}
