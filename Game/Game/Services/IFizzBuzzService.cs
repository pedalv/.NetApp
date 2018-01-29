using System.Collections.Generic;

namespace Game.IServices
{
    public interface IFizzBuzzService
    {
        IEnumerable<string> GetFizzBuzz(int i);

    }
}
