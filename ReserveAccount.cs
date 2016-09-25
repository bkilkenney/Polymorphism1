using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    class ReserveAccount : AccountHolder
    {
      //Fields
        
        protected static int depositCount = 0;
        protected static int withdrawlCount = 0;

    //Constructor:
        public ReserveAccount(decimal balance) : base(balance)
        {
            Balance = balance;
        }

    //Properties
    
        public decimal InterestRate { get; private set; }
        public decimal ReserveAccountBalance { get; set; }

    //Methods:
        public decimal CalculateInterest()  //Reserve account gains interest
        {
            return Balance * InterestRate;
        }


        public override void Deposit(decimal dollars) 
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
                Balance += InterestRate;
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
