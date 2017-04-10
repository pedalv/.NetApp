using System;
using Game.IServices;
using Game.Services;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IFizzBuzzService fizzBuzzService = new FizzBuzzService();
            foreach (var result in fizzBuzzService.GetFizzBuzz(100))
            {
                Console.WriteLine(result);
            }

            Console.ReadLine();

        }

    }
    
}