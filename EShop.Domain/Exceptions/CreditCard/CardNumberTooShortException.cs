using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Exceptions.CreditCard
{
    public class CardNumberTooShortException : Exception
    {
        public CardNumberTooShortException() : base("Card Number too short") { }
        public CardNumberTooShortException(Exception innerException) : base("Card Number too short", innerException) { }
    }
}
