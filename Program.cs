using System;

namespace HelloWorldDemo
{
    class Program
    {
        static void Main(string[] args) {

           Console.WriteLine("Hello Sawyer!"); 
           Console.WriteLine("What is your name?");
           var input = Console.ReadLine();
           Console.WriteLine($"Hello, {input}!");

        }
        
         

    }
}
