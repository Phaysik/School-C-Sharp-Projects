using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Bank
    {
        private string accountName;
        private double accountBalance;
        private int accountNum;

        //Properties

        public string AccountName { get { return accountName; } set { accountName = value; } }
        public double AccountBalance { get { return accountBalance; } set { accountBalance = value; } }
        public int AccountNum { get { return accountNum; } set { accountNum = value; } }
    }
}
