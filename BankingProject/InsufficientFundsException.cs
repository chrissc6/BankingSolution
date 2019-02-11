using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException() : base() //calling base ctor
        {

        }

        public InsufficientFundsException(string message) : base(message) //taking a string para
        {

        }

        public InsufficientFundsException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
