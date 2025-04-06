using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Exceptions.CreditCard
{
    public class CardNumberInvalidException : Exception
    {
        public CardNumberInvalidException() : base("Card Number invalid") { }
        public CardNumberInvalidException(Exception innerException) : base("Card Number invalid", innerException) { }

    }
}
