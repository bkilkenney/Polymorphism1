using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    class Savings : accountHolderName
    {
        //Fields:
        private decimal balance;
        private new int accountNumber = 1357902;

        //Constructor
        public Savings(string accountHolderName) : base(accountHolderName)
        {
        }

        //Properties:
        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }



        //Methods
        public override decimal Deposit(decimal dollars)  //Method, override b/c it's the checkinig account's own version of Deposit()
        {
            this.balance += dollars;
            return balance;
        }

        public override decimal Withdrawl(decimal dollars)  //Method, override b/c it's the checkinig account's own version of Deposit()
        {
            this.balance -= dollars;
            return balance;
        }

    }
}

