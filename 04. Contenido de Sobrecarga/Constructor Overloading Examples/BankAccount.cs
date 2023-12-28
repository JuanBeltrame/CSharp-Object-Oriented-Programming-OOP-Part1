using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading_Examples
{
    internal class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public string AccountType { get; set; }
        public decimal Balance{ get; set; }


        public BankAccount(string accountNumber, string accountHolderName)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = default;
            AccountType = "Savings";
        }

        public BankAccount(string accountNumber, string accountHolderName, string accountType, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            AccountType = accountType;
            Balance = balance;
        }
    }
}
