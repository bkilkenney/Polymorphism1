using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    class AccountHolder
    {

    //Fields
        private string accountHolderName = "Scrooge McDuck";
        private int accountNumber = 8675309;
        private decimal balance = 5000.00m;  //decimal is preferred data type for money b/c of it's accuracy
        
        

    //Constructor to receive initial balance and change it based on new instances
        public AccountHolder(decimal balance)  
        {
            Balance = balance;
        }


    //Properties to access private variables(fields)
        public decimal Balance
        {
            get { return balance; }

            set    //Validates that the balance is not negative
            {
                if (value >= 0)
                    balance = value;
                else
                    throw new Exception("Balance cannot be negative");
            }
        }

        public int value
        {
            get { return value; }
            set { return; }
        }

        //Methods
        //Virtual b/c I'm in the base class
        public virtual void Deposit(decimal dollars)  //Add to balance
        {
            Balance += dollars;  //Add decimal amount to Balance from property
        }
        
        public virtual bool Withdrawl(decimal dollars)
        {
            bool acceptable = true;  //Bool - Will need either true of false(acceptable)
            if(Balance - dollars >=0)
            {
                Balance -= dollars;
                acceptable = true;
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
