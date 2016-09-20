using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    class Savings : Account
    {
        public override void Deposit()
        {
            base.Deposit(); //Refers back to Deposit in the Account class.  It is NOT an override. 
            Console.WriteLine("We removed some cash in a different way"); 
        }
        public override void Withdraw()
        {

        }
    }
}
