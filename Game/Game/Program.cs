using System;
using Game.IServices;
using Game.Logic;
using Game.Services;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {

            IFizzBuzzService fizzBuzzService = new FizzBuzzService();

            int number = NumberLogic.ChoiceValidNumber();

            foreach (var result in fizzBuzzService.GetFizzBuzz(number))
            {
                Console.WriteLine(result);
            }

            Console.ReadLine();

        }
    }
        
}