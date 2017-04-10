using System;

namespace Game.Exceptions
{
    public class PlayLostException : Exception
    {

        public PlayLostException()
        {
        }

        public PlayLostException(string message)
        : base(message) {
        }

        public PlayLostException(string message, Exception inner)
        : base(message, inner) { 
        }

    }
}
