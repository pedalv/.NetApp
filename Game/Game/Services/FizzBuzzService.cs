using System.CodeDom;
using System.Collections.Generic;
using Game.Exceptions;
using Game.IServices;
using Game.Logic;

namespace Game.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {

        private List<string> _result;

        public IEnumerable<string> GetFizzBuzz(int i)
        {
            _result = new List<string>();

            if (i < 1)
            {
                throw new PlayLostException("A player who hesitates or makes a mistake is eliminated from the game.");
            }

            for (var input = 1; input <= i; input++)
            {

                var item = FizzBuzzLogic.ValidationRules(input);
                _result.Add(item);
            }

            return _result;
        }

       
    }
}
