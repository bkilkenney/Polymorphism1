using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    class Savings : Account
    {
        protected static int depositCount = 0;
        public override void Deposit()
        {
            base.Deposit(); //Refers back to Deposit in the Account class.  It is NOT an override. 
            Console.WriteLine("We removed some cash in a different way");
            Savings.depositCount++;  //Should probably create a for loop to increment and watch the number of deposits go up
            Console.WriteLine("You have made " +depositCount+ " deposit to date");
        }       
        public override void Withdraw()
        {

        }
    }
}
