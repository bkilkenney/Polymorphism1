using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    class CheckingAccount : Account   //CHECKINGACCOUNT & SAVINGS are derived classes.  ACCOUNT is the base class
    {
        public override void Deposit()
        {
            base.Deposit();  //This part of the method can be called from the base class, it doesn't need to be overwritten
        }
        public override void Withdraw()
        {

        }
    }
}
