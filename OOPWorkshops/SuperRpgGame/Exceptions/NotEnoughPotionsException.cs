using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SuperRpgGame.Exceptions
{
    public class NotEnoughPotionsException : Exception
    {
        public NotEnoughPotionsException(string message) : base(message)
        {
            
        }
    }
}
