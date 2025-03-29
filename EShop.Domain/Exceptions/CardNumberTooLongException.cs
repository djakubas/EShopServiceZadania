using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Exceptions
{
    public class CardNumberTooLongException : Exception
    {
        public CardNumberTooLongException() : base("Card Number too short") { }
        public CardNumberTooLongException(Exception innerException) : base("Card Number too short", innerException) { }
    }
}
