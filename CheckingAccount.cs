using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    class CheckingAccount : AccountHolder   //CHECKINGACCOUNT & SAVINGS are derived classes.  ACCOUNT is the base class
    {
     //Fields:
        
        protected static int depositCount = 0;  
        protected static int withdrawlCount = 0;

     //Constructors:
        public CheckingAccount(decimal balance, decimal fee) : base(balance)
        {
            Fee = fee;
        }


        //Properties:
        public new decimal Balance
        {
            get { return base.Balance; }

            set    //Validates that the balance is not negative
            {
                if (value >= 0)
                    base.Balance = value;
                else
                    throw new Exception("Balance cannot be negative");
            }
        }

        public decimal Fee  //Fee for transactions
        {
            get { return Fee; }
            set
            {
                if (value > 0)
                {
                    Fee = value;
                }
                else
                    throw new Exception("Fee cannot be negative.");
            }
         }



     //Methods
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
                base.Balance -= Fee;
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
