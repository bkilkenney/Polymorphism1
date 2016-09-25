using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    class Savings : AccountHolder
    {
        protected static int depositCount = 0;
        protected static int withdrawlCount = 0;

        //Constructor
        public Savings(decimal balance, decimal interestRate) : base(balance)
        {
            InterestRate = interestRate; //Setting InterestRate property equal to interestRate constructor
        }

        //Properties:
        public decimal InterestRate
        {
            get { return InterestRate; }
            set
            {
                if (value > 0)
                {
                    InterestRate = value;
                }
                else
                    throw new Exception("Interest rate must not be negative");
            }
        }
        public decimal SavingsAccountBalance { get; set; }



     //Methods:

        public decimal CalculateInterest()
        {
            return Balance * InterestRate;
        }

        public override void Deposit(decimal dollars)  //Method, override b/c it's the checkinig account's own version of Deposit()
        {
            base.Balance += dollars;
            depositCount++;
        }
        public override bool Withdrawl(decimal dollars)
        {
            bool acceptable = true;  //Bool - Will need either true of false(acceptable)
            if (base.Balance - dollars >= 0)
            {
                base.Balance -= dollars;
                base.Balance += InterestRate;
                acceptable = true;
                withdrawlCount++;
            }
            else
            {
                Console.WriteLine("Withdrawl amount cannot exceed account balance.");
                acceptable = false;
            }
            return acceptable;
        }
    }
}

