using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_movies_
{
    public class BankAccount
    {
        public string BankName { get; set; }
        public string AccountNumber { get; set; }

        public BankAccount(string bankName, string accountNumber)
        {
            BankName = bankName;
            AccountNumber = accountNumber;
        }

        public string GetInfo()
        {
            return $"Bank: {BankName}, Account: {AccountNumber}";
        }
    }

}
