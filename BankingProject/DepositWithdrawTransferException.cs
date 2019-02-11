using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class DepositWithdrawTransferException : Exception
    {
        public DepositWithdrawTransferException() : base()
        {

        }

        public DepositWithdrawTransferException(string message) : base(message)
        {

        }

        public DepositWithdrawTransferException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
