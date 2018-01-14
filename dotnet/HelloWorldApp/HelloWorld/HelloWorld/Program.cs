using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("\nWhat is your name? ");
            var name = string.Empty;
            do
            {
                name = Console.ReadLine();
            } while (string.IsNullOrEmpty(name));
                        
            var date = DateTime.Now;
            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
            
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
