using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    abstract class accountHolderName
    {

    //Fields
        private string accountHolderName = "Scrooge McDuck";
        public static int accountNumber = 8675309;
        private decimal balance = 5000.00m;  //decimal is preferred data type for money b/c of it's accuracy

    //Constructor
        public accountHolderName(string username)
        {
            accountHolderName = username;
        }

    //Methods
        //Virtual b/c I'm in the base class
        public virtual decimal Deposit(decimal dollars)  //Add to balance
        {
            balance += dollars;  //Add decimal amount to Balance from property
            return balance;
        }
        
        public virtual decimal Withdrawl(decimal dollars)
        {
            balance -= dollars;
            return balance;
        } 
     }
}

