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

        public Savings(decimal balance) : base(balance)
        {
        }

        public decimal SavingsAccountBalance { get; set; }


        public override void Deposit()
        {
            Deposit();
            depositCount++;
        }       
        public override void Withdrawl()
        {
            Withdrawl();
            withdrawlCount++;
        }
    }
}

//The following are some actions that can be taken in the deposit body.  When the deposit methods are called the count will go up
//base.Deposit(); //Refers back to Deposit in the AccountHolder class.  It is NOT an override. 
//Console.WriteLine("We removed some cash in a different way");
//Savings.depositCount++;  //Should probably create a for loop to increment and watch the number of deposits go up
//Console.WriteLine("You have made " +depositCount+ " deposit to date");