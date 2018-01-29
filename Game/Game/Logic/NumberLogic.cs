using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Diagnostics;
using System.Reflection;
using Game.Exceptions;

namespace Game.Logic
{
    public class NumberLogic
    {

        public static int ChoiceValidNumber(String numberProvider = null)
        {
            int number = -1;
            
            Console.WriteLine("Introduce a number bigger than 0 and less then infinit.");

            try
            {
                String consoleReadLine = numberProvider ?? Console.ReadLine();
                number = int.Parse(consoleReadLine);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(" ** " + e.Message.ToUpper() + " **");
                throw new PlayLostException("A player who hesitates or makes a mistake is eliminated from the game.");
            }
            catch (FormatException e)
            {
                Console.WriteLine(" ** " + e.Message.ToUpper() + " **");
                throw new PlayLostException("A player who hesitates or makes a mistake is eliminated from the game.");
            }
            
            return number;
        }

    }
}
